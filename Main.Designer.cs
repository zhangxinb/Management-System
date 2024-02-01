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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Requirement", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Comment", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28});
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Report", new System.Windows.Forms.TreeNode[] {
            treeNode30,
            treeNode31});
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
            this.cbProjectDeleteSelectProject = new System.Windows.Forms.ComboBox();
            this.lbProjectDelete = new System.Windows.Forms.Label();
            this.btProjectDeleteDelete = new System.Windows.Forms.Button();
            this.panel_project_add.SuspendLayout();
            this.panel_project_edit.SuspendLayout();
            this.panel_project_delete.SuspendLayout();
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
            treeNode17.Name = "ndUser";
            treeNode17.Text = "User";
            treeNode18.Name = "ndProjectAdd";
            treeNode18.Text = "Add";
            treeNode19.Name = "ndProjectEdit";
            treeNode19.Text = "Edit";
            treeNode20.Name = "ndProjectDelete";
            treeNode20.Text = "Delete";
            treeNode21.Name = "ndProject";
            treeNode21.Text = "Project";
            treeNode22.Name = "ndRequirementAdd";
            treeNode22.Text = "Add";
            treeNode23.Name = "ndRequirementEdit";
            treeNode23.Text = "Edit";
            treeNode24.Name = "ndRequirementDelete";
            treeNode24.Text = "Delete";
            treeNode25.Name = "Requirement";
            treeNode25.Text = "Requirement";
            treeNode26.Name = "ndCommentAdd";
            treeNode26.Text = "Add";
            treeNode27.Name = "ndCommentEdit";
            treeNode27.Text = "Edit";
            treeNode28.Name = "ndCommentDelete";
            treeNode28.Text = "Delete";
            treeNode29.Name = "Comment";
            treeNode29.Text = "Comment";
            treeNode30.Name = "节点10";
            treeNode30.Text = "节点10";
            treeNode31.Name = "节点11";
            treeNode31.Text = "节点11";
            treeNode32.Name = "Report";
            treeNode32.Text = "Report";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode21,
            treeNode25,
            treeNode29,
            treeNode32});
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
            this.btProjectAddSubmit.Location = new System.Drawing.Point(335, 366);
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
            // cbProjectDeleteSelectProject
            // 
            this.cbProjectDeleteSelectProject.FormattingEnabled = true;
            this.cbProjectDeleteSelectProject.Location = new System.Drawing.Point(427, 143);
            this.cbProjectDeleteSelectProject.Name = "cbProjectDeleteSelectProject";
            this.cbProjectDeleteSelectProject.Size = new System.Drawing.Size(121, 20);
            this.cbProjectDeleteSelectProject.TabIndex = 9;
            // 
            // lbProjectDelete
            // 
            this.lbProjectDelete.AutoSize = true;
            this.lbProjectDelete.Location = new System.Drawing.Point(229, 143);
            this.lbProjectDelete.Name = "lbProjectDelete";
            this.lbProjectDelete.Size = new System.Drawing.Size(89, 12);
            this.lbProjectDelete.TabIndex = 10;
            this.lbProjectDelete.Text = "Select Project";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
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
    }
}