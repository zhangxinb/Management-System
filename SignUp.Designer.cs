namespace Management_System
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.sign_up = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.phone_num = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbRe_Password = new System.Windows.Forms.TextBox();
            this.btCancle = new System.Windows.Forms.Button();
            this.btSubmit = new System.Windows.Forms.Button();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.re_password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sign_up
            // 
            this.sign_up.AutoSize = true;
            this.sign_up.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign_up.Location = new System.Drawing.Point(424, 127);
            this.sign_up.Name = "sign_up";
            this.sign_up.Size = new System.Drawing.Size(165, 57);
            this.sign_up.TabIndex = 1;
            this.sign_up.Text = "Sign Up";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(366, 233);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(59, 12);
            this.user_name.TabIndex = 2;
            this.user_name.Text = "User Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(366, 274);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 12);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            // 
            // phone_num
            // 
            this.phone_num.AutoSize = true;
            this.phone_num.Location = new System.Drawing.Point(366, 365);
            this.phone_num.Name = "phone_num";
            this.phone_num.Size = new System.Drawing.Size(77, 12);
            this.phone_num.TabIndex = 4;
            this.phone_num.Text = "Phone Number";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(564, 233);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 21);
            this.tbUserName.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(564, 274);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 21);
            this.tbPassword.TabIndex = 6;
            // 
            // tbRe_Password
            // 
            this.tbRe_Password.Location = new System.Drawing.Point(564, 314);
            this.tbRe_Password.Name = "tbRe_Password";
            this.tbRe_Password.PasswordChar = '*';
            this.tbRe_Password.Size = new System.Drawing.Size(100, 21);
            this.tbRe_Password.TabIndex = 7;
            // 
            // btCancle
            // 
            this.btCancle.Location = new System.Drawing.Point(410, 413);
            this.btCancle.Name = "btCancle";
            this.btCancle.Size = new System.Drawing.Size(75, 23);
            this.btCancle.TabIndex = 9;
            this.btCancle.Text = "Cancle";
            this.btCancle.UseVisualStyleBackColor = true;
            this.btCancle.Click += new System.EventHandler(this.btCancle_Click);
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(532, 412);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 10;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(564, 365);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(100, 21);
            this.tbPhoneNum.TabIndex = 8;
            // 
            // re_password
            // 
            this.re_password.AutoSize = true;
            this.re_password.Location = new System.Drawing.Point(366, 323);
            this.re_password.Name = "re_password";
            this.re_password.Size = new System.Drawing.Size(71, 12);
            this.re_password.TabIndex = 11;
            this.re_password.Text = "Re-Password";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1020, 651);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.re_password);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.btCancle);
            this.Controls.Add(this.tbRe_Password);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.phone_num);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.sign_up);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sign_up;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label phone_num;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbRe_Password;
        private System.Windows.Forms.Button btCancle;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label re_password;
    }
}