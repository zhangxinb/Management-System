using Management_System;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

/// <summary>
/// Represents the operations performed on the MySQL database.
/// </summary>
public class MySqlDatabaseOperations : IDatabaseOperations
{
    // The connection string to the database
    private string connectionString = "server=database-1.c7e2oyq4onm0.eu-north-1.rds.amazonaws.com;user id=admin;password=A871218ss5168;database=management_system; port = 3306";
    /// <summary>
    ///  For all the void methods, they are used to insert, update, delete data from the database.
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="parameters"></param>
    public void ExecuteNonQuery(string sql, params MySqlParameter[] parameters)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();
            using (MySqlCommand cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddRange(parameters);
                cmd.ExecuteNonQuery();
            }
        }
    }
    /// <summary>
    /// For all the void methods, they are used to insert, update, delete data from the database.
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="parameters"></param>
    /// <param name="connection"></param>
    /// <param name="transaction"></param>
    public void ExecuteNonQuery(string sql, MySqlParameter[] parameters, MySqlConnection connection, MySqlTransaction transaction)
    {
        using (MySqlCommand cmd = new MySqlCommand(sql, connection, transaction))
        {
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
        }
    }
    /// <summary>
    /// Insert a new user into the database.
    /// </summary>
    /// <param name="username">The username of the user.</param>
    /// <param name="password">The password of the user.</param>
    /// <param name="phoneNum">The phone number of the user.</param>
    public void InsertUser(string username, string password, string phoneNum)
    {
        string sql = "INSERT INTO users (user_name, user_password, phone_num) VALUES (@Username, @Password, @PhoneNum)";
        MySqlParameter[] parameters = {
            new MySqlParameter("@Username", username),
            new MySqlParameter("@Password", password),
            new MySqlParameter("@PhoneNum", phoneNum)
        };
        ExecuteNonQuery(sql, parameters);
    }

    /// <summary>
    /// Get the password of a user from the database.
    /// </summary>
    /// <param name="username">The username of the user.</param>
    /// <returns>The password of the user.</returns>
    public string GetUserPassword(string username)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            String query = "select user_password from users where user_name = @username";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return dr.GetString(0);
            }
            else
            {
                return null;
            }
        }
    }

    /// <summary>
    /// Load all project names from the database.
    /// </summary>
    /// <returns>A list of project names.</returns>
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
    /// <summary>
    /// Manage a project in the database.
    /// </summary>
    /// <param name="projectName"></param>
    /// <param name="projectDescription"></param>
    /// <param name="isInsert"></param>
    /// <param name="isDelete"></param>
    public void ManageProject(string projectName, string projectDescription, bool isInsert, bool isDelete = false)
    {
        string sql;
        MySqlParameter[] parameters;

        if (isInsert)
        {
            sql = "INSERT INTO projects (project_name, project_description) VALUES (@ProjectName, @ProjectDescription)";
            parameters = new MySqlParameter[] {
            new MySqlParameter("@ProjectName", projectName),
            new MySqlParameter("@ProjectDescription", projectDescription)
        };
        }
        else if (isDelete)
        {
            sql = "DELETE FROM projects WHERE project_name = @ProjectName";
            parameters = new MySqlParameter[] {
            new MySqlParameter("@ProjectName", projectName)
        };
        }
        else
        {
            sql = "UPDATE projects SET project_description = @ProjectDescription WHERE project_name = @ProjectName";
            parameters = new MySqlParameter[] {
            new MySqlParameter("@ProjectName", projectName),
            new MySqlParameter("@ProjectDescription", projectDescription)
        };
        }

        ExecuteNonQuery(sql, parameters);
    }
    /// <summary>
    /// Manage a requirement in the database.
    /// </summary>
    /// <param name="projectID"></param>
    /// <param name="requirementID"></param>
    /// <param name="requirementName"></param>
    /// <param name="requirementDescription"></param>
    /// <param name="requirementStatus"></param>
    /// <param name="requirementVersion"></param>
    /// <param name="isInsert"></param>
    /// <param name="isDelete"></param>
    public void ManageRequirement(string projectID, string requirementID, string requirementName, string requirementDescription, string requirementStatus, string requirementVersion, bool isInsert, bool isDelete = false)
    {
        try
        {
            string sql;
            MySqlParameter[] parameters;

            if (isInsert)
            {
                sql = "INSERT INTO requirements(project_id, requirement_name, requirement_description, requirement_status, requirement_version, requirement_created_at, requirement_updated_at) values (@ProjectId, @RequirementName, @RequirementDescription, @RequirementStatus, @RequirementVersion, @RequirementCreatedAt, @RequirementUpdatedAt)";
                parameters = new MySqlParameter[]
                {
                new MySqlParameter("@ProjectId", projectID),
                new MySqlParameter("@RequirementName", requirementName),
                new MySqlParameter("@RequirementDescription", requirementDescription),
                new MySqlParameter("@RequirementStatus", requirementStatus),
                new MySqlParameter("@RequirementVersion", requirementVersion),
                new MySqlParameter("@RequirementCreatedAt", DateTime.Now),
                new MySqlParameter("@RequirementUpdatedAt", DateTime.Now)
                };
                ExecuteNonQuery(sql, parameters);
            }
            else if (isDelete)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertHistoryQuery = "INSERT INTO requirements_history (requirement_id, requirement_name, requirement_status, requirement_version, requirement_updated_at, project_id, requirement_description, requirement_created_at) SELECT requirement_id, requirement_name, requirement_status, requirement_version, requirement_updated_at, project_id, requirement_description, requirement_created_at FROM requirements WHERE requirement_id = @RequirementID";
                            using (MySqlCommand insertHistoryCmd = new MySqlCommand(insertHistoryQuery, connection))
                            {
                                insertHistoryCmd.Parameters.AddWithValue("@RequirementID", requirementID);
                                insertHistoryCmd.ExecuteNonQuery();
                            }

                            string deleteQuery = "UPDATE requirements SET IsDeleted = true, requirement_updated_at = @RequirementUpdatedAt WHERE requirement_id = @RequirementID";
                            MySqlParameter[] deleteParameters = new MySqlParameter[]
                            {
                            new MySqlParameter("@RequirementID", requirementID),
                            new MySqlParameter("@RequirementUpdatedAt", DateTime.Now)
                            };
                            ExecuteNonQuery(deleteQuery, deleteParameters, connection, transaction);

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string versionQuery = "select requirement_version from requirements where requirement_id = @RequirementID";
                    MySqlCommand versionCmd = new MySqlCommand(versionQuery, connection);
                    versionCmd.Parameters.AddWithValue("@RequirementID", requirementID);
                    connection.Open();
                    string currentVersion = versionCmd.ExecuteScalar().ToString();
                    connection.Close();
                    string newVersion = IncreaseVersionNumber(currentVersion);

                    string insertHistoryQuery = "INSERT INTO requirements_history (requirement_id, requirement_name, requirement_status, requirement_version, requirement_updated_at, project_id, requirement_description, requirement_created_at) SELECT requirement_id, requirement_name, requirement_status, requirement_version, requirement_updated_at, project_id, requirement_description, requirement_created_at FROM requirements WHERE requirement_id = @RequirementID";
                    MySqlCommand insertHistoryCmd = new MySqlCommand(insertHistoryQuery, connection);
                    insertHistoryCmd.Parameters.AddWithValue("@RequirementID", requirementID);
                    connection.Open();
                    insertHistoryCmd.ExecuteNonQuery();
                    connection.Close();

                    sql = "UPDATE requirements SET requirement_status = @RequirementStatus, requirement_version = @RequirementVersion, requirement_updated_at = @RequirementUpdatedAt WHERE requirement_id = @RequirementID";
                    parameters = new MySqlParameter[]
                    {
               // new MySqlParameter("@RequirementDescription", requirementDescription),
                    new MySqlParameter("@RequirementStatus", requirementStatus),
                    new MySqlParameter("@RequirementVersion", newVersion),
                    new MySqlParameter("@RequirementUpdatedAt", DateTime.Now),
                    new MySqlParameter("@RequirementID", requirementID)
                    };
                    ExecuteNonQuery(sql, parameters);
                }
            }
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("An error occurred while managing requirement: " + ex.Message);
        }
    }
    /// <summary>
    /// Get the project ID from the database.
    /// </summary>
    /// <param name="projectName">The name of the project.</param>
    /// <returns>The ID of the project.</returns>
    public string GetProjectID(string projectName)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }

    /// <summary>
    /// Load all requirements of a project from the database.
    /// </summary>
    /// <param name="projectName">The name of the project.</param>
    /// <returns>A list of requirement names.</returns>
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

    /// <summary>
    /// Load all requirements from the database.
    /// </summary>
    /// <returns>A list of requirement names.</returns>
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

    /// <summary>
    /// Load all requirements that a user can see from the database.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A list of requirement names.</returns>
    public List<string> ListAllRequirementsYouCanSee(string userId)
    {
        HashSet<string> requirementNames = new HashSet<string>();
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = @"SELECT requirement_name FROM requirements WHERE IsDeleted = 0 AND requirement_status != 'Deactive' AND 'SuperAdmin' IN (SELECT role FROM user_roles WHERE user_id = @userId) OR project_id IN (SELECT project_id FROM user_roles WHERE user_id = @userId)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                requirementNames.Add(dr.GetString(0));
            }
        }
        return new List<string>(requirementNames);
    }

    /// <summary>
    /// Load all projects that a user can see from the database.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>A list of project name</returns>
    public List<string> ListAllProjectsYouCanSee(string userId)
    {
        HashSet<string> projectNames = new HashSet<string>();
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = @"SELECT project_name FROM projects WHERE 'SuperAdmin' IN (SELECT role FROM user_roles WHERE user_id = @userId) OR project_id IN (SELECT project_id FROM user_roles WHERE user_id = @userId)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                projectNames.Add(dr.GetString(0));
            }
        }
        return new List<string>(projectNames);
    }
    /// <summary>
    /// Get the requirement ID from the database.
    /// </summary>
    /// <param name="requirementName">The name of the requirement.</param>
    /// <returns>The ID of the requirement.</returns>
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

    /// <summary>
    /// Increase the version number.
    /// </summary>
    /// <param name="currentVersion">The current version number.</param>
    /// <returns>The increased version number.</returns>
    private string IncreaseVersionNumber(string currentVersion)
    {
        int versionNumber = int.Parse(currentVersion);
        versionNumber++;
        return versionNumber.ToString();
    }
 
    /// <summary>
    /// Disconnect from the database.
    /// </summary>
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

    /// <summary>
    /// Load all dependencies of a requirement from the database.
    /// </summary>
    /// <param name="requirementName">The name of the requirement.</param>
    /// <returns>A list of dependency names.</returns>
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

    /// <summary>
    /// Get the ID of a dependency from the database.
    /// </summary>
    /// <param name="requirementID">The ID of the requirement.</param>
    /// <param name="dependentRequirementID">The ID of the dependent requirement.</param>
    /// <returns>The ID of the dependency.</returns>
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
    /// <summary>
    /// Inserts a new dependency into the database.
    /// </summary>
    /// <param name="requirementName">The name of the requirement.</param>
    /// <param name="dependentRequirementName">The name of the dependent requirement.</param>
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
    /// <summary>
    /// Deletes a dependency from the database.
    /// </summary>
    /// <param name="dependencyId">The ID of the dependency.</param>
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

    /// <summary>
    /// Manage a dependency in the database.
    /// </summary>
    /// <param name="requirementName"></param>
    /// <param name="dependentRequirementName"></param>
    /// <param name="dependencyDescriptionID"></param>
    /// <param name="isInsert"></param>
    /// <param name="isDelete"></param>
    public void ManageDependency(string requirementName, string dependentRequirementName, string dependencyDescriptionID, bool isInsert, bool isDelete = false)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string requirementIdQuery = "select requirement_id from requirements where requirement_name = @requirement_name";
                    MySqlCommand requirementIdCmd = new MySqlCommand(requirementIdQuery, connection);
                    requirementIdCmd.Parameters.AddWithValue("@requirement_name", requirementName);
                    int requirementId = Convert.ToInt32(requirementIdCmd.ExecuteScalar());

                    string dependentRequirementIdQuery = "select requirement_id from requirements where requirement_name = @dependent_requirement_name";
                    MySqlCommand dependentRequirementIdCmd = new MySqlCommand(dependentRequirementIdQuery, connection);
                    dependentRequirementIdCmd.Parameters.AddWithValue("@dependent_requirement_name", dependentRequirementName);
                    int dependentRequirementId = Convert.ToInt32(dependentRequirementIdCmd.ExecuteScalar());

                    if (isInsert)
                    {
                        string insertDependencyQuery = "insert into requirement_dependencies(requirement_id, dependent_requirement_id, dependency_description_id) values (@requirement_id, @dependent_requirement_id, @dependency_description_id)";
                        MySqlCommand insertDependencyCmd = new MySqlCommand(insertDependencyQuery, connection, transaction);
                        insertDependencyCmd.Parameters.AddWithValue("@requirement_id", requirementId);
                        insertDependencyCmd.Parameters.AddWithValue("@dependent_requirement_id", dependentRequirementId);
                        insertDependencyCmd.Parameters.AddWithValue("@dependency_description_id", dependencyDescriptionID);
                        insertDependencyCmd.ExecuteNonQuery();
                    }
                    else if (isDelete)
                    {
                        string deleteDependencyQuery = "delete from requirement_dependencies where requirement_id = @requirement_id and dependent_requirement_id = @dependent_requirement_id";
                        MySqlCommand deleteDependencyCmd = new MySqlCommand(deleteDependencyQuery, connection, transaction);
                        deleteDependencyCmd.Parameters.AddWithValue("@requirement_id", requirementId);
                        deleteDependencyCmd.Parameters.AddWithValue("@dependent_requirement_id", dependentRequirementId);
                        deleteDependencyCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("An error occurred while managing dependency: " + ex.Message);
        }
    }
    /// <summary>
    /// Get the dpendency description from the database.
    /// </summary>
    /// <returns></returns>
    public List<string> ListAllDependencyExplanation()
    {
        List<string> dependencyExplanations = new List<string>();
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "select dependency_description from dependency_description";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dependencyExplanations.Add(dr.GetString(0));
            }
        }
        return dependencyExplanations;
    }
    /// <summary>
    /// Get the ID of a dependency description from the database.
    /// </summary>
    /// <param name="dependencyDescription"></param>
    /// <returns></returns>
    public string GetDependencyDescriptionID(string dependencyDescription)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "select dependency_description_id from dependency_description where dependency_description = @dependency_description";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@dependency_description", dependencyDescription);
            connection.Open();
            return cmd.ExecuteScalar().ToString();
        }
    }
    /// <summary>
    /// Retrieves the ID of a user from the database.
    /// </summary>
    /// <param name="username">The username of the user.</param>
    /// <returns>The ID of the user.</returns>
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
    /// <summary>
    /// Checks if a user is a super admin.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>True if the user is a super admin, false otherwise.</returns>
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
    /// <summary>
    /// Loads the roles of a user from the database.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="userRoles">A dictionary to store the user roles.</param>
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
    /// <summary>
    /// Lists all users except the super admin.
    /// </summary>
    /// <returns>A list of user names.</returns>
    public List<string> ListAllUsersExceptSadmin()
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT user_name FROM users WHERE user_name != 'admin'";
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
    /// <summary>
    /// Sets a user as the admin of a project.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="projectId">The ID of the project.</param>
    public void SetProjectAdmin(string userId, string projectId)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // get the user ID of the original admin
                string oldAdminUserId = AdminOfProject(projectId);

                // if there is an old admin, update the role to 'User'
                if (!string.IsNullOrEmpty(oldAdminUserId))
                {
                    string updateOldAdminSql = "UPDATE user_roles SET role = 'User' WHERE user_id = @oldAdminUserId AND project_id = @projectId";
                    MySqlCommand updateOldAdminCommand = new MySqlCommand(updateOldAdminSql, connection);
                    updateOldAdminCommand.Parameters.AddWithValue("@oldAdminUserId", oldAdminUserId);
                    updateOldAdminCommand.Parameters.AddWithValue("@projectId", projectId);
                    updateOldAdminCommand.ExecuteNonQuery();
                }

                //check if the user is already a member of the project
                string checkSql = "SELECT COUNT(*) FROM user_roles WHERE user_id = @userId AND project_id = @projectId";
                MySqlCommand checkCommand = new MySqlCommand(checkSql, connection);
                checkCommand.Parameters.AddWithValue("@userId", userId);
                checkCommand.Parameters.AddWithValue("@projectId", projectId);
                int count = Convert.ToInt32(checkCommand.ExecuteScalar());

                //if the user is already a member of the project, update the role
                //if the user is not a member of the project, insert the user into the user_roles table
                string sql = count > 0 ?
                    "UPDATE user_roles SET role = 'Admin', create_time = @create_time WHERE user_id = @userId AND project_id = @projectId" :
                    "INSERT INTO user_roles (user_id, project_id, role, create_time) VALUES (@userId, @projectId, 'Admin', @create_time)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@projectId", projectId);
                command.Parameters.AddWithValue("@create_time", DateTime.Now);
                command.ExecuteNonQuery();
            }
        }
        catch (MySqlException ex)
        {
            // Handle any errors that occur during the database operations
            Console.WriteLine("An error occurred while setting project admin: " + ex.Message);
        }
    }

    /// <summary>
    /// Links a user to a project.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="projectId">The ID of the project.</param>
    public void LinkUserToProject(string userId, string projectId)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO user_roles (user_id, project_id, role, create_time) VALUES (@userId, @projectId, 'User', @create_time)";
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
            Console.WriteLine("An error occurred while linking user to project: " + ex.Message);
        }
    }
    /// <summary>
    /// Checks if a user is an admin of any projects.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>True if the user is an admin of any projects, false otherwise.</returns>
    public bool IsAdminOfAnyProjects(string userId)
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
                return result.ToString() == "Admin";
            }
            else
            {
                return false;
            }
        }
    }
    /// <summary>
    /// Checks if a user is an admin of a specific project.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="projectId">The ID of the project.</param>
    /// <returns>True if the user is an admin of the project, false otherwise.</returns>
    public bool IsAdminOfThisProject(string userId, string projectId)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "select role from user_roles where user_id = @userId and project_id = @projectId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@projectId", projectId);
            connection.Open();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                return result.ToString() == "Admin";
            }
            else
            {
                return false;
            }
        }
    }
    /// <summary>
    /// Retrieves the admin of a project from the database.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <returns>The username of the admin.</returns>
    public string AdminOfProject(string projectId)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "select user_id from user_roles where project_id = @projectId and role = 'Admin'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@projectId", projectId);
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
    /// <summary>
    /// Retrieves the projects that a user is the admin of.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A list of project names.</returns>
    public List<string> GetUserAdminProjects(string userId)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                if (IsSuperAdmin(userId))
                {
                    return LoadProjects();
                }

                string sql = @"SELECT p.project_name 
                               FROM user_roles ur 
                               JOIN projects p ON ur.project_id = p.project_id 
                               WHERE ur.user_id = @userId AND ur.role = 'Admin'";

                List<string> projectNames = new List<string>();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string projectName = reader["project_name"].ToString();
                            projectNames.Add(projectName);
                        }
                    }
                }

                return projectNames;
            }
        }
        catch (MySqlException ex)
        {
            // Handle any errors that occur during the database operations
            Console.WriteLine("An error occurred while getting user admin projects: " + ex.Message);
            return new List<string>();
        }
    }
    /// <summary>
    /// Retrieves the username of a user from the database.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>The username of the user.</returns>
    public string GetUserName(string userId)
    {
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            string query = "select user_name from users where user_id = @userId";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@userId", userId);
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
    /// <summary>
    /// Lists all users that belong to a project.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <returns>A list of user names.</returns>
    public List<string> ListUsersBelongToProject(string projectId)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"SELECT u.user_name 
                               FROM user_roles ur 
                               JOIN users u ON ur.user_id = u.user_id 
                               WHERE ur.project_id = @projectId AND ur.role != 'Admin'";

                List<string> userNames = new List<string>();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userName = reader["user_name"].ToString();
                            userNames.Add(userName);
                        }
                    }
                }

                return userNames;
            }
        }
        catch (MySqlException ex)
        {
            // Handle any errors that occur during the database operations
            Console.WriteLine("An error occurred while getting users of this project: " + ex.Message);
            return new List<string>();
        }
    }
    /// <summary>
    /// Lists all users that don't belong to a project.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <returns>A list of user names.</returns>
    //select user_id from user_roles with projectId, then select user_name from users where user_id in (user_id from users where user_id not in (user_id from user_roles))
    public List<string> ListUsersDontBeloneToProject(string projectId)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"SELECT user_name 
                               FROM users 
                               WHERE user_id NOT IN (SELECT user_id FROM user_roles WHERE project_id = @projectId) 
                               AND user_name != 'admin'";

                List<string> userNames = new List<string>();
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string userName = reader["user_name"].ToString();
                            userNames.Add(userName);
                        }
                    }
                }

                return userNames;
            }
        }
        catch (MySqlException ex)
        {
            // Handle any errors that occur during the database operations
            Console.WriteLine("An error occurred while getting users of this project: " + ex.Message);
            return new List<string>();
        }
    }
    /// <summary>
    /// Updates the roles of a user for a project.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="projectId">The ID of the project.</param>
    /// <param name="role">The role to update.</param>
    /// <param name="isAdd">True if adding the role, false if removing the role.</param>
    /// <returns>True if the update is successful, false otherwise.</returns>
    public bool UpdateUserRoles(string userId, string projectId, string role, bool isAdd)
    {
        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "";
                if (isAdd)
                {
                    sql = "INSERT INTO user_roles (user_id, project_id, role, create_time) VALUES (@userId, @projectId, @role, @create_time)";
                }
                else
                {
                    sql = "DELETE FROM user_roles WHERE user_id = @userId AND project_id = @projectId AND role = @role";
                }
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@role", role);

                    if (isAdd)
                    {
                        command.Parameters.AddWithValue("@create_time", DateTime.Now);
                    }

                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows > 0;
                }
            }
        }
        catch (MySqlException ex)
        {
            // Handle any errors that occur during the database operations
            Console.WriteLine("An error occurred while updating user roles: " + ex.Message);
            return false;
        }
    }
    /// <summary>
    /// Inserts a new comment into the database.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="commentContent">The content of the comment.</param>
    /// <param name="projectId">The ID of the project associated with the comment.</param>-->-->
    /// <param name="requirementIds">A list of requirement IDs associated with the comment.</param>
    public void InsertComment(string userId, string commentContent, List<string> projectIds, List<string> requirementIds = null)
    {
        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "START TRANSACTION;";
            cmd.ExecuteNonQuery();

            try
            {
                // Insert the comment
                cmd.CommandText = @"INSERT INTO comments (user_id, comment_content, comment_created_at)
                            VALUES (@userId, @commentContent, CURRENT_TIMESTAMP);";
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@commentContent", commentContent);
                cmd.ExecuteNonQuery();

                // Get the ID of the inserted comment
                cmd.CommandText = "SELECT LAST_INSERT_ID();";
                int commentId = Convert.ToInt32(cmd.ExecuteScalar());

                // Define the '@commentId' parameter
                cmd.Parameters.AddWithValue("@commentId", commentId);

                // Link the comment to the projects
                cmd.CommandText = "INSERT INTO comment_projects (comment_id, project_id) VALUES (@commentId, @projectId);";
                cmd.Prepare();
                cmd.Parameters.Add("@projectId", MySqlDbType.Int32);
                foreach (string projectId in projectIds)
                {
                    cmd.Parameters["@projectId"].Value = projectId;
                    cmd.ExecuteNonQuery();
                }

                // Link the comment to the requirements, if any
                if (requirementIds != null)
                {
                    cmd.CommandText = "INSERT INTO comment_requirements (comment_id, requirement_id) VALUES (@commentId, @requirementId);";
                    cmd.Prepare();
                    cmd.Parameters.Add("@requirementId", MySqlDbType.Int32);
                    foreach (string requirementId in requirementIds)
                    {
                        cmd.Parameters["@requirementId"].Value = requirementId;
                        cmd.ExecuteNonQuery();
                    }
                }

                cmd.CommandText = "COMMIT;";
                cmd.ExecuteNonQuery();
            }
            catch
            {
                cmd.CommandText = "ROLLBACK;";
                cmd.ExecuteNonQuery();
                throw;
            }
        }
    }
    /// <summary>
    /// Lists all comments that a user can see from the database.
    /// </summary>
    /// <param name="userId">The ID of the user.</param>
    /// <returns>A list of comments.</returns>
    public List<string> ListAllCommentsYouCanSee(string userId)
    {
        List<string> comments = new List<string>();
        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            // List all the comments that the user can see
            string sql = @"SELECT COALESCE(p1.project_name, p2.project_name) AS project_name, 
                                  r.requirement_name, 
                                  u.user_name, 
                                  c.comment_content, 
                                  c.comment_created_at 
                           FROM comments c 
                           INNER JOIN users u ON c.user_id = u.user_id 
                           LEFT JOIN comment_requirements cr ON c.comment_id = cr.comment_id 
                           LEFT JOIN requirements r ON cr.requirement_id = r.requirement_id 
                           LEFT JOIN projects p1 ON r.project_id = p1.project_id
                           LEFT JOIN comment_projects cp ON c.comment_id = cp.comment_id
                           LEFT JOIN projects p2 ON cp.project_id = p2.project_id
                           WHERE EXISTS (SELECT 1 FROM user_roles ur WHERE ur.user_id = @userId AND (ur.role = 'SuperAdmin' OR ur.project_id = p1.project_id OR ur.project_id = p2.project_id))
                           ORDER BY c.comment_created_at DESC;";
            using (MySqlCommand command = new MySqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string comment = $"{reader["user_name"]}, {reader["project_name"] ?? "N/A"}, {reader["requirement_name"] ?? "N/A"}, {reader["comment_content"]}, {reader["comment_created_at"]}";
                        comments.Add(comment);
                    }
                }
            }
        }
        return comments;
    }
    public List<string> ListCommentsByRequirementId(string requirementId)
    {
        try
        {
            List<string> comments = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = @"SELECT c.comment_id,
                                  p.project_name, 
                                  r.requirement_name, 
                                  u.user_name, 
                                  c.comment_content, 
                                  c.comment_created_at,
                                  GROUP_CONCAT(DISTINCT CONCAT(p2.project_name, ':', r2.requirement_name) SEPARATOR ', ') AS link_requirements
                            FROM comments c 
                            INNER JOIN users u ON c.user_id = u.user_id 
                            INNER JOIN comment_requirements cr ON c.comment_id = cr.comment_id 
                            INNER JOIN requirements r ON cr.requirement_id = r.requirement_id 
                            LEFT JOIN projects p ON r.project_id = p.project_id
                            LEFT JOIN comment_requirements cr2 ON c.comment_id = cr2.comment_id
                            LEFT JOIN requirements r2 ON cr2.requirement_id = r2.requirement_id AND r2.requirement_id != @requirementId
                            LEFT JOIN projects p2 ON r2.project_id = p2.project_id
                            WHERE cr.requirement_id = @requirementId
                            GROUP BY c.comment_id, p.project_name, r.requirement_name, u.user_name, c.comment_content, c.comment_created_at
                            ORDER BY c.comment_created_at DESC;";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@requirementId", requirementId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string comment = $"{reader["user_name"]}, {reader["project_name"] ?? "N/A"}, {reader["requirement_name"] ?? "N/A"}, {reader["comment_content"]}, {reader["link_requirements"] ?? "N/A"}, {reader["comment_created_at"]}";
                            comments.Add(comment);
                        }
                    }
                }

            }
            return comments;
        }
        catch (MySqlException ex)
        {
            // Handle any errors that occur during the database operations
            Console.WriteLine("An error occurred while listing comments by requirement ID: " + ex.Message);
            return new List<string>();
        }
    }

}



