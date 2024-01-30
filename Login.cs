﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;


namespace Management_System
{
    public partial class Login : Form
    {
        private IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)//load the form
        {

        }

        public string CreateMD5(string input)
        {
            /*This method is used to encrypt the password*/
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));//X2 means hexadecimal
                }
                return sb.ToString();
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string inputPassword = tbPassword.Text;
                string encryptedInputPassword = CreateMD5(inputPassword);//encrypt the password
                string storedPassword = dbOperations.GetUserPassword(tbUserName.Text);//get the password from database
                if (storedPassword != null && storedPassword == encryptedInputPassword)//compare the password
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    Main main = new Main();
                    main.Show();
                }

                else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//show exception message
            }

        }

        private void btSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }       
    }
}