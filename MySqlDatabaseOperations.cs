using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
