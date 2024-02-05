using System.Windows.Forms;

namespace Management_System
{
    internal class Program
    {
        public static string user_name;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //you can change the form when you want to test the program, for example: Application.Run(new Login()); this will run the login form
            Application.Run(new Login());
        }
    }
}
