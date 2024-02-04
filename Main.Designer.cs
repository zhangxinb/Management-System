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
            this.btlogout = new System.Windows.Forms.Button();
            this.panel_requirement_edit = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btRequirementEditAddDependency = new System.Windows.Forms.Button();
            this.btRequirementEditDeleteDependency = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbRequirementEditStatus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btRequirementEditUpdateRequirement = new System.Windows.Forms.Button();
            this.cbRequirementEditSelectRequirement = new System.Windows.Forms.ComboBox();
            this.lbRequirementSelectRequirement = new System.Windows.Forms.Label();
            this.cbRequirementEditSelectProject = new System.Windows.Forms.ComboBox();
            this.lbRequirementEditSelectProject = new System.Windows.Forms.Label();
            this.panel_requirement_edit_addDependency = new System.Windows.Forms.Panel();
            this.cbRequirementEditAddDependencySelectRequirement = new System.Windows.Forms.ComboBox();
            this.btRequirementEditAddDependencySubmit = new System.Windows.Forms.Button();
            this.btRequirementEditAddDependencyBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_requirement_delete = new System.Windows.Forms.Panel();
            this.cbRequirementDeleteSelectProject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btRequirementDeleteDelete = new System.Windows.Forms.Button();
            this.cbRequirementDeleteSelectRequirement = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_project_add.SuspendLayout();
            this.panel_project_edit.SuspendLayout();
            this.panel_project_delete.SuspendLayout();
            this.panel_requirement_add.SuspendLayout();
            this.panel_requirement_edit.SuspendLayout();
            this.panel_requirement_edit_addDependency.SuspendLayout();
            this.panel_requirement_delete.SuspendLayout();
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
            this.treeView1.Size = new System.Drawing.Size(116, 428);
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
            // btlogout
            // 
            this.btlogout.Location = new System.Drawing.Point(0, 430);
            this.btlogout.Name = "btlogout";
            this.btlogout.Size = new System.Drawing.Size(116, 39);
            this.btlogout.TabIndex = 7;
            this.btlogout.Text = "LogOut";
            this.btlogout.UseVisualStyleBackColor = true;
            this.btlogout.Click += new System.EventHandler(this.btlogout_Click);
            // 
            // panel_requirement_edit
            // 
            this.panel_requirement_edit.Controls.Add(this.label1);
            this.panel_requirement_edit.Controls.Add(this.btRequirementEditAddDependency);
            this.panel_requirement_edit.Controls.Add(this.btRequirementEditDeleteDependency);
            this.panel_requirement_edit.Controls.Add(this.checkBox2);
            this.panel_requirement_edit.Controls.Add(this.checkBox1);
            this.panel_requirement_edit.Controls.Add(this.lbRequirementEditStatus);
            this.panel_requirement_edit.Controls.Add(this.listBox1);
            this.panel_requirement_edit.Controls.Add(this.btRequirementEditUpdateRequirement);
            this.panel_requirement_edit.Controls.Add(this.cbRequirementEditSelectRequirement);
            this.panel_requirement_edit.Controls.Add(this.lbRequirementSelectRequirement);
            this.panel_requirement_edit.Controls.Add(this.cbRequirementEditSelectProject);
            this.panel_requirement_edit.Controls.Add(this.lbRequirementEditSelectProject);
            this.panel_requirement_edit.Controls.Add(this.panel_requirement_edit_addDependency);
            this.panel_requirement_edit.Location = new System.Drawing.Point(122, 0);
            this.panel_requirement_edit.Name = "panel_requirement_edit";
            this.panel_requirement_edit.Size = new System.Drawing.Size(793, 477);
            this.panel_requirement_edit.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dependencies";
            // 
            // btRequirementEditAddDependency
            // 
            this.btRequirementEditAddDependency.Location = new System.Drawing.Point(249, 427);
            this.btRequirementEditAddDependency.Name = "btRequirementEditAddDependency";
            this.btRequirementEditAddDependency.Size = new System.Drawing.Size(75, 23);
            this.btRequirementEditAddDependency.TabIndex = 16;
            this.btRequirementEditAddDependency.Text = "Add";
            this.btRequirementEditAddDependency.UseVisualStyleBackColor = true;
            this.btRequirementEditAddDependency.Click += new System.EventHandler(this.btRequirementEditAddDependency_Click);
            // 
            // btRequirementEditDeleteDependency
            // 
            this.btRequirementEditDeleteDependency.Location = new System.Drawing.Point(249, 378);
            this.btRequirementEditDeleteDependency.Name = "btRequirementEditDeleteDependency";
            this.btRequirementEditDeleteDependency.Size = new System.Drawing.Size(75, 23);
            this.btRequirementEditDeleteDependency.TabIndex = 11;
            this.btRequirementEditDeleteDependency.Text = "Delete";
            this.btRequirementEditDeleteDependency.UseVisualStyleBackColor = true;
            this.btRequirementEditDeleteDependency.Click += new System.EventHandler(this.btRequirementEditDeleteDependency_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(486, 87);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 16);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Deactive";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(371, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 16);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Active";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbRequirementEditStatus
            // 
            this.lbRequirementEditStatus.AutoSize = true;
            this.lbRequirementEditStatus.Location = new System.Drawing.Point(178, 81);
            this.lbRequirementEditStatus.Name = "lbRequirementEditStatus";
            this.lbRequirementEditStatus.Size = new System.Drawing.Size(41, 12);
            this.lbRequirementEditStatus.TabIndex = 7;
            this.lbRequirementEditStatus.Text = "Status";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(10, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 208);
            this.listBox1.TabIndex = 6;
            // 
            // btRequirementEditUpdateRequirement
            // 
            this.btRequirementEditUpdateRequirement.Location = new System.Drawing.Point(320, 182);
            this.btRequirementEditUpdateRequirement.Name = "btRequirementEditUpdateRequirement";
            this.btRequirementEditUpdateRequirement.Size = new System.Drawing.Size(75, 23);
            this.btRequirementEditUpdateRequirement.TabIndex = 15;
            this.btRequirementEditUpdateRequirement.Text = "Update";
            this.btRequirementEditUpdateRequirement.UseVisualStyleBackColor = true;
            this.btRequirementEditUpdateRequirement.Click += new System.EventHandler(this.btRequirementEditUpdateRequirement_Click);
            // 
            // cbRequirementEditSelectRequirement
            // 
            this.cbRequirementEditSelectRequirement.FormattingEnabled = true;
            this.cbRequirementEditSelectRequirement.Location = new System.Drawing.Point(408, 44);
            this.cbRequirementEditSelectRequirement.Name = "cbRequirementEditSelectRequirement";
            this.cbRequirementEditSelectRequirement.Size = new System.Drawing.Size(121, 20);
            this.cbRequirementEditSelectRequirement.TabIndex = 3;
            this.cbRequirementEditSelectRequirement.SelectedIndexChanged += new System.EventHandler(this.cbRequirementEditSelectRequirement_SelectedIndexChanged);
            // 
            // lbRequirementSelectRequirement
            // 
            this.lbRequirementSelectRequirement.AutoSize = true;
            this.lbRequirementSelectRequirement.Location = new System.Drawing.Point(178, 50);
            this.lbRequirementSelectRequirement.Name = "lbRequirementSelectRequirement";
            this.lbRequirementSelectRequirement.Size = new System.Drawing.Size(113, 12);
            this.lbRequirementSelectRequirement.TabIndex = 2;
            this.lbRequirementSelectRequirement.Text = "Select Requirement";
            // 
            // cbRequirementEditSelectProject
            // 
            this.cbRequirementEditSelectProject.FormattingEnabled = true;
            this.cbRequirementEditSelectProject.Location = new System.Drawing.Point(407, 9);
            this.cbRequirementEditSelectProject.Name = "cbRequirementEditSelectProject";
            this.cbRequirementEditSelectProject.Size = new System.Drawing.Size(121, 20);
            this.cbRequirementEditSelectProject.TabIndex = 1;
            this.cbRequirementEditSelectProject.SelectedIndexChanged += new System.EventHandler(this.cbRequirementEditSelectProject_SelectedIndexChanged);
            // 
            // lbRequirementEditSelectProject
            // 
            this.lbRequirementEditSelectProject.AutoSize = true;
            this.lbRequirementEditSelectProject.Location = new System.Drawing.Point(176, 17);
            this.lbRequirementEditSelectProject.Name = "lbRequirementEditSelectProject";
            this.lbRequirementEditSelectProject.Size = new System.Drawing.Size(89, 12);
            this.lbRequirementEditSelectProject.TabIndex = 0;
            this.lbRequirementEditSelectProject.Text = "Select Project";
            // 
            // panel_requirement_edit_addDependency
            // 
            this.panel_requirement_edit_addDependency.Controls.Add(this.cbRequirementEditAddDependencySelectRequirement);
            this.panel_requirement_edit_addDependency.Controls.Add(this.btRequirementEditAddDependencySubmit);
            this.panel_requirement_edit_addDependency.Controls.Add(this.btRequirementEditAddDependencyBack);
            this.panel_requirement_edit_addDependency.Controls.Add(this.label4);
            this.panel_requirement_edit_addDependency.Controls.Add(this.label3);
            this.panel_requirement_edit_addDependency.Location = new System.Drawing.Point(0, 0);
            this.panel_requirement_edit_addDependency.Name = "panel_requirement_edit_addDependency";
            this.panel_requirement_edit_addDependency.Size = new System.Drawing.Size(793, 477);
            this.panel_requirement_edit_addDependency.TabIndex = 17;
            // 
            // cbRequirementEditAddDependencySelectRequirement
            // 
            this.cbRequirementEditAddDependencySelectRequirement.FormattingEnabled = true;
            this.cbRequirementEditAddDependencySelectRequirement.Location = new System.Drawing.Point(443, 149);
            this.cbRequirementEditAddDependencySelectRequirement.Name = "cbRequirementEditAddDependencySelectRequirement";
            this.cbRequirementEditAddDependencySelectRequirement.Size = new System.Drawing.Size(121, 20);
            this.cbRequirementEditAddDependencySelectRequirement.TabIndex = 5;
            // 
            // btRequirementEditAddDependencySubmit
            // 
            this.btRequirementEditAddDependencySubmit.Location = new System.Drawing.Point(441, 274);
            this.btRequirementEditAddDependencySubmit.Name = "btRequirementEditAddDependencySubmit";
            this.btRequirementEditAddDependencySubmit.Size = new System.Drawing.Size(75, 23);
            this.btRequirementEditAddDependencySubmit.TabIndex = 4;
            this.btRequirementEditAddDependencySubmit.Text = "Submit";
            this.btRequirementEditAddDependencySubmit.UseVisualStyleBackColor = true;
            this.btRequirementEditAddDependencySubmit.Click += new System.EventHandler(this.btRequirementEditAddDependencySubmit_Click);
            // 
            // btRequirementEditAddDependencyBack
            // 
            this.btRequirementEditAddDependencyBack.Location = new System.Drawing.Point(238, 274);
            this.btRequirementEditAddDependencyBack.Name = "btRequirementEditAddDependencyBack";
            this.btRequirementEditAddDependencyBack.Size = new System.Drawing.Size(75, 23);
            this.btRequirementEditAddDependencyBack.TabIndex = 3;
            this.btRequirementEditAddDependencyBack.Text = "Back";
            this.btRequirementEditAddDependencyBack.UseVisualStyleBackColor = true;
            this.btRequirementEditAddDependencyBack.Click += new System.EventHandler(this.btRequirementEditAddDependencyBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Requirement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Add Dependency";
            // 
            // panel_requirement_delete
            // 
            this.panel_requirement_delete.Controls.Add(this.cbRequirementDeleteSelectProject);
            this.panel_requirement_delete.Controls.Add(this.label6);
            this.panel_requirement_delete.Controls.Add(this.btRequirementDeleteDelete);
            this.panel_requirement_delete.Controls.Add(this.cbRequirementDeleteSelectRequirement);
            this.panel_requirement_delete.Controls.Add(this.label5);
            this.panel_requirement_delete.Location = new System.Drawing.Point(122, 0);
            this.panel_requirement_delete.Name = "panel_requirement_delete";
            this.panel_requirement_delete.Size = new System.Drawing.Size(793, 477);
            this.panel_requirement_delete.TabIndex = 9;
            // 
            // cbRequirementDeleteSelectProject
            // 
            this.cbRequirementDeleteSelectProject.FormattingEnabled = true;
            this.cbRequirementDeleteSelectProject.Location = new System.Drawing.Point(453, 86);
            this.cbRequirementDeleteSelectProject.Name = "cbRequirementDeleteSelectProject";
            this.cbRequirementDeleteSelectProject.Size = new System.Drawing.Size(121, 20);
            this.cbRequirementDeleteSelectProject.TabIndex = 4;
            this.cbRequirementDeleteSelectProject.SelectedIndexChanged += new System.EventHandler(this.cbRequirementDeleteSelectProject_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Select Project";
            // 
            // btRequirementDeleteDelete
            // 
            this.btRequirementDeleteDelete.Location = new System.Drawing.Point(342, 293);
            this.btRequirementDeleteDelete.Name = "btRequirementDeleteDelete";
            this.btRequirementDeleteDelete.Size = new System.Drawing.Size(75, 23);
            this.btRequirementDeleteDelete.TabIndex = 2;
            this.btRequirementDeleteDelete.Text = "Delete";
            this.btRequirementDeleteDelete.UseVisualStyleBackColor = true;
            this.btRequirementDeleteDelete.Click += new System.EventHandler(this.btRequirementDeleteDelete_Click);
            // 
            // cbRequirementDeleteSelectRequirement
            // 
            this.cbRequirementDeleteSelectRequirement.FormattingEnabled = true;
            this.cbRequirementDeleteSelectRequirement.Location = new System.Drawing.Point(452, 159);
            this.cbRequirementDeleteSelectRequirement.Name = "cbRequirementDeleteSelectRequirement";
            this.cbRequirementDeleteSelectRequirement.Size = new System.Drawing.Size(121, 20);
            this.cbRequirementDeleteSelectRequirement.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select Requirement";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.panel_requirement_edit);
            this.Controls.Add(this.panel_requirement_delete);
            this.Controls.Add(this.panel_requirement_add);
            this.Controls.Add(this.panel_project_delete);
            this.Controls.Add(this.panel_project_edit);
            this.Controls.Add(this.panel_project_add);
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
            this.panel_requirement_edit.ResumeLayout(false);
            this.panel_requirement_edit.PerformLayout();
            this.panel_requirement_edit_addDependency.ResumeLayout(false);
            this.panel_requirement_edit_addDependency.PerformLayout();
            this.panel_requirement_delete.ResumeLayout(false);
            this.panel_requirement_delete.PerformLayout();
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
        private System.Windows.Forms.Button btlogout;
        private System.Windows.Forms.Panel panel_requirement_edit;
        private System.Windows.Forms.ComboBox cbRequirementEditSelectProject;
        private System.Windows.Forms.Label lbRequirementEditSelectProject;
        private System.Windows.Forms.ComboBox cbRequirementEditSelectRequirement;
        private System.Windows.Forms.Label lbRequirementSelectRequirement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbRequirementEditStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btRequirementEditUpdateRequirement;
        private System.Windows.Forms.Button btRequirementEditAddDependency;
        private System.Windows.Forms.Panel panel_requirement_edit_addDependency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btRequirementEditAddDependencySubmit;
        private System.Windows.Forms.Button btRequirementEditAddDependencyBack;
        private System.Windows.Forms.Panel panel_requirement_delete;
        private System.Windows.Forms.Button btRequirementDeleteDelete;
        private System.Windows.Forms.ComboBox cbRequirementDeleteSelectRequirement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRequirementDeleteSelectProject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btRequirementEditDeleteDependency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRequirementEditAddDependencySelectRequirement;
    }
}