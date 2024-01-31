namespace Management_System
{
    partial class Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_project_name = new System.Windows.Forms.ComboBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.panel_Add = new System.Windows.Forms.Panel();
            this.btAddSubmit = new System.Windows.Forms.Button();
            this.btAddCancle = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panel_Edit = new System.Windows.Forms.Panel();
            this.btEditSubmit = new System.Windows.Forms.Button();
            this.btEditCancle = new System.Windows.Forms.Button();
            this.tbEditDescription = new System.Windows.Forms.TextBox();
            this.cb_Edit = new System.Windows.Forms.ComboBox();
            this.lbUpdataDescription = new System.Windows.Forms.Label();
            this.lbSelectProject = new System.Windows.Forms.Label();
            this.panel_Add.SuspendLayout();
            this.panel_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select";
            // 
            // cb_project_name
            // 
            this.cb_project_name.FormattingEnabled = true;
            this.cb_project_name.Location = new System.Drawing.Point(439, 167);
            this.cb_project_name.Name = "cb_project_name";
            this.cb_project_name.Size = new System.Drawing.Size(121, 20);
            this.cb_project_name.TabIndex = 1;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(349, 317);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(134, 317);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(567, 317);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // panel_Add
            // 
            this.panel_Add.Controls.Add(this.btAddSubmit);
            this.panel_Add.Controls.Add(this.btAddCancle);
            this.panel_Add.Controls.Add(this.tbDescription);
            this.panel_Add.Controls.Add(this.tbName);
            this.panel_Add.Controls.Add(this.lbDescription);
            this.panel_Add.Controls.Add(this.lbName);
            this.panel_Add.Location = new System.Drawing.Point(134, 56);
            this.panel_Add.Name = "panel_Add";
            this.panel_Add.Size = new System.Drawing.Size(508, 284);
            this.panel_Add.TabIndex = 5;
            // 
            // btAddSubmit
            // 
            this.btAddSubmit.Location = new System.Drawing.Point(287, 201);
            this.btAddSubmit.Name = "btAddSubmit";
            this.btAddSubmit.Size = new System.Drawing.Size(75, 23);
            this.btAddSubmit.TabIndex = 5;
            this.btAddSubmit.Text = "Submit";
            this.btAddSubmit.UseVisualStyleBackColor = true;
            this.btAddSubmit.Click += new System.EventHandler(this.btAddSubmit_Click);
            // 
            // btAddCancle
            // 
            this.btAddCancle.Location = new System.Drawing.Point(90, 201);
            this.btAddCancle.Name = "btAddCancle";
            this.btAddCancle.Size = new System.Drawing.Size(75, 23);
            this.btAddCancle.TabIndex = 4;
            this.btAddCancle.Text = "Cancle";
            this.btAddCancle.UseVisualStyleBackColor = true;
            this.btAddCancle.Click += new System.EventHandler(this.btAddCancle_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(287, 115);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(100, 21);
            this.tbDescription.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(287, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 21);
            this.tbName.TabIndex = 2;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(88, 118);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(71, 12);
            this.lbDescription.TabIndex = 1;
            this.lbDescription.Text = "Description";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(86, 41);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name";
            // 
            // panel_Edit
            // 
            this.panel_Edit.Controls.Add(this.btEditSubmit);
            this.panel_Edit.Controls.Add(this.btEditCancle);
            this.panel_Edit.Controls.Add(this.tbEditDescription);
            this.panel_Edit.Controls.Add(this.cb_Edit);
            this.panel_Edit.Controls.Add(this.lbUpdataDescription);
            this.panel_Edit.Controls.Add(this.lbSelectProject);
            this.panel_Edit.Location = new System.Drawing.Point(134, 56);
            this.panel_Edit.Name = "panel_Edit";
            this.panel_Edit.Size = new System.Drawing.Size(508, 284);
            this.panel_Edit.TabIndex = 6;
            // 
            // btEditSubmit
            // 
            this.btEditSubmit.Location = new System.Drawing.Point(305, 230);
            this.btEditSubmit.Name = "btEditSubmit";
            this.btEditSubmit.Size = new System.Drawing.Size(75, 23);
            this.btEditSubmit.TabIndex = 5;
            this.btEditSubmit.Text = "Submit";
            this.btEditSubmit.UseVisualStyleBackColor = true;
            this.btEditSubmit.Click += new System.EventHandler(this.btEditSubmit_Click);
            // 
            // btEditCancle
            // 
            this.btEditCancle.Location = new System.Drawing.Point(125, 231);
            this.btEditCancle.Name = "btEditCancle";
            this.btEditCancle.Size = new System.Drawing.Size(75, 23);
            this.btEditCancle.TabIndex = 4;
            this.btEditCancle.Text = "Cancle";
            this.btEditCancle.UseVisualStyleBackColor = true;
            // 
            // tbEditDescription
            // 
            this.tbEditDescription.Location = new System.Drawing.Point(305, 123);
            this.tbEditDescription.Name = "tbEditDescription";
            this.tbEditDescription.Size = new System.Drawing.Size(100, 21);
            this.tbEditDescription.TabIndex = 3;
            // 
            // cb_Edit
            // 
            this.cb_Edit.FormattingEnabled = true;
            this.cb_Edit.Location = new System.Drawing.Point(305, 49);
            this.cb_Edit.Name = "cb_Edit";
            this.cb_Edit.Size = new System.Drawing.Size(121, 20);
            this.cb_Edit.TabIndex = 2;
            // 
            // lbUpdataDescription
            // 
            this.lbUpdataDescription.AutoSize = true;
            this.lbUpdataDescription.Location = new System.Drawing.Point(125, 123);
            this.lbUpdataDescription.Name = "lbUpdataDescription";
            this.lbUpdataDescription.Size = new System.Drawing.Size(113, 12);
            this.lbUpdataDescription.TabIndex = 1;
            this.lbUpdataDescription.Text = "Update Description";
            // 
            // lbSelectProject
            // 
            this.lbSelectProject.AutoSize = true;
            this.lbSelectProject.Location = new System.Drawing.Point(123, 49);
            this.lbSelectProject.Name = "lbSelectProject";
            this.lbSelectProject.Size = new System.Drawing.Size(89, 12);
            this.lbSelectProject.TabIndex = 0;
            this.lbSelectProject.Text = "Select Project";
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Add);
            this.Controls.Add(this.panel_Edit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_project_name);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            this.panel_Add.ResumeLayout(false);
            this.panel_Add.PerformLayout();
            this.panel_Edit.ResumeLayout(false);
            this.panel_Edit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_project_name;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel_Add;
        private System.Windows.Forms.Button btAddSubmit;
        private System.Windows.Forms.Button btAddCancle;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel panel_Edit;
        private System.Windows.Forms.Button btEditSubmit;
        private System.Windows.Forms.Button btEditCancle;
        private System.Windows.Forms.TextBox tbEditDescription;
        private System.Windows.Forms.ComboBox cb_Edit;
        private System.Windows.Forms.Label lbUpdataDescription;
        private System.Windows.Forms.Label lbSelectProject;
    }
}