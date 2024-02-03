﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                string query = "select requirement_name from requirements where project_id = @project_id and IsDeleted = 0";
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
        public void UpdateRequirement(string projectName, string requirementID, string requirementName, string requirementDescription, string requirementStatus)
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

                string updateQuery = "update requirements set requirement_description = @requirement_description, requirement_status = @requirement_status, requirement_version = @requirement_version, requirement_updated_at = @requirement_updated_at where project_id = @project_id and requirement_name = @requirement_name";
                MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                updateCmd.Parameters.AddWithValue("@project_id", projectID);
                updateCmd.Parameters.AddWithValue("@requirement_name", requirementName);
                updateCmd.Parameters.AddWithValue("@requirement_description", requirementDescription);
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
                string query = "update requirements set IsDeleted = true, requirement_updated_at = @requirement_updated_at where requirement_id = @requirement_id and requirement_name = @requirement_name";
                MySqlCommand updateCmd = new MySqlCommand(query, connection);
                updateCmd.Parameters.AddWithValue("@requirement_id", requirementId);
                updateCmd.Parameters.AddWithValue("@requirement_name", requirementName);
                updateCmd.Parameters.AddWithValue("@requirement_updated_at", DateTime.Now);
                connection.Open();
                updateCmd.ExecuteNonQuery();
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
        public class Dependency
        {
            public int ID { get; set; }
            public string Description { get; set; }
        }
        public List<Dependency> LoadDependencies(string requirementName)
        {
            List<Dependency> dependencies = new List<Dependency>();
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
                    query = "select dependency_id, dependency_description from requirement_dependencies where requirement_id = @requirement_id";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@requirement_id", id);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Dependency dependency = new Dependency
                        {
                            ID = reader.GetInt32(0),
                            Description = reader.GetString(1)
                        };
                        dependencies.Add(dependency);
                    }
                }
                reader.Close();
            }
            return dependencies;
        }
        public void InsertDependency(string requirementName, string dependencyDescription)
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
                    int id = reader.GetInt32(0);
                    reader.Close();
                    query = "insert into requirement_dependencies(requirement_id, dependency_description) values (@requirement_id, @dependency_description)";
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@requirement_id", id);
                    cmd.Parameters.AddWithValue("@dependency_description", dependencyDescription);
                    cmd.ExecuteNonQuery();
                }
                reader.Close();
            }
        }
        public void UpdateDependency(int dependencyId, string dependencyDescription)
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
        }
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

    }

}

