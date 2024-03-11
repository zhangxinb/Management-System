
﻿using System.Windows.Forms;


namespace Management_System
{
    internal class Program
    {

        public static string user_name;
        static void Main()
        {
            /*
            IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
            DatabaseSerializerClient client = new DatabaseSerializerClient(dbOperations);
            client.SerializeDatabaseToFile("D:\\DatabaseSnapshot.json", "1.0");
            */
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //you can change the form when you want to test the program, for example: Application.Run(new Login()); this will run the login form

        }
    }
}
