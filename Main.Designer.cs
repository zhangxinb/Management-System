namespace Management_System
{
    partial class Main
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
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode34,
            treeNode35,
            treeNode36});
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Requirement", new System.Windows.Forms.TreeNode[] {
            treeNode38,
            treeNode39,
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Comment", new System.Windows.Forms.TreeNode[] {
            treeNode42,
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Report", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47});
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel_project_add = new System.Windows.Forms.Panel();
            this.tbProjectAddDescription = new System.Windows.Forms.TextBox();
            this.lbProjectAddDescription = new System.Windows.Forms.Label();
            this.tbProjectAddName = new System.Windows.Forms.TextBox();
            this.lbProjectAddName = new System.Windows.Forms.Label();
            this.btProjectAddSubmit = new System.Windows.Forms.Button();
            this.panel_project_edit = new System.Windows.Forms.Panel();
            this.btProjectEditSubmit = new System.Windows.Forms.Button();
            this.tbProjectEditDescription = new System.Windows.Forms.TextBox();
            this.cbProjectSelect = new System.Windows.Forms.ComboBox();
            this.lbProjectUpdataDescription = new System.Windows.Forms.Label();
            this.lbProjectSelectProject = new System.Windows.Forms.Label();
            this.panel_project_delete = new System.Windows.Forms.Panel();
            this.btProjectDeleteDelete = new System.Windows.Forms.Button();
            this.lbProjectDelete = new System.Windows.Forms.Label();
            this.cbProjectDeleteSelectProject = new System.Windows.Forms.ComboBox();
            this.panel_requirement_add = new System.Windows.Forms.Panel();
            this.cbRequirementAddProject = new System.Windows.Forms.ComboBox();
            this.lbRequirementProject = new System.Windows.Forms.Label();
            this.btRequirementAddSubmit = new System.Windows.Forms.Button();
            this.tbRequirementAddVersion = new System.Windows.Forms.TextBox();
            this.cbRequirementAddStatus = new System.Windows.Forms.ComboBox();
            this.tbRequirementAddDescription = new System.Windows.Forms.TextBox();
            this.tbRequirementAddName = new System.Windows.Forms.TextBox();
            this.lbRequirementVersion = new System.Windows.Forms.Label();
            this.lbRequirementStatus = new System.Windows.Forms.Label();
            this.lbReuirementDescription = new System.Windows.Forms.Label();
            this.lbRequirementRequirementName = new System.Windows.Forms.Label();
            this.panel_project_add.SuspendLayout();
            this.panel_project_edit.SuspendLayout();
            this.panel_project_delete.SuspendLayout();
            this.panel_requirement_add.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode33.Name = "ndUser";
            treeNode33.Text = "User";
            treeNode34.Name = "ndProjectAdd";
            treeNode34.Text = "Add";
            treeNode35.Name = "ndProjectEdit";
            treeNode35.Text = "Edit";
            treeNode36.Name = "ndProjectDelete";
            treeNode36.Text = "Delete";
            treeNode37.Name = "ndProject";
            treeNode37.Text = "Project";
            treeNode38.Name = "ndRequirementAdd";
            treeNode38.Text = "Add";
            treeNode39.Name = "ndRequirementEdit";
            treeNode39.Text = "Edit";
            treeNode40.Name = "ndRequirementDelete";
            treeNode40.Text = "Delete";
            treeNode41.Name = "Requirement";
            treeNode41.Text = "Requirement";
            treeNode42.Name = "ndCommentAdd";
            treeNode42.Text = "Add";
            treeNode43.Name = "ndCommentEdit";
            treeNode43.Text = "Edit";
            treeNode44.Name = "ndCommentDelete";
            treeNode44.Text = "Delete";
            treeNode45.Name = "Comment";
            treeNode45.Text = "Comment";
            treeNode46.Name = "节点10";
            treeNode46.Text = "节点10";
            treeNode47.Name = "节点11";
            treeNode47.Text = "节点11";
            treeNode48.Name = "Report";
            treeNode48.Text = "Report";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode37,
            treeNode41,
            treeNode45,
            treeNode48});
            this.treeView1.Size = new System.Drawing.Size(116, 477);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel_project_add
            // 
            this.panel_project_add.Controls.Add(this.tbProjectAddDescription);
            this.panel_project_add.Controls.Add(this.lbProjectAddDescription);
            this.panel_project_add.Controls.Add(this.tbProjectAddName);
            this.panel_project_add.Controls.Add(this.lbProjectAddName);
            this.panel_project_add.Controls.Add(this.btProjectAddSubmit);
            this.panel_project_add.Location = new System.Drawing.Point(122, 0);
            this.panel_project_add.Name = "panel_project_add";
            this.panel_project_add.Size = new System.Drawing.Size(793, 477);
            this.panel_project_add.TabIndex = 3;
            this.panel_project_add.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_project_add_Paint);
            // 
            // tbProjectAddDescription
            // 
            this.tbProjectAddDescription.Location = new System.Drawing.Point(436, 228);
            this.tbProjectAddDescription.Name = "tbProjectAddDescription";
            this.tbProjectAddDescription.Size = new System.Drawing.Size(100, 21);
            this.tbProjectAddDescription.TabIndex = 5;
            // 
            // lbProjectAddDescription
            // 
            this.lbProjectAddDescription.AutoSize = true;
            this.lbProjectAddDescription.Location = new System.Drawing.Point(247, 231);
            this.lbProjectAddDescription.Name = "lbProjectAddDescription";
            this.lbProjectAddDescription.Size = new System.Drawing.Size(71, 12);
            this.lbProjectAddDescription.TabIndex = 4;
            this.lbProjectAddDescription.Text = "Description";
            // 
            // tbProjectAddName
            // 
            this.tbProjectAddName.Location = new System.Drawing.Point(436, 134);
            this.tbProjectAddName.Name = "tbProjectAddName";
            this.tbProjectAddName.Size = new System.Drawing.Size(100, 21);
            this.tbProjectAddName.TabIndex = 3;
            // 
            // lbProjectAddName
            // 
            this.lbProjectAddName.AutoSize = true;
            this.lbProjectAddName.Location = new System.Drawing.Point(247, 137);
            this.lbProjectAddName.Name = "lbProjectAddName";
            this.lbProjectAddName.Size = new System.Drawing.Size(29, 12);
            this.lbProjectAddName.TabIndex = 2;
            this.lbProjectAddName.Text = "Name";
            // 
            // btProjectAddSubmit
            // 
            this.btProjectAddSubmit.Location = new System.Drawing.Point(335, 322);
            this.btProjectAddSubmit.Name = "btProjectAddSubmit";
            this.btProjectAddSubmit.Size = new System.Drawing.Size(75, 23);
            this.btProjectAddSubmit.TabIndex = 1;
            this.btProjectAddSubmit.Text = "Submit";
            this.btProjectAddSubmit.UseVisualStyleBackColor = true;
            this.btProjectAddSubmit.Click += new System.EventHandler(this.btProjectAddSubmit_Click);
            // 
            // panel_project_edit
            // 
            this.panel_project_edit.Controls.Add(this.btProjectEditSubmit);
            this.panel_project_edit.Controls.Add(this.tbProjectEditDescription);
            this.panel_project_edit.Controls.Add(this.cbProjectSelect);
            this.panel_project_edit.Controls.Add(this.lbProjectUpdataDescription);
            this.panel_project_edit.Controls.Add(this.lbProjectSelectProject);
            this.panel_project_edit.Location = new System.Drawing.Point(122, 0);
            this.panel_project_edit.Name = "panel_project_edit";
            this.panel_project_edit.Size = new System.Drawing.Size(793, 477);
            this.panel_project_edit.TabIndex = 4;
            // 
            // btProjectEditSubmit
            // 
            this.btProjectEditSubmit.Location = new System.Drawing.Point(335, 322);
            this.btProjectEditSubmit.Name = "btProjectEditSubmit";
            this.btProjectEditSubmit.Size = new System.Drawing.Size(75, 23);
            this.btProjectEditSubmit.TabIndex = 11;
            this.btProjectEditSubmit.Text = "Submit";
            this.btProjectEditSubmit.UseVisualStyleBackColor = true;
            this.btProjectEditSubmit.Click += new System.EventHandler(this.btProjectEditSubmit_Click);
            // 
            // tbProjectEditDescription
            // 
            this.tbProjectEditDescription.Location = new System.Drawing.Point(427, 210);
            this.tbProjectEditDescription.Name = "tbProjectEditDescription";
            this.tbProjectEditDescription.Size = new System.Drawing.Size(100, 21);
            this.tbProjectEditDescription.TabIndex = 9;
            // 
            // cbProjectSelect
            // 
            this.cbProjectSelect.FormattingEnabled = true;
            this.cbProjectSelect.Location = new System.Drawing.Point(427, 136);
            this.cbProjectSelect.Name = "cbProjectSelect";
            this.cbProjectSelect.Size = new System.Drawing.Size(121, 20);
            this.cbProjectSelect.TabIndex = 8;
            // 
            // lbProjectUpdataDescription
            // 
            this.lbProjectUpdataDescription.AutoSize = true;
            this.lbProjectUpdataDescription.Location = new System.Drawing.Point(247, 210);
            this.lbProjectUpdataDescription.Name = "lbProjectUpdataDescription";
            this.lbProjectUpdataDescription.Size = new System.Drawing.Size(113, 12);
            this.lbProjectUpdataDescription.TabIndex = 7;
            this.lbProjectUpdataDescription.Text = "Update Description";
            // 
            // lbProjectSelectProject
            // 
            this.lbProjectSelectProject.AutoSize = true;
            this.lbProjectSelectProject.Location = new System.Drawing.Point(245, 136);
            this.lbProjectSelectProject.Name = "lbProjectSelectProject";
            this.lbProjectSelectProject.Size = new System.Drawing.Size(89, 12);
            this.lbProjectSelectProject.TabIndex = 6;
            this.lbProjectSelectProject.Text = "Select Project";
            // 
            // panel_project_delete
            // 
            this.panel_project_delete.Controls.Add(this.btProjectDeleteDelete);
            this.panel_project_delete.Controls.Add(this.lbProjectDelete);
            this.panel_project_delete.Controls.Add(this.cbProjectDeleteSelectProject);
            this.panel_project_delete.Location = new System.Drawing.Point(122, 0);
            this.panel_project_delete.Name = "panel_project_delete";
            this.panel_project_delete.Size = new System.Drawing.Size(793, 477);
            this.panel_project_delete.TabIndex = 5;
            // 
            // btProjectDeleteDelete
            // 
            this.btProjectDeleteDelete.Location = new System.Drawing.Point(335, 322);
            this.btProjectDeleteDelete.Name = "btProjectDeleteDelete";
            this.btProjectDeleteDelete.Size = new System.Drawing.Size(75, 23);
            this.btProjectDeleteDelete.TabIndex = 11;
            this.btProjectDeleteDelete.Text = "Delete";
            this.btProjectDeleteDelete.UseVisualStyleBackColor = true;
            this.btProjectDeleteDelete.Click += new System.EventHandler(this.btProjectDeleteDelete_Click);
            // 
            // lbProjectDelete
            // 
            this.lbProjectDelete.AutoSize = true;
            this.lbProjectDelete.Location = new System.Drawing.Point(245, 136);
            this.lbProjectDelete.Name = "lbProjectDelete";
            this.lbProjectDelete.Size = new System.Drawing.Size(89, 12);
            this.lbProjectDelete.TabIndex = 10;
            this.lbProjectDelete.Text = "Select Project";
            // 
            // cbProjectDeleteSelectProject
            // 
            this.cbProjectDeleteSelectProject.FormattingEnabled = true;
            this.cbProjectDeleteSelectProject.Location = new System.Drawing.Point(427, 136);
            this.cbProjectDeleteSelectProject.Name = "cbProjectDeleteSelectProject";
            this.cbProjectDeleteSelectProject.Size = new System.Drawing.Size(121, 20);
            this.cbProjectDeleteSelectProject.TabIndex = 9;
            // 
            // panel_requirement_add
            // 
            this.panel_requirement_add.Controls.Add(this.cbRequirementAddProject);
            this.panel_requirement_add.Controls.Add(this.lbRequirementProject);
            this.panel_requirement_add.Controls.Add(this.btRequirementAddSubmit);
            this.panel_requirement_add.Controls.Add(this.tbRequirementAddVersion);
            this.panel_requirement_add.Controls.Add(this.cbRequirementAddStatus);
            this.panel_requirement_add.Controls.Add(this.tbRequirementAddDescription);
            this.panel_requirement_add.Controls.Add(this.tbRequirementAddName);
            this.panel_requirement_add.Controls.Add(this.lbRequirementVersion);
            this.panel_requirement_add.Controls.Add(this.lbRequirementStatus);
            this.panel_requirement_add.Controls.Add(this.lbReuirementDescription);
            this.panel_requirement_add.Controls.Add(this.lbRequirementRequirementName);
            this.panel_requirement_add.Location = new System.Drawing.Point(122, 0);
            this.panel_requirement_add.Name = "panel_requirement_add";
            this.panel_requirement_add.Size = new System.Drawing.Size(793, 477);
            this.panel_requirement_add.TabIndex = 6;
            // 
            // cbRequirementAddProject
            // 
            this.cbRequirementAddProject.FormattingEnabled = true;
            this.cbRequirementAddProject.Location = new System.Drawing.Point(443, 38);
            this.cbRequirementAddProject.Name = "cbRequirementAddProject";
            this.cbRequirementAddProject.Size = new System.Drawing.Size(121, 20);
            this.cbRequirementAddProject.TabIndex = 10;
            // 
            // lbRequirementProject
            // 
            this.lbRequirementProject.AutoSize = true;
            this.lbRequirementProject.Location = new System.Drawing.Point(205, 38);
            this.lbRequirementProject.Name = "lbRequirementProject";
            this.lbRequirementProject.Size = new System.Drawing.Size(47, 12);
            this.lbRequirementProject.TabIndex = 9;
            this.lbRequirementProject.Text = "Project";
            // 
            // btRequirementAddSubmit
            // 
            this.btRequirementAddSubmit.Location = new System.Drawing.Point(355, 415);
            this.btRequirementAddSubmit.Name = "btRequirementAddSubmit";
            this.btRequirementAddSubmit.Size = new System.Drawing.Size(75, 23);
            this.btRequirementAddSubmit.TabIndex = 8;
            this.btRequirementAddSubmit.Text = "Submit";
            this.btRequirementAddSubmit.UseVisualStyleBackColor = true;
            this.btRequirementAddSubmit.Click += new System.EventHandler(this.btRequirementAddSubmit_Click);
            // 
            // tbRequirementAddVersion
            // 
            this.tbRequirementAddVersion.Location = new System.Drawing.Point(443, 331);
            this.tbRequirementAddVersion.Name = "tbRequirementAddVersion";
            this.tbRequirementAddVersion.Size = new System.Drawing.Size(100, 21);
            this.tbRequirementAddVersion.TabIndex = 7;
            // 
            // cbRequirementAddStatus
            // 
            this.cbRequirementAddStatus.FormattingEnabled = true;
            this.cbRequirementAddStatus.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cbRequirementAddStatus.Location = new System.Drawing.Point(443, 260);
            this.cbRequirementAddStatus.Name = "cbRequirementAddStatus";
            this.cbRequirementAddStatus.Size = new System.Drawing.Size(121, 20);
            this.cbRequirementAddStatus.TabIndex = 6;
            // 
            // tbRequirementAddDescription
            // 
            this.tbRequirementAddDescription.Location = new System.Drawing.Point(443, 184);
            this.tbRequirementAddDescription.Name = "tbRequirementAddDescription";
            this.tbRequirementAddDescription.Size = new System.Drawing.Size(100, 21);
            this.tbRequirementAddDescription.TabIndex = 5;
            // 
            // tbRequirementAddName
            // 
            this.tbRequirementAddName.Location = new System.Drawing.Point(443, 107);
            this.tbRequirementAddName.Name = "tbRequirementAddName";
            this.tbRequirementAddName.Size = new System.Drawing.Size(100, 21);
            this.tbRequirementAddName.TabIndex = 4;
            // 
            // lbRequirementVersion
            // 
            this.lbRequirementVersion.AutoSize = true;
            this.lbRequirementVersion.Location = new System.Drawing.Point(205, 331);
            this.lbRequirementVersion.Name = "lbRequirementVersion";
            this.lbRequirementVersion.Size = new System.Drawing.Size(47, 12);
            this.lbRequirementVersion.TabIndex = 3;
            this.lbRequirementVersion.Text = "Version";
            // 
            // lbRequirementStatus
            // 
            this.lbRequirementStatus.AutoSize = true;
            this.lbRequirementStatus.Location = new System.Drawing.Point(205, 260);
            this.lbRequirementStatus.Name = "lbRequirementStatus";
            this.lbRequirementStatus.Size = new System.Drawing.Size(41, 12);
            this.lbRequirementStatus.TabIndex = 2;
            this.lbRequirementStatus.Text = "Status";
            // 
            // lbReuirementDescription
            // 
            this.lbReuirementDescription.AutoSize = true;
            this.lbReuirementDescription.Location = new System.Drawing.Point(205, 184);
            this.lbReuirementDescription.Name = "lbReuirementDescription";
            this.lbReuirementDescription.Size = new System.Drawing.Size(71, 12);
            this.lbReuirementDescription.TabIndex = 1;
            this.lbReuirementDescription.Text = "Description";
            // 
            // lbRequirementRequirementName
            // 
            this.lbRequirementRequirementName.AutoSize = true;
            this.lbRequirementRequirementName.Location = new System.Drawing.Point(205, 110);
            this.lbRequirementRequirementName.Name = "lbRequirementRequirementName";
            this.lbRequirementRequirementName.Size = new System.Drawing.Size(101, 12);
            this.lbRequirementRequirementName.TabIndex = 0;
            this.lbRequirementRequirementName.Text = "Requirement Name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.panel_requirement_add);
            this.Controls.Add(this.panel_project_delete);
            this.Controls.Add(this.panel_project_edit);
            this.Controls.Add(this.panel_project_add);
            this.Controls.Add(this.treeView1);
            this.Name = "Main";
            this.Text = "Main page";
            this.panel_project_add.ResumeLayout(false);
            this.panel_project_add.PerformLayout();
            this.panel_project_edit.ResumeLayout(false);
            this.panel_project_edit.PerformLayout();
            this.panel_project_delete.ResumeLayout(false);
            this.panel_project_delete.PerformLayout();
            this.panel_requirement_add.ResumeLayout(false);
            this.panel_requirement_add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel_project_add;
        private System.Windows.Forms.TextBox tbProjectAddName;
        private System.Windows.Forms.Label lbProjectAddName;
        private System.Windows.Forms.Button btProjectAddSubmit;
        private System.Windows.Forms.TextBox tbProjectAddDescription;
        private System.Windows.Forms.Label lbProjectAddDescription;
        private System.Windows.Forms.Panel panel_project_edit;
        private System.Windows.Forms.Button btProjectEditSubmit;
        private System.Windows.Forms.TextBox tbProjectEditDescription;
        private System.Windows.Forms.ComboBox cbProjectSelect;
        private System.Windows.Forms.Label lbProjectUpdataDescription;
        private System.Windows.Forms.Label lbProjectSelectProject;
        private System.Windows.Forms.Panel panel_project_delete;
        private System.Windows.Forms.Label lbProjectDelete;
        private System.Windows.Forms.ComboBox cbProjectDeleteSelectProject;
        private System.Windows.Forms.Button btProjectDeleteDelete;
        private System.Windows.Forms.Panel panel_requirement_add;
        private System.Windows.Forms.Label lbRequirementRequirementName;
        private System.Windows.Forms.TextBox tbRequirementAddVersion;
        private System.Windows.Forms.ComboBox cbRequirementAddStatus;
        private System.Windows.Forms.TextBox tbRequirementAddDescription;
        private System.Windows.Forms.TextBox tbRequirementAddName;
        private System.Windows.Forms.Label lbRequirementVersion;
        private System.Windows.Forms.Label lbRequirementStatus;
        private System.Windows.Forms.Label lbReuirementDescription;
        private System.Windows.Forms.Button btRequirementAddSubmit;
        private System.Windows.Forms.ComboBox cbRequirementAddProject;
        private System.Windows.Forms.Label lbRequirementProject;
    }
}