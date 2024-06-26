using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoIt;
//using AutoItX3Lib;
using Microsoft.SqlServer.Server;

/*
 * This is an automation test for the sign-up function. 
 * * The test simulates: 
 * * first, the username already exists; 
 * * second, the password re-entry is incorrect; 
 * * third, the user successfully signs up.
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
        static void Main_1(string[] args)
        {
            Console.WriteLine("This is an automation test for the sign-up function. ");
            Console.WriteLine("The test simulates: ");
            Console.Write("first, the username already exists; ");
            Console.Write("second, the password re-entry is incorrect; ");
            Console.Write("third, the user successfully signs up.\n");
            Console.Write("Username for test: ");
            string username = Console.ReadLine();
            Console.WriteLine("Automation Test Started.");


            string wrongUsername = "admin";
            string password = "123456";
            string repassword = "123456";
            string phoneNumber = "1234567890";
            string wrongRepassword = "123457";

            // file path, use\\ instead of \
            string filePath = "C:\\…………\\Management System.exe";

            LaunchApplication(filePath);

            //Username already exists
            TestInsertUserFunction(wrongUsername, password, repassword, phoneNumber);
            //Password and RePassword are not the same
            TestInsertUserFunction(username, password, wrongRepassword, phoneNumber);
            //Insert successfully
            TestInsertUserFunction(username, password, repassword, phoneNumber);

            CloseApplication();

            Console.WriteLine("Automation Test Finished.");
        }

        static void LaunchApplication(string filePath)
        {
            AutoItX.Run(filePath, "", AutoItX.SW_SHOW);
            AutoItX.WinWaitActive("Management System");
            AutoItX.Sleep(2000);  
        }

        static void TestInsertUserFunction(string username, string password, string repassword, string phoneNumber)
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
        
        static void CloseApplication()
        {
            AutoItX.WinClose("Management System");
        }
    }
}
