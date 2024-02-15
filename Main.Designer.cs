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
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Project Management");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Member Management");
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("User", new System.Windows.Forms.TreeNode[] {
            treeNode52,
            treeNode53});
            System.Windows.Forms.TreeNode treeNode55 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode56 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode57 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode58 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode55,
            treeNode56,
            treeNode57});
            System.Windows.Forms.TreeNode treeNode59 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode60 = new System.Windows.Forms.TreeNode("Edit");
            System.Windows.Forms.TreeNode treeNode61 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode62 = new System.Windows.Forms.TreeNode("Requirement", new System.Windows.Forms.TreeNode[] {
            treeNode59,
            treeNode60,
            treeNode61});
            System.Windows.Forms.TreeNode treeNode63 = new System.Windows.Forms.TreeNode("View");
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Comment", new System.Windows.Forms.TreeNode[] {
            treeNode63,
            treeNode64});
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Project Requirement Report Generator");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Entity Discussion Timeline Viewer");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Report", new System.Windows.Forms.TreeNode[] {
            treeNode66,
            treeNode67});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tvMenuTree = new System.Windows.Forms.TreeView();
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
            this.listbRequirementEditDependenciesList = new System.Windows.Forms.ListBox();
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
            this.panel_project_management = new System.Windows.Forms.Panel();
            this.lbAdminNow = new System.Windows.Forms.Label();
            this.btUserProjectManagementSubmit = new System.Windows.Forms.Button();
            this.dgvSelectProjectAdmin = new System.Windows.Forms.DataGridView();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUserProjectManagementSelectProject = new System.Windows.Forms.ComboBox();
            this.lbSelectProject = new System.Windows.Forms.Label();
            this.panel_member_management = new System.Windows.Forms.Panel();
            this.lbAdmin_now = new System.Windows.Forms.Label();
            this.btUserProjectMembersSubmit = new System.Windows.Forms.Button();
            this.dgvProjectMembers = new System.Windows.Forms.DataGridView();
            this.dgvcbMembers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcbRemove_Member = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvUsersDontBelone = new System.Windows.Forms.DataGridView();
            this.dgvcbUsers_Dont_Belone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcbAdd_To_Member = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbMemberManagementSelectProject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUser_Now = new System.Windows.Forms.Label();
            this.panel_comment_view = new System.Windows.Forms.Panel();
            this.panel_list_comments_by_requirement = new System.Windows.Forms.Panel();
            this.btListCommentsByRequirement = new System.Windows.Forms.Button();
            this.lvCommentsByRequirement = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbListCommentsByRequirement = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btListByRequirement = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lvComments = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_comment_add = new System.Windows.Forms.Panel();
            this.btCommentAdd = new System.Windows.Forms.Button();
            this.tbCommentAddText = new System.Windows.Forms.TextBox();
            this.clbCommentAddSelectRequirement = new System.Windows.Forms.CheckedListBox();
            this.clbCommentAddSelectProject = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_report_prrg = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.listbReportRequirementsList = new System.Windows.Forms.ListBox();
            this.cbReportPrrgSelectProject = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbRequirementEditAddDependencySelectExplanation = new System.Windows.Forms.ComboBox();
            this.panel_project_add.SuspendLayout();
            this.panel_project_edit.SuspendLayout();
            this.panel_project_delete.SuspendLayout();
            this.panel_requirement_add.SuspendLayout();
            this.panel_requirement_edit.SuspendLayout();
            this.panel_requirement_edit_addDependency.SuspendLayout();
            this.panel_requirement_delete.SuspendLayout();
            this.panel_project_management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectProjectAdmin)).BeginInit();
            this.panel_member_management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersDontBelone)).BeginInit();
            this.panel_comment_view.SuspendLayout();
            this.panel_list_comments_by_requirement.SuspendLayout();
            this.panel_comment_add.SuspendLayout();
            this.panel_report_prrg.SuspendLayout();
            this.SuspendLayout();
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tvMenuTree
            // 
            this.tvMenuTree.Location = new System.Drawing.Point(0, 0);
            this.tvMenuTree.Name = "tvMenuTree";
            treeNode52.Name = "ndUserProjectManagement";
            treeNode52.Text = "Project Management";
            treeNode53.Name = "ndUserMemberManagement";
            treeNode53.Text = "Member Management";
            treeNode54.Name = "ndUser";
            treeNode54.Text = "User";
            treeNode55.Name = "ndProjectAdd";
            treeNode55.Text = "Add";
            treeNode56.Name = "ndProjectEdit";
            treeNode56.Text = "Edit";
            treeNode57.Name = "ndProjectDelete";
            treeNode57.Text = "Delete";
            treeNode58.Name = "ndProject";
            treeNode58.Text = "Project";
            treeNode59.Name = "ndRequirementAdd";
            treeNode59.Text = "Add";
            treeNode60.Name = "ndRequirementEdit";
            treeNode60.Text = "Edit";
            treeNode61.Name = "ndRequirementDelete";
            treeNode61.Text = "Delete";
            treeNode62.Name = "Requirement";
            treeNode62.Text = "Requirement";
            treeNode63.Name = "ndCommentView";
            treeNode63.Text = "View";
            treeNode64.Name = "ndCommentAdd";
            treeNode64.Text = "Add";
            treeNode65.Name = "Comment";
            treeNode65.Text = "Comment";
            treeNode66.Name = "ndPRRG";
            treeNode66.Text = "Project Requirement Report Generator";
            treeNode67.Name = "ndEDTV";
            treeNode67.Text = "Entity Discussion Timeline Viewer";
            treeNode68.Name = "Report";
            treeNode68.Text = "Report";
            this.tvMenuTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode54,
            treeNode58,
            treeNode62,
            treeNode65,
            treeNode68});
            this.tvMenuTree.Size = new System.Drawing.Size(116, 372);
            this.tvMenuTree.TabIndex = 2;
            this.tvMenuTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
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
            this.btlogout.AutoSize = true;
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
            this.panel_requirement_edit.Controls.Add(this.listbRequirementEditDependenciesList);
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
            // listbRequirementEditDependenciesList
            // 
            this.listbRequirementEditDependenciesList.FormattingEnabled = true;
            this.listbRequirementEditDependenciesList.ItemHeight = 12;
            this.listbRequirementEditDependenciesList.Location = new System.Drawing.Point(10, 254);
            this.listbRequirementEditDependenciesList.Name = "listbRequirementEditDependenciesList";
            this.listbRequirementEditDependenciesList.Size = new System.Drawing.Size(209, 208);
            this.listbRequirementEditDependenciesList.TabIndex = 6;
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
            this.panel_requirement_edit_addDependency.Controls.Add(this.cbRequirementEditAddDependencySelectExplanation);
            this.panel_requirement_edit_addDependency.Controls.Add(this.label17);
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
            this.cbRequirementEditAddDependencySelectRequirement.Location = new System.Drawing.Point(407, 148);
            this.cbRequirementEditAddDependencySelectRequirement.Name = "cbRequirementEditAddDependencySelectRequirement";
            this.cbRequirementEditAddDependencySelectRequirement.Size = new System.Drawing.Size(270, 20);
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
            this.label4.Location = new System.Drawing.Point(140, 148);
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
            // panel_project_management
            // 
            this.panel_project_management.Controls.Add(this.lbAdminNow);
            this.panel_project_management.Controls.Add(this.btUserProjectManagementSubmit);
            this.panel_project_management.Controls.Add(this.dgvSelectProjectAdmin);
            this.panel_project_management.Controls.Add(this.label2);
            this.panel_project_management.Controls.Add(this.cbUserProjectManagementSelectProject);
            this.panel_project_management.Controls.Add(this.lbSelectProject);
            this.panel_project_management.Location = new System.Drawing.Point(122, 0);
            this.panel_project_management.Name = "panel_project_management";
            this.panel_project_management.Size = new System.Drawing.Size(793, 477);
            this.panel_project_management.TabIndex = 10;
            // 
            // lbAdminNow
            // 
            this.lbAdminNow.AutoSize = true;
            this.lbAdminNow.Location = new System.Drawing.Point(321, 65);
            this.lbAdminNow.Name = "lbAdminNow";
            this.lbAdminNow.Size = new System.Drawing.Size(0, 12);
            this.lbAdminNow.TabIndex = 1;
            // 
            // btUserProjectManagementSubmit
            // 
            this.btUserProjectManagementSubmit.Location = new System.Drawing.Point(342, 386);
            this.btUserProjectManagementSubmit.Name = "btUserProjectManagementSubmit";
            this.btUserProjectManagementSubmit.Size = new System.Drawing.Size(75, 23);
            this.btUserProjectManagementSubmit.TabIndex = 4;
            this.btUserProjectManagementSubmit.Text = "Submit";
            this.btUserProjectManagementSubmit.UseVisualStyleBackColor = true;
            this.btUserProjectManagementSubmit.Click += new System.EventHandler(this.btUserProjectManagementSubmit_Click);
            // 
            // dgvSelectProjectAdmin
            // 
            this.dgvSelectProjectAdmin.AllowUserToAddRows = false;
            this.dgvSelectProjectAdmin.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSelectProjectAdmin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSelectProjectAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectProjectAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_name,
            this.Admin});
            this.dgvSelectProjectAdmin.Location = new System.Drawing.Point(235, 118);
            this.dgvSelectProjectAdmin.MultiSelect = false;
            this.dgvSelectProjectAdmin.Name = "dgvSelectProjectAdmin";
            this.dgvSelectProjectAdmin.RowHeadersVisible = false;
            this.dgvSelectProjectAdmin.RowTemplate.Height = 23;
            this.dgvSelectProjectAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectProjectAdmin.Size = new System.Drawing.Size(301, 254);
            this.dgvSelectProjectAdmin.TabIndex = 3;
            this.dgvSelectProjectAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Name";
            this.user_name.Name = "user_name";
            this.user_name.Width = 150;
            // 
            // Admin
            // 
            this.Admin.DataPropertyName = "Is_admin";
            this.Admin.FalseValue = "";
            this.Admin.HeaderText = "Admin";
            this.Admin.Name = "Admin";
            this.Admin.TrueValue = "";
            this.Admin.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select A New Project Admin";
            // 
            // cbUserProjectManagementSelectProject
            // 
            this.cbUserProjectManagementSelectProject.FormattingEnabled = true;
            this.cbUserProjectManagementSelectProject.Location = new System.Drawing.Point(441, 35);
            this.cbUserProjectManagementSelectProject.Name = "cbUserProjectManagementSelectProject";
            this.cbUserProjectManagementSelectProject.Size = new System.Drawing.Size(121, 20);
            this.cbUserProjectManagementSelectProject.TabIndex = 1;
            this.cbUserProjectManagementSelectProject.SelectedIndexChanged += new System.EventHandler(this.cbUserProjectManagementSelectProject_SelectedIndexChanged);
            // 
            // lbSelectProject
            // 
            this.lbSelectProject.AutoSize = true;
            this.lbSelectProject.Location = new System.Drawing.Point(211, 38);
            this.lbSelectProject.Name = "lbSelectProject";
            this.lbSelectProject.Size = new System.Drawing.Size(89, 12);
            this.lbSelectProject.TabIndex = 0;
            this.lbSelectProject.Text = "Select Project";
            // 
            // panel_member_management
            // 
            this.panel_member_management.Controls.Add(this.lbAdmin_now);
            this.panel_member_management.Controls.Add(this.btUserProjectMembersSubmit);
            this.panel_member_management.Controls.Add(this.dgvProjectMembers);
            this.panel_member_management.Controls.Add(this.dgvUsersDontBelone);
            this.panel_member_management.Controls.Add(this.label9);
            this.panel_member_management.Controls.Add(this.label8);
            this.panel_member_management.Controls.Add(this.cbMemberManagementSelectProject);
            this.panel_member_management.Controls.Add(this.label7);
            this.panel_member_management.Location = new System.Drawing.Point(122, 0);
            this.panel_member_management.Name = "panel_member_management";
            this.panel_member_management.Size = new System.Drawing.Size(793, 477);
            this.panel_member_management.TabIndex = 11;
            // 
            // lbAdmin_now
            // 
            this.lbAdmin_now.AutoSize = true;
            this.lbAdmin_now.Location = new System.Drawing.Point(200, 81);
            this.lbAdmin_now.Name = "lbAdmin_now";
            this.lbAdmin_now.Size = new System.Drawing.Size(0, 12);
            this.lbAdmin_now.TabIndex = 9;
            // 
            // btUserProjectMembersSubmit
            // 
            this.btUserProjectMembersSubmit.Location = new System.Drawing.Point(352, 249);
            this.btUserProjectMembersSubmit.Name = "btUserProjectMembersSubmit";
            this.btUserProjectMembersSubmit.Size = new System.Drawing.Size(75, 23);
            this.btUserProjectMembersSubmit.TabIndex = 8;
            this.btUserProjectMembersSubmit.Text = "Submit";
            this.btUserProjectMembersSubmit.UseVisualStyleBackColor = true;
            this.btUserProjectMembersSubmit.Click += new System.EventHandler(this.btUserProjectMembersSubmit_Click);
            // 
            // dgvProjectMembers
            // 
            this.dgvProjectMembers.AllowUserToAddRows = false;
            this.dgvProjectMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjectMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProjectMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcbMembers,
            this.dgvcbRemove_Member});
            this.dgvProjectMembers.Location = new System.Drawing.Point(441, 134);
            this.dgvProjectMembers.Name = "dgvProjectMembers";
            this.dgvProjectMembers.RowHeadersVisible = false;
            this.dgvProjectMembers.RowTemplate.Height = 23;
            this.dgvProjectMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjectMembers.Size = new System.Drawing.Size(301, 254);
            this.dgvProjectMembers.TabIndex = 7;
            // 
            // dgvcbMembers
            // 
            this.dgvcbMembers.DataPropertyName = "user_name";
            this.dgvcbMembers.HeaderText = "Name";
            this.dgvcbMembers.Name = "dgvcbMembers";
            this.dgvcbMembers.Width = 150;
            // 
            // dgvcbRemove_Member
            // 
            this.dgvcbRemove_Member.DataPropertyName = "remove_members";
            this.dgvcbRemove_Member.FalseValue = "";
            this.dgvcbRemove_Member.HeaderText = "Remove";
            this.dgvcbRemove_Member.Name = "dgvcbRemove_Member";
            this.dgvcbRemove_Member.TrueValue = "";
            this.dgvcbRemove_Member.Width = 150;
            // 
            // dgvUsersDontBelone
            // 
            this.dgvUsersDontBelone.AllowUserToAddRows = false;
            this.dgvUsersDontBelone.AllowUserToDeleteRows = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersDontBelone.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvUsersDontBelone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersDontBelone.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcbUsers_Dont_Belone,
            this.dgvcbAdd_To_Member});
            this.dgvUsersDontBelone.Location = new System.Drawing.Point(35, 134);
            this.dgvUsersDontBelone.Name = "dgvUsersDontBelone";
            this.dgvUsersDontBelone.RowHeadersVisible = false;
            this.dgvUsersDontBelone.RowTemplate.Height = 23;
            this.dgvUsersDontBelone.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsersDontBelone.Size = new System.Drawing.Size(301, 254);
            this.dgvUsersDontBelone.TabIndex = 6;
            // 
            // dgvcbUsers_Dont_Belone
            // 
            this.dgvcbUsers_Dont_Belone.DataPropertyName = "user_name";
            this.dgvcbUsers_Dont_Belone.HeaderText = "Name";
            this.dgvcbUsers_Dont_Belone.Name = "dgvcbUsers_Dont_Belone";
            this.dgvcbUsers_Dont_Belone.Width = 150;
            // 
            // dgvcbAdd_To_Member
            // 
            this.dgvcbAdd_To_Member.DataPropertyName = "add_to_member";
            this.dgvcbAdd_To_Member.FalseValue = "";
            this.dgvcbAdd_To_Member.HeaderText = "Add to Member";
            this.dgvcbAdd_To_Member.Name = "dgvcbAdd_To_Member";
            this.dgvcbAdd_To_Member.TrueValue = "";
            this.dgvcbAdd_To_Member.Width = 150;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "All Users";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "Project Members Now";
            // 
            // cbMemberManagementSelectProject
            // 
            this.cbMemberManagementSelectProject.FormattingEnabled = true;
            this.cbMemberManagementSelectProject.Location = new System.Drawing.Point(441, 44);
            this.cbMemberManagementSelectProject.Name = "cbMemberManagementSelectProject";
            this.cbMemberManagementSelectProject.Size = new System.Drawing.Size(121, 20);
            this.cbMemberManagementSelectProject.TabIndex = 1;
            this.cbMemberManagementSelectProject.SelectedIndexChanged += new System.EventHandler(this.cbMemberManagementSelectProject_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select Project";
            // 
            // lbUser_Now
            // 
            this.lbUser_Now.AutoSize = true;
            this.lbUser_Now.Location = new System.Drawing.Point(12, 378);
            this.lbUser_Now.Name = "lbUser_Now";
            this.lbUser_Now.Size = new System.Drawing.Size(0, 12);
            this.lbUser_Now.TabIndex = 12;
            // 
            // panel_comment_view
            // 
            this.panel_comment_view.Controls.Add(this.panel_list_comments_by_requirement);
            this.panel_comment_view.Controls.Add(this.btListByRequirement);
            this.panel_comment_view.Controls.Add(this.label10);
            this.panel_comment_view.Controls.Add(this.lvComments);
            this.panel_comment_view.Location = new System.Drawing.Point(122, 0);
            this.panel_comment_view.Name = "panel_comment_view";
            this.panel_comment_view.Size = new System.Drawing.Size(793, 477);
            this.panel_comment_view.TabIndex = 13;
            // 
            // panel_list_comments_by_requirement
            // 
            this.panel_list_comments_by_requirement.Controls.Add(this.btListCommentsByRequirement);
            this.panel_list_comments_by_requirement.Controls.Add(this.lvCommentsByRequirement);
            this.panel_list_comments_by_requirement.Controls.Add(this.cbListCommentsByRequirement);
            this.panel_list_comments_by_requirement.Controls.Add(this.label14);
            this.panel_list_comments_by_requirement.Location = new System.Drawing.Point(0, 0);
            this.panel_list_comments_by_requirement.Name = "panel_list_comments_by_requirement";
            this.panel_list_comments_by_requirement.Size = new System.Drawing.Size(790, 474);
            this.panel_list_comments_by_requirement.TabIndex = 3;
            // 
            // btListCommentsByRequirement
            // 
            this.btListCommentsByRequirement.Location = new System.Drawing.Point(330, 430);
            this.btListCommentsByRequirement.Name = "btListCommentsByRequirement";
            this.btListCommentsByRequirement.Size = new System.Drawing.Size(75, 23);
            this.btListCommentsByRequirement.TabIndex = 3;
            this.btListCommentsByRequirement.Text = "Back";
            this.btListCommentsByRequirement.UseVisualStyleBackColor = true;
            this.btListCommentsByRequirement.Click += new System.EventHandler(this.btListCommentsByRequirement_Click);
            // 
            // lvCommentsByRequirement
            // 
            this.lvCommentsByRequirement.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvCommentsByRequirement.HideSelection = false;
            this.lvCommentsByRequirement.Location = new System.Drawing.Point(0, 100);
            this.lvCommentsByRequirement.Name = "lvCommentsByRequirement";
            this.lvCommentsByRequirement.Size = new System.Drawing.Size(787, 321);
            this.lvCommentsByRequirement.TabIndex = 2;
            this.lvCommentsByRequirement.UseCompatibleStateImageBehavior = false;
            this.lvCommentsByRequirement.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Name";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Project";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Requirement";
            this.columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Comment";
            this.columnHeader9.Width = 195;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Link Requirements";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Created Time";
            this.columnHeader11.Width = 130;
            // 
            // cbListCommentsByRequirement
            // 
            this.cbListCommentsByRequirement.FormattingEnabled = true;
            this.cbListCommentsByRequirement.Location = new System.Drawing.Point(276, 55);
            this.cbListCommentsByRequirement.Name = "cbListCommentsByRequirement";
            this.cbListCommentsByRequirement.Size = new System.Drawing.Size(197, 20);
            this.cbListCommentsByRequirement.TabIndex = 1;
            this.cbListCommentsByRequirement.SelectedIndexChanged += new System.EventHandler(this.cbListCommentsByRequirement_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "Select a requirement";
            // 
            // btListByRequirement
            // 
            this.btListByRequirement.Location = new System.Drawing.Point(276, 415);
            this.btListByRequirement.Name = "btListByRequirement";
            this.btListByRequirement.Size = new System.Drawing.Size(200, 23);
            this.btListByRequirement.TabIndex = 2;
            this.btListByRequirement.Text = "Show comments by requirement";
            this.btListByRequirement.UseVisualStyleBackColor = true;
            this.btListByRequirement.Click += new System.EventHandler(this.btListByRequirement_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "All the comments you can see";
            // 
            // lvComments
            // 
            this.lvComments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvComments.HideSelection = false;
            this.lvComments.Location = new System.Drawing.Point(59, 50);
            this.lvComments.Name = "lvComments";
            this.lvComments.Size = new System.Drawing.Size(664, 338);
            this.lvComments.TabIndex = 0;
            this.lvComments.UseCompatibleStateImageBehavior = false;
            this.lvComments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Project";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Requirement";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Comment";
            this.columnHeader4.Width = 220;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Created Time";
            this.columnHeader5.Width = 130;
            // 
            // panel_comment_add
            // 
            this.panel_comment_add.Controls.Add(this.btCommentAdd);
            this.panel_comment_add.Controls.Add(this.tbCommentAddText);
            this.panel_comment_add.Controls.Add(this.clbCommentAddSelectRequirement);
            this.panel_comment_add.Controls.Add(this.clbCommentAddSelectProject);
            this.panel_comment_add.Controls.Add(this.label13);
            this.panel_comment_add.Controls.Add(this.label12);
            this.panel_comment_add.Controls.Add(this.label11);
            this.panel_comment_add.Location = new System.Drawing.Point(122, 0);
            this.panel_comment_add.Name = "panel_comment_add";
            this.panel_comment_add.Size = new System.Drawing.Size(793, 477);
            this.panel_comment_add.TabIndex = 14;
            // 
            // btCommentAdd
            // 
            this.btCommentAdd.Location = new System.Drawing.Point(341, 427);
            this.btCommentAdd.Name = "btCommentAdd";
            this.btCommentAdd.Size = new System.Drawing.Size(75, 23);
            this.btCommentAdd.TabIndex = 8;
            this.btCommentAdd.Text = "Submit";
            this.btCommentAdd.UseVisualStyleBackColor = true;
            this.btCommentAdd.Click += new System.EventHandler(this.btCommentAdd_Click);
            // 
            // tbCommentAddText
            // 
            this.tbCommentAddText.Location = new System.Drawing.Point(148, 368);
            this.tbCommentAddText.Name = "tbCommentAddText";
            this.tbCommentAddText.Size = new System.Drawing.Size(465, 21);
            this.tbCommentAddText.TabIndex = 7;
            // 
            // clbCommentAddSelectRequirement
            // 
            this.clbCommentAddSelectRequirement.FormattingEnabled = true;
            this.clbCommentAddSelectRequirement.Location = new System.Drawing.Point(423, 81);
            this.clbCommentAddSelectRequirement.Name = "clbCommentAddSelectRequirement";
            this.clbCommentAddSelectRequirement.Size = new System.Drawing.Size(190, 244);
            this.clbCommentAddSelectRequirement.TabIndex = 6;
            // 
            // clbCommentAddSelectProject
            // 
            this.clbCommentAddSelectProject.FormattingEnabled = true;
            this.clbCommentAddSelectProject.Location = new System.Drawing.Point(148, 82);
            this.clbCommentAddSelectProject.Name = "clbCommentAddSelectProject";
            this.clbCommentAddSelectProject.Size = new System.Drawing.Size(190, 244);
            this.clbCommentAddSelectProject.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(466, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 12);
            this.label13.TabIndex = 2;
            this.label13.Text = "Select requirement";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(197, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "Select project";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "Add a comment";
            // 
            // panel_report_prrg
            // 
            this.panel_report_prrg.Controls.Add(this.label16);
            this.panel_report_prrg.Controls.Add(this.listbReportRequirementsList);
            this.panel_report_prrg.Controls.Add(this.cbReportPrrgSelectProject);
            this.panel_report_prrg.Controls.Add(this.label15);
            this.panel_report_prrg.Location = new System.Drawing.Point(122, 0);
            this.panel_report_prrg.Name = "panel_report_prrg";
            this.panel_report_prrg.Size = new System.Drawing.Size(790, 477);
            this.panel_report_prrg.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "All requirements belone";
            // 
            // listbReportRequirementsList
            // 
            this.listbReportRequirementsList.FormattingEnabled = true;
            this.listbReportRequirementsList.ItemHeight = 12;
            this.listbReportRequirementsList.Location = new System.Drawing.Point(225, 127);
            this.listbReportRequirementsList.Name = "listbReportRequirementsList";
            this.listbReportRequirementsList.Size = new System.Drawing.Size(313, 280);
            this.listbReportRequirementsList.TabIndex = 2;
            // 
            // cbReportPrrgSelectProject
            // 
            this.cbReportPrrgSelectProject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbReportPrrgSelectProject.FormattingEnabled = true;
            this.cbReportPrrgSelectProject.Location = new System.Drawing.Point(319, 50);
            this.cbReportPrrgSelectProject.Name = "cbReportPrrgSelectProject";
            this.cbReportPrrgSelectProject.Size = new System.Drawing.Size(121, 20);
            this.cbReportPrrgSelectProject.TabIndex = 1;
            this.cbReportPrrgSelectProject.SelectedIndexChanged += new System.EventHandler(this.cbReportPrrgSelectProject_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(337, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "Select project";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(142, 208);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "Dependency Explanation";
            // 
            // cbRequirementEditAddDependencySelectExplanation
            // 
            this.cbRequirementEditAddDependencySelectExplanation.FormattingEnabled = true;
            this.cbRequirementEditAddDependencySelectExplanation.Location = new System.Drawing.Point(407, 211);
            this.cbRequirementEditAddDependencySelectExplanation.Name = "cbRequirementEditAddDependencySelectExplanation";
            this.cbRequirementEditAddDependencySelectExplanation.Size = new System.Drawing.Size(270, 20);
            this.cbRequirementEditAddDependencySelectExplanation.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.panel_requirement_edit);
            this.Controls.Add(this.panel_report_prrg);
            this.Controls.Add(this.panel_comment_view);
            this.Controls.Add(this.lbUser_Now);
            this.Controls.Add(this.panel_comment_add);
            this.Controls.Add(this.panel_member_management);
            this.Controls.Add(this.panel_project_management);
            this.Controls.Add(this.tvMenuTree);
            this.Controls.Add(this.btlogout);
            this.Controls.Add(this.panel_requirement_delete);
            this.Controls.Add(this.panel_requirement_add);
            this.Controls.Add(this.panel_project_delete);
            this.Controls.Add(this.panel_project_edit);
            this.Controls.Add(this.panel_project_add);
            this.Name = "Main";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
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
            this.panel_project_management.ResumeLayout(false);
            this.panel_project_management.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectProjectAdmin)).EndInit();
            this.panel_member_management.ResumeLayout(false);
            this.panel_member_management.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersDontBelone)).EndInit();
            this.panel_comment_view.ResumeLayout(false);
            this.panel_comment_view.PerformLayout();
            this.panel_list_comments_by_requirement.ResumeLayout(false);
            this.panel_list_comments_by_requirement.PerformLayout();
            this.panel_comment_add.ResumeLayout(false);
            this.panel_comment_add.PerformLayout();
            this.panel_report_prrg.ResumeLayout(false);
            this.panel_report_prrg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TreeView tvMenuTree;
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
        private System.Windows.Forms.ListBox listbRequirementEditDependenciesList;
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
        private System.Windows.Forms.Panel panel_project_management;
        private System.Windows.Forms.ComboBox cbUserProjectManagementSelectProject;
        private System.Windows.Forms.Label lbSelectProject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSelectProjectAdmin;
        private System.Windows.Forms.Button btUserProjectManagementSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
        private System.Windows.Forms.Panel panel_member_management;
        private System.Windows.Forms.ComboBox cbMemberManagementSelectProject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvUsersDontBelone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcbUsers_Dont_Belone;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcbAdd_To_Member;
        private System.Windows.Forms.DataGridView dgvProjectMembers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcbMembers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvcbRemove_Member;
        private System.Windows.Forms.Button btUserProjectMembersSubmit;
        private System.Windows.Forms.Label lbUser_Now;
        private System.Windows.Forms.Label lbAdmin_now;
        private System.Windows.Forms.Panel panel_comment_view;
        private System.Windows.Forms.ListView lvComments;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbAdminNow;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel_comment_add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox clbCommentAddSelectRequirement;
        private System.Windows.Forms.CheckedListBox clbCommentAddSelectProject;
        private System.Windows.Forms.Button btCommentAdd;
        private System.Windows.Forms.TextBox tbCommentAddText;
        private System.Windows.Forms.Button btListByRequirement;
        private System.Windows.Forms.Panel panel_list_comments_by_requirement;
        private System.Windows.Forms.ComboBox cbListCommentsByRequirement;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lvCommentsByRequirement;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btListCommentsByRequirement;
        private System.Windows.Forms.Panel panel_report_prrg;
        private System.Windows.Forms.ComboBox cbReportPrrgSelectProject;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox listbReportRequirementsList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbRequirementEditAddDependencySelectExplanation;
        private System.Windows.Forms.Label label17;
    }
}