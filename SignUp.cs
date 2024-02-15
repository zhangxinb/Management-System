using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Management_System
{
    public partial class SignUp : Form
    {
        private IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
        private Size originalFormSize;
        public SignUp()
        {
            InitializeComponent();
            originalFormSize = this.Size;
            FormResizer.SetInitialSize(this);
        }
        private void SignUp_Resize(object sender, EventArgs e)
        {
            FormResizer.ResizeForm(this, originalFormSize);
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        public string CreateMD5(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPassword.Text == tbRe_Password.Text)
                {
                    string inputPassword = tbPassword.Text;
                    string encryptedPassword = CreateMD5(inputPassword);
                    dbOperations.InsertUser(tbUserName.Text, encryptedPassword, tbPhoneNum.Text);
                    MessageBox.Show("Sign Up Successful");
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Password does not match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btCancle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
