using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
using AutoItX3Lib;
using Microsoft.SqlServer.Server;


/*
 * This is an automation test for the sign-up function. 
 * * The test simulates: 
 * * first, the username is empty;
 * * second, the username already exists; 
 * * third, the password re-entry is incorrect; 
 * * fourth, the user successfully signs up.
 * * 
 * 
 * 1.Downlaod AutoIt from https://www.autoitscript.com/site/
 * 2.Create a new project in Visual Studio and copypaste all the code.
 * 3.Get nuget package AutoItX.Dotnet.
 * 4.Add the AutoItX3.dll file to the project reference.
 * 5.Change the file path in the code to the path of the Management System.exe file.
 * */
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            // file path, use\\ instead of \
            //string filePath = "C:\\Users\\shangwei\\source\\repos\\Testforadd\\bin\\Debug\\Management System.exe";
            string filePath = "C:\\…………\\Management System.exe";


            //Sign-up function test 
            AutomationTester_SignUp automationTester = new AutomationTester_SignUp(filePath);
            automationTester.Run();

            //Log-in
            //AutomationTester_LogIn automationTester = new AutomationTester_LogIn(filePath);
            //automationTester.Run();




        }
    }

    public abstract class AutomationTesterBase
    {
        protected string filePath;

        public AutomationTesterBase(string filePath)
        {
            this.filePath = filePath;
        }

        protected void LaunchApplication()
        {
            AutoItX.Run(filePath, "", AutoItX.SW_SHOW);
            AutoItX.WinWaitActive("Management System");
            AutoItX.Sleep(2000);
        }

        protected void CloseApplication()
        {
            AutoItX.WinClose("Management System");
        }

        public abstract void Run();
    }

   
    public class AutomationTester_SignUp : AutomationTesterBase
    {
        public AutomationTester_SignUp(string filePath) : base(filePath) { }


        public override void Run()
        {

            Console.WriteLine("This is an automation test for the sign-up function. ");
            Console.WriteLine("The test simulates: ");
            Console.Write("first, the username is empty; ");
            Console.Write("second, the username already exists; ");
            Console.Write("third, the password re-entry is incorrect; ");
            Console.Write("fourth, the user successfully signs up.\n");
            Console.Write("Username for test: ");
            string username = Console.ReadLine();
            Console.WriteLine("Automation Test Started.");


            string wrongUsername = "admin";
            string password = "123456";
            string repassword = "123456";
            string phoneNumber = "1234567890";
            string wrongRepassword = "123457";

            LaunchApplication();

            //Username is empty
            TestInsertUserFunction("", password, repassword, phoneNumber);
            //Username already exists
            TestInsertUserFunction(wrongUsername, password, repassword, phoneNumber);
            //Password and RePassword are not the same
            TestInsertUserFunction(username, password, wrongRepassword, phoneNumber);
            //Insert successfully
            TestInsertUserFunction(username, password, repassword, phoneNumber);

            CloseApplication();

            Console.WriteLine("Automation Test Finished.");
        }




        public void TestInsertUserFunction(string username, string password, string repassword, string phoneNumber)
        {
            if (AutoItX.WinExists("Management System") == 1)
            {
                string buttonSignUp = "[CLASS:WindowsForms10.BUTTON.app.0.141b42a_r8_ad1; INSTANCE:1]";
                AutoItX.ControlClick("Management System", "", buttonSignUp);
            }

            AutoItX.WinWaitActive("Form1");

            string buttonUserName = "[CLASS:WindowsForms10.EDIT.app.0.141b42a_r8_ad1; INSTANCE:4]";
            string buttonPassword = "[CLASS:WindowsForms10.EDIT.app.0.141b42a_r8_ad1; INSTANCE:3]";
            string buttonRePassword = "[CLASS:WindowsForms10.EDIT.app.0.141b42a_r8_ad1; INSTANCE:2]";
            string buttonPhoneNumber = "[CLASS:WindowsForms10.EDIT.app.0.141b42a_r8_ad1; INSTANCE:1]";
            string buttonSubmit = "[CLASS:WindowsForms10.BUTTON.app.0.141b42a_r8_ad1; INSTANCE:1]";
            string buttonConfirm = "[CLASS:Button; INSTANCE:1]";

            AutoItX.ControlClick("Form1", "", buttonUserName);
            AutoItX.ControlSetText("Form1", "", buttonUserName, username);

            AutoItX.ControlClick("Form1", "", buttonPassword);
            AutoItX.ControlSetText("Form1", "", buttonPassword, password);

            AutoItX.ControlClick("Form1", "", buttonRePassword);
            AutoItX.ControlSetText("Form1", "", buttonRePassword, repassword);

            AutoItX.ControlClick("Form1", "", buttonPhoneNumber);
            AutoItX.ControlSetText("Form1", "", buttonPhoneNumber, phoneNumber);

            AutoItX.Sleep(5000);

            AutoItX.ControlClick("Form1", "", buttonSubmit);

            AutoItX.Sleep(5000);

            AutoItX.WinWait("[CLASS:#32770]");
            AutoItX.ControlClick("[CLASS:#32770]", "", buttonConfirm);
        }


    }

    public class AutomationTester_LogIn : AutomationTesterBase
    {
        public AutomationTester_LogIn(string filePath) : base(filePath) { }

        public override void Run()
        {
            Console.WriteLine("Automation Test Started.");
            LaunchApplication();
            LogIn();
            AutoItX.WinWaitActive("Main Page");
            AutoItX.Sleep(2000);

            //CloseApplication();
            //Console.WriteLine("Automation Test Finished.");
        }

        public void LogIn()
        {
            string userName = "[CLASS:WindowsForms10.EDIT.app.0.141b42a_r8_ad1; INSTANCE:2]";
            string password = "[CLASS:WindowsForms10.EDIT.app.0.141b42a_r8_ad1; INSTANCE:1]";
            string buttonLogIn = "[CLASS:WindowsForms10.BUTTON.app.0.141b42a_r8_ad1; INSTANCE:2]";
            string buttonConfirm = "[CLASS:Button; INSTANCE:1]";
            AutoItX.ControlClick("Management System", "", userName);
            AutoItX.ControlSetText("Management System", "", userName, "admin");
            AutoItX.ControlClick("Management System", "", password);
            AutoItX.ControlSetText("Management System", "", password, "admin");
            AutoItX.ControlClick("Management System", "", buttonLogIn);
            AutoItX.WinWait("[CLASS:#32770]");
            AutoItX.ControlClick("[CLASS:#32770]", "", buttonConfirm);

            AutoItX.Sleep(3000);
        }


    }


}
