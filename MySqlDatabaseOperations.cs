using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Management_System
{

    public class MySqlDatabaseOperations : IDatabaseOperations
    {
        private string connectionString = "server=database-1.c7e2oyq4onm0.eu-north-1.rds.amazonaws.com;user id=admin;password=A871218ss5168;database=management_system; port = 3306";


        public void InsertUser(string username, string password, string phoneNum)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "insert into users(user_name, user_password, phone_num) values (@username, @password, @phone_num)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@phone_num", phoneNum);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public string GetUserPassword(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                String query = "select user_password from users where user_name = @username";//select the password from database
                MySqlCommand cmd = new MySqlCommand(query, connection);//create a command
                cmd.Parameters.AddWithValue("@username", username);//bind the parameter
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();//execute the command
                if (dr.Read())//read the data from database
                {
                    return dr.GetString(0);//get the password from database
                }
                else
                {
                    return null;//if the username is not found, return null
                }
            }
        }
        //read all project_naame from database
        public List<string> LoadProjects()
        {
            List<string> projectNames = new List<string>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                String query = "select project_name from projects";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    projectNames.Add(dr.GetString(0));
                }
            }

            return projectNames;
        }
        public void InsertProject(string projectName, string projectDescription)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "insert into projects(project_name, project_description) values (@project_name, @project_description)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@project_name", projectName);
                cmd.Parameters.AddWithValue("@project_description", projectDescription);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void EditProject(string projectName, string projectDescription)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //update the project_description and project_name
                string query = "update projects set project_description = @project_description where project_name = @project_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@project_name", projectName);
                cmd.Parameters.AddWithValue("@project_description", projectDescription);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteProject(string projectName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                //delete the project
                string query = "delete from projects where project_name = @project_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@project_name", projectName);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public string GetProjectID(string projectName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT project_id FROM projects WHERE project_name = @project_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@project_name", projectName);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return reader["project_id"].ToString();
                }
                else
                {
                    throw new Exception("Project not found");
                }
            }
        }
        public List<string> LoadRequirements(string projectName)
        {
            List<string> requirementNames = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string projectID = GetProjectID(projectName);
                string query = "select requirement_name from requirements where project_id = @project_id and IsDeleted = 0 and requirement_status != 'Deactive'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@project_id", projectID);
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    requirementNames.Add(dr.GetString(0));
                }
            }
            return requirementNames;
        }
        public List<string> ListAllRequirements()
        {
            List<string> requirementNames = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "select requirement_name from requirements where IsDeleted = 0 and requirement_status != 'Deactive'";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    requirementNames.Add(dr.GetString(0));
                }
            }
            return requirementNames;
        }
        public string GetRequirementID(string requirementName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT requirement_id FROM requirements WHERE requirement_name = @requirement_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@requirement_name", requirementName);
                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return reader["requirement_id"].ToString();
            }
        }
        public void InsertRequirement(string projectName, string requirementName, string requirementDescription, string requirementStatus, string requirementVersion)
        {
            //still missing dependencies
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string projectID = GetProjectID(projectName);
                string query = "insert into requirements(project_id, requirement_name, requirement_description, requirement_status, requirement_version, requirement_created_at, requirement_updated_at) values (@project_id, @requirement_name, @requirement_description, @requirement_status, @requirement_version, @requirement_created_at, @requirement_updated_at)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@project_id", projectID);
                cmd.Parameters.AddWithValue("@requirement_name", requirementName);
                cmd.Parameters.AddWithValue("@requirement_description", requirementDescription);
                cmd.Parameters.AddWithValue("@requirement_status", requirementStatus);
                cmd.Parameters.AddWithValue("@requirement_version", requirementVersion);
                cmd.Parameters.AddWithValue("@requirement_created_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@requirement_updated_at", DateTime.Now);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        private string IncreaseVersionNumber(string currentVersion)
        {
            int versionNumber = int.Parse(currentVersion);
            versionNumber++;
            return versionNumber.ToString();
        }
        public void UpdateRequirement(string projectName, string requirementID, string requirementName, string requirementStatus)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string projectID = GetProjectID(projectName);
                string versionQuery = "select requirement_version from requirements where requirement_id = @requirement_id";
                MySqlCommand versionCmd = new MySqlCommand(versionQuery, connection);
                versionCmd.Parameters.AddWithValue("@requirement_id", requirementID);
                connection.Open();
                string currentVersion = versionCmd.ExecuteScalar().ToString();
                connection.Close();
                string newVersion = IncreaseVersionNumber(currentVersion);
                // insert the current requirement into requirements_history
                string insertHistoryQuery = "insert into requirements_history select * from requirements where requirement_id = @requirement_id";
                MySqlCommand insertHistoryCmd = new MySqlCommand(insertHistoryQuery, connection);
                insertHistoryCmd.Parameters.AddWithValue("@requirement_id", requirementID);
                connection.Open();
                insertHistoryCmd.ExecuteNonQuery();
                connection.Close();
                // update the requirement
                string updateQuery = "update requirements set requirement_status = @requirement_status, requirement_version = @requirement_version, requirement_updated_at = @requirement_updated_at where project_id = @project_id and requirement_name = @requirement_name";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@project_id", projectID);
                updateCmd.Parameters.AddWithValue("@requirement_name", requirementName);
                updateCmd.Parameters.AddWithValue("@requirement_status", requirementStatus);
                updateCmd.Parameters.AddWithValue("@requirement_version", newVersion);
                updateCmd.Parameters.AddWithValue("@requirement_updated_at", DateTime.Now);
                connection.Open();
                updateCmd.ExecuteNonQuery();
            }
        }
        public void DeleteRequirement(string requirementId, string requirementName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // start a new transaction
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    //insert the current requirement into requirements_history
                    string insertHistoryQuery = "insert into requirements_history select * from requirements where requirement_id = @requirement_id";
                    MySqlCommand insertHistoryCmd = new MySqlCommand(insertHistoryQuery, connection);
                    insertHistoryCmd.Parameters.AddWithValue("@requirement_id", requirementId);
                    insertHistoryCmd.ExecuteNonQuery();

                    // delete the requirement
                    string query = "update requirements set IsDeleted = true, requirement_updated_at = @requirement_updated_at where requirement_id = @requirement_id and requirement_name = @requirement_name";
                    MySqlCommand updateCmd = new MySqlCommand(query, connection);
                    updateCmd.Parameters.AddWithValue("@requirement_id", requirementId);
                    updateCmd.Parameters.AddWithValue("@requirement_name", requirementName);
                    updateCmd.Parameters.AddWithValue("@requirement_updated_at", DateTime.Now);
                    updateCmd.ExecuteNonQuery();

                    // if those two commands are executed successfully, then commit the transaction
                    transaction.Commit();
                }
                catch
                {
                    // if any exception occurs, then rollback the transaction
                    transaction.Rollback();
                    throw;
                }
            }
        }


        public void Logout()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
        public List<string> LoadDependencies(string requirementName)
        {
            List<string> dependencies = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "select requirement_id from requirements where requirement_name = @requirement_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@requirement_name", requirementName);
                connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    reader.Close();
                    // 连接requirements表和requirement_dependencies表
                    query = @"select r.requirement_name 
                      from requirement_dependencies d 
                      inner join requirements r on d.dependent_requirement_id = r.requirement_id 
                      where d.requirement_id = @requirement_id";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@requirement_id", id);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string dependencyName = reader.GetString(0);
                        dependencies.Add(dependencyName);
                    }
                }
                reader.Close();
            }
            return dependencies;
        }
        public int GetDependencyID(string requirementID, string dependentRequirementID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                const string query = "select dependency_id from requirement_dependencies where requirement_id = @requirement_id and dependent_requirement_id = @dependent_requirement_id";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@requirement_id", requirementID);
                    cmd.Parameters.AddWithValue("@dependent_requirement_id", dependentRequirementID);
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {

                        int dependencyId = 0;

                        if (reader.Read())
                        {
                            int.TryParse(reader.GetInt32(0).ToString(), out dependencyId);
                        }

                        return dependencyId;
                    }
                }
            }
        }

        // if you need to finish B, first you need to finish A. In this case, B is dependent on A, and B is requirementName, A is dependentRequirementName
        public void InsertDependency(string requirementName, string dependentRequirementName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "select requirement_id from requirements where requirement_name = @requirement_name";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@requirement_name", requirementName);
                connection.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int requirementId = reader.GetInt32(0);
                    reader.Close();

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@requirement_name", dependentRequirementName);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int dependentRequirementId = reader.GetInt32(0);
                        reader.Close();

                        query = "insert into requirement_dependencies(requirement_id, dependent_requirement_id) values (@requirement_id, @dependent_requirement_id)";
                        cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@requirement_id", requirementId);
                        cmd.Parameters.AddWithValue("@dependent_requirement_id", dependentRequirementId);
                        cmd.ExecuteNonQuery();
                    }
                }
                reader.Close();
            }
        }

        /*public void UpdateDependency(int dependencyId, string dependencyDescription)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "update requirement_dependencies set dependency_description = @dependency_description where dependency_id = @dependency_id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@dependency_id", dependencyId);
                cmd.Parameters.AddWithValue("@dependency_description", dependencyDescription);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }*/
        public void DeleteDependency(int dependencyId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "delete from requirement_dependencies where dependency_id = @dependency_id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@dependency_id", dependencyId);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public string GetUserId(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "select user_id from users where user_name = @username";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return null;
                }
            }
        }
        public bool IsSuperAdmin(string userId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "select role from user_roles where user_id = @userId";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@userId", userId);
                connection.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString() == "SuperAdmin";
                }
                else
                {
                    return false;
                }

            }
        }
        public void LoadUserRoles(string userId, Dictionary<string, string> userRoles)
        {
            // Clear the dictionary before loading new roles
            userRoles.Clear();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Use a parameterized query to prevent SQL injection
                    string sql = "SELECT * FROM user_roles WHERE user_id = @userId";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string projectId = reader["project_id"].ToString();
                                string userRole = reader["role"].ToString();

                                // Store the user's role in each project
                                userRoles[projectId] = userRole;
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any errors that occur during the database operations
                Console.WriteLine("An error occurred while loading user roles: " + ex.Message);
            }
        }
        public List<string> ListUsers()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "SELECT user_name FROM users";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            List<string> users = new List<string>();

                            while (reader.Read())
                            {
                                string username = reader["user_name"].ToString();
                                users.Add(username);
                            }

                            return users;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any errors that occur during the database operations
                Console.WriteLine("An error occurred while listing users: " + ex.Message);
                return new List<string>();
            }

        }
        public void SetProjectAdmin(string userId, string projectId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "INSERT INTO user_roles (user_id, project_id, role, create_time) VALUES (@userId, @projectId, 'Admin', @create_time)";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.Parameters.AddWithValue("@projectId", projectId);
                        command.Parameters.AddWithValue("@create_time", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle any errors that occur during the database operations
                Console.WriteLine("An error occurred while setting project admin: " + ex.Message);
            }
        }
    }

}

