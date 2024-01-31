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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("User");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Requirement", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Comment", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("节点10");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("节点11");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Report", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
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
            this.panel_project_add.SuspendLayout();
            this.panel_project_edit.SuspendLayout();
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
            treeNode1.Name = "ndUser";
            treeNode1.Text = "User";
            treeNode2.Name = "ndProjectAdd";
            treeNode2.Text = "Add";
            treeNode3.Name = "ndProjectEdit";
            treeNode3.Text = "Edit";
            treeNode4.Name = "ndProjectDelete";
            treeNode4.Text = "Delete";
            treeNode5.Name = "ndProject";
            treeNode5.Text = "Project";
            treeNode6.Name = "ndRequirementAdd";
            treeNode6.Text = "Add";
            treeNode7.Name = "ndRequirementEdit";
            treeNode7.Text = "Edit";
            treeNode8.Name = "ndRequirementDelete";
            treeNode8.Text = "Delete";
            treeNode9.Name = "Requirement";
            treeNode9.Text = "Requirement";
            treeNode10.Name = "ndCommentAdd";
            treeNode10.Text = "Add";
            treeNode11.Name = "ndCommentEdit";
            treeNode11.Text = "Edit";
            treeNode12.Name = "ndCommentDelete";
            treeNode12.Text = "Delete";
            treeNode13.Name = "Comment";
            treeNode13.Text = "Comment";
            treeNode14.Name = "节点10";
            treeNode14.Text = "节点10";
            treeNode15.Name = "节点11";
            treeNode15.Text = "节点11";
            treeNode16.Name = "Report";
            treeNode16.Text = "Report";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode5,
            treeNode9,
            treeNode13,
            treeNode16});
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.panel_project_edit);
            this.Controls.Add(this.panel_project_add);
            this.Controls.Add(this.treeView1);
            this.Name = "Main";
            this.Text = "Main page";
            this.panel_project_add.ResumeLayout(false);
            this.panel_project_add.PerformLayout();
            this.panel_project_edit.ResumeLayout(false);
            this.panel_project_edit.PerformLayout();
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
    }
}