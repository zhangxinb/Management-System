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
        private string connectionString = "server=localhost;user id=root;database=requirements_management_system; port = 3306";

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
    }
}
