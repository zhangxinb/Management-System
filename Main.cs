using System;
using System.Collections.Generic;

using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;



namespace Management_System
{
    public partial class Main : Form
    {

        private const string V = "";
        private Size originalFormSize;

        //bt = button
        //cb = combobox
        //tb = textbox
        //nd = node
        //lb = label
        private IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
        private Service Service = new Service(new MySqlDatabaseOperations());
        private Dictionary<string, string> userRoles = new Dictionary<string, string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Main"/> class.
        /// </summary>
        public Main()
        {
            InitializeComponent();
            lbUser_Now.Text = "User: " + Program.user_name;
            panel_project_add.Visible = false;
            panel_project_edit.Visible = false;
            panel_project_delete.Visible = false;
            panel_requirement_add.Visible = false;
            panel_requirement_edit.Visible = false;
            panel_requirement_delete.Visible = false;
            panel_project_management.Visible = false;
            panel_member_management.Visible = false;
            panel_comment_view.Visible = false;
            panel_comment_add.Visible = false;
            panel_list_comments_by_requirement.Visible = false;
            panel_report_prrg.Visible = false;
            panel_report_edtv.Visible = false;
            originalFormSize = this.Size;
            FormResizer.SetInitialSize(this);
        }
        private void Main_Resize(object sender, EventArgs e)
        {
            FormResizer.ResizeForm(this, originalFormSize);
        }
        private void Main_Load(object sender, EventArgs e)
        {


        }
        /// <summary>
        /// Update the user name label
        /// </summary>
        public void UpdateUserNow()
        {
            lbUser_Now.Text = "User: " + Program.user_name;
        }

        /// <summary>
        /// Main form tree view node mouse click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string user_name = Program.user_name;
            string userId = dbOperations.GetUserId(user_name);
            bool issuperadmin = dbOperations.IsSuperAdmin(userId);
            bool isadminofanyprojects = dbOperations.IsAdminOfAnyProjects(userId);

            dbOperations.LoadUserRoles(userId, userRoles);// load the user roles

            TreeNode selectdNode = e.Node;//get the select node

            //string userRole = userRoles["role"];
            switch (selectdNode.Name)
            {
                case "ndUserProjectManagement":
                    if (issuperadmin == true)
                    {
                        panel_project_management.Visible = true;
                        panel_project_management.BringToFront();
                        cbUserProjectManagementSelectProject.Items.Clear();
                        cbUserProjectManagementSelectProject.Text = V;

                        //FillSelectAdmin(dgvSelectProjectAdmin);

                        List<string> projectNames = dbOperations.LoadProjects();
                        foreach (string projectName in projectNames)
                        {
                            cbUserProjectManagementSelectProject.Items.Add(projectName);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to manage projects");
                        break;
                    }

                case "ndUserMemberManagement":// if the node is ndMemberManagement
                    if (isadminofanyprojects == true || issuperadmin == true)
                    {
                        panel_member_management.Visible = true;
                        panel_member_management.BringToFront();
                        cbMemberManagementSelectProject.Items.Clear();
                        cbMemberManagementSelectProject.Text = V;
                        List<string> projectNames5;
                        if (issuperadmin == true)
                        {
                            projectNames5 = dbOperations.LoadProjects();
                        }
                        else
                        {
                            projectNames5 = dbOperations.GetUserAdminProjects(userId);
                        }
                        foreach (string projectName in projectNames5)
                        {
                            cbMemberManagementSelectProject.Items.Add(projectName);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to manage members");
                        break;
                    }

                case "ndProjectAdd"://if the node is ndProjectAdd
                    if (issuperadmin == true)
                    {
                        panel_project_add.Visible = true;
                        panel_project_add.BringToFront();
                        panel_project_edit.Visible = false;
                        panel_project_delete.Visible = false;
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to add a project");
                        break;
                    }
                case "ndProjectEdit"://if the node is ndProjectEdit
                    if (issuperadmin == true || isadminofanyprojects == true)
                    {
                        panel_project_add.Visible = false;
                        panel_project_delete.Visible = false;
                        panel_project_edit.Visible = true;
                        panel_project_edit.BringToFront();
                        cbProjectSelect.Items.Clear();
                        cbProjectSelect.Text = V;
                        List<string> projectNames;
                        if (issuperadmin == true)
                        {
                            projectNames = dbOperations.LoadProjects();
                        }
                        else
                        {
                            projectNames = dbOperations.GetUserAdminProjects(userId);
                        }
                        foreach (string projectName in projectNames)
                        {
                            cbProjectSelect.Items.Add(projectName);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to edit a project");
                        break;
                    }
                case "ndProjectDelete":// if the node is ndProjectDelete
                    if (issuperadmin == true)
                    {
                        panel_project_add.Visible = false;
                        panel_project_edit.Visible = false;
                        panel_project_delete.Visible = true;
                        panel_project_delete.BringToFront();
                        cbProjectDeleteSelectProject.Items.Clear();
                        cbProjectDeleteSelectProject.Text = V;
                        List<string> projectNames2 = dbOperations.LoadProjects();
                        foreach (string projectName in projectNames2)
                        {
                            cbProjectDeleteSelectProject.Items.Add(projectName);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to delete a project");
                        break;
                    }
                case "ndRequirementAdd":// if the node is ndRequirementAdd
                    if (issuperadmin == true || isadminofanyprojects == true)
                    {
                        panel_requirement_add.Visible = true;
                        panel_requirement_add.BringToFront();
                        cbRequirementAddProject.Items.Clear();
                        cbRequirementAddProject.Text = V;
                        cbRequirementAddStatus.Text = V;
                        List<string> projectNamesRequirement;
                        if (issuperadmin == true)
                        {
                            projectNamesRequirement = dbOperations.LoadProjects();
                        }
                        else
                        {
                            projectNamesRequirement = dbOperations.GetUserAdminProjects(userId);
                        }
                        foreach (string projectName in projectNamesRequirement)
                        {
                            cbRequirementAddProject.Items.Add(projectName);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to add a requirement");
                        break;
                    }
                case "ndRequirementEdit":// if the node is ndRequirementEdit
                    if (issuperadmin == true || isadminofanyprojects == true)
                    {
                        panel_requirement_edit.Visible = true;
                        panel_requirement_edit_addDependency.Visible = false;
                        panel_requirement_edit.BringToFront();
                        cbRequirementEditSelectProject.Items.Clear();
                        cbRequirementEditSelectProject.Text = V;
                        cbRequirementEditSelectRequirement.Items.Clear();
                        cbRequirementEditSelectRequirement.Text = V;
                        List<string> projectNames3;
                        if (issuperadmin == true)
                        {
                            projectNames3 = dbOperations.LoadProjects();
                        }
                        else
                        {
                            projectNames3 = dbOperations.GetUserAdminProjects(userId);
                        }
                        foreach (string projectName in projectNames3)
                        {
                            cbRequirementEditSelectProject.Items.Add(projectName);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to edit a requirement");
                        break;
                    }
                case "ndRequirementDelete":// if the node is ndRequirementDelete
                    if (issuperadmin == true || isadminofanyprojects == true)
                    {
                        panel_requirement_delete.Visible = true;
                        panel_requirement_delete.BringToFront();
                        cbRequirementDeleteSelectProject.Items.Clear();
                        cbRequirementDeleteSelectProject.Text = V;
                        cbRequirementDeleteSelectRequirement.Items.Clear();
                        cbRequirementDeleteSelectRequirement.Text = V;
                        List<string> projectNames4;
                        if (issuperadmin == true)
                        {
                            projectNames4 = dbOperations.LoadProjects();
                        }
                        else
                        {
                            projectNames4 = dbOperations.GetUserAdminProjects(userId);
                        }
                        foreach (string projectName in projectNames4)
                        {
                            cbRequirementDeleteSelectProject.Items.Add(projectName);
                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to delete a requirement");
                        break;
                    }
                case "ndCommentView":// if the node is ndCommentView
                    panel_comment_view.Visible = true;
                    panel_list_comments_by_requirement.Visible = false;
                    panel_comment_view.BringToFront();
                    List<string> comments = dbOperations.ListAllCommentsYouCanSee(userId);
                    lvComments.Items.Clear();
                    foreach (string comment in comments)
                    {
                        string[] parts = comment.Split(',');
                        ListViewItem item = new ListViewItem(parts[0]);
                        item.SubItems.Add(parts[1]);
                        item.SubItems.Add(parts[2]);
                        item.SubItems.Add(parts[3]);
                        item.SubItems.Add(parts[4]);
                        lvComments.Items.Add(item);
                    }
                    break;
                case "ndCommentAdd":// if the node is ndCommentAdd
                    panel_comment_add.Visible = true;
                    panel_comment_add.BringToFront();
                    clbCommentAddSelectProject.Items.Clear();
                    clbCommentAddSelectRequirement.Items.Clear();
                    tbCommentAddText.Text = V;
                    List<string> projects = dbOperations.ListAllProjectsYouCanSee(userId);
                    foreach (string project in projects)
                    {
                        clbCommentAddSelectProject.Items.Add(project);
                    }
                    List<string> requirements = dbOperations.ListAllRequirementsYouCanSee(userId);
                    foreach (string requirement in requirements)
                    {
                        clbCommentAddSelectRequirement.Items.Add(requirement);
                    }
                    break;
                case "ndPRRG":// if the node is ndReportPrrg
                    panel_report_prrg.Visible = true;
                    panel_report_prrg.BringToFront();
                    cbReportPrrgSelectProject.Items.Clear();
                    cbReportPrrgSelectProject.Text = V;
                    List<string> projectNames6;
                    projectNames6 = dbOperations.ListAllProjectsYouCanSee(userId);
                    foreach (string projectName in projectNames6)
                    {
                        cbReportPrrgSelectProject.Items.Add(projectName);
                    }
                    break;
                case "ndEDTV":// if the node is ndReportEdtv
                    panel_report_edtv.Visible = true;
                    panel_report_edtv.BringToFront();
                    List<string> requirementHistories = dbOperations.ListAllRequirementsHistoryYouCanSee(userId);
                    lvEdtvByRequirement.Items.Clear();
                    foreach (string requirementHistory in requirementHistories)
                    {
                        string[] parts = requirementHistory.Split(',');
                        ListViewItem item = new ListViewItem(parts[0]);
                        item.SubItems.Add(parts[1]);
                        item.SubItems.Add(parts[2]);
                        item.SubItems.Add(parts[3]);
                        item.SubItems.Add(parts[4]);
                        item.SubItems.Add(parts[5]);
                        lvEdtvByRequirement.Items.Add(item);
                    }
                    break;

            }
        }
        private void Project_Load(object sender, EventArgs e)
        {
            List<string> projectNames = dbOperations.LoadProjects();
            foreach (string projectName in projectNames)
            {
                cbProjectSelect.Items.Add(projectName);
            }
        }
        private void panel_project_add_Paint(object sender, PaintEventArgs e)
        {

        }
        // add project
        private void btProjectAddSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = tbProjectAddName.Text;
                string projectDescription = tbProjectAddDescription.Text;
                Service.ManageProject(projectName, projectDescription, "Create");
                MessageBox.Show("Add Successful");
                cbProjectSelect.Items.Clear();
                tbProjectAddName.Text = V;
                tbProjectAddDescription.Text = V;
                List<string> projectNames = dbOperations.LoadProjects();
                foreach (string Name in projectNames)
                {
                    cbProjectSelect.Items.Add(Name);
                }
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Add Failed: " + ex.Message);
            }
        }
        // edit project
        private void btProjectEditSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = cbProjectSelect.Text;
                string projectDescription = tbProjectEditDescription.Text;
                Service.ManageProject(projectName, projectDescription, "Edit");
                MessageBox.Show("Edit Successful");
                cbProjectSelect.Items.Clear();
                List<string> projectNames = dbOperations.LoadProjects();
                foreach (string Name in projectNames)
                {
                    cbProjectSelect.Items.Add(Name);
                }
                tbProjectEditDescription.Clear();
                cbProjectSelect.Text = V;
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Edit Failed: " + ex.Message);
            }
        }
        // delete project
        private void btProjectDeleteDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = cbProjectDeleteSelectProject.Text;
                Service.ManageProject(projectName, "", "Delete");
                MessageBox.Show("Delete Successful");
                cbProjectDeleteSelectProject.Items.Clear();
                List<string> projectNames = dbOperations.LoadProjects();
                foreach (string Name in projectNames)
                {
                    cbProjectDeleteSelectProject.Items.Add(Name);
                }
                cbProjectDeleteSelectProject.Text = V;
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Delete Failed: " + ex.Message);
            }
        }
        private void btRequirementAddSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string projectID = dbOperations.GetProjectID(cbRequirementAddProject.Text);
                string requirementName = tbRequirementAddName.Text;
                string requirementDescription = tbRequirementAddDescription.Text;
                string requirementStatus = cbRequirementAddStatus.Text;
                string requirementVersion = tbRequirementAddVersion.Text;
                Service.ManageRequirement(projectID, "", requirementName, requirementDescription, requirementStatus, requirementVersion, "Create");
                MessageBox.Show("Add Successful");
                cbRequirementAddProject.Text = V;
                tbRequirementAddName.Clear();
                tbRequirementAddDescription.Clear();
                cbRequirementAddStatus.Text = V;
                tbRequirementAddVersion.Clear();
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Add Failed: " + ex.Message);
            }
        }
        private void btlogout_Click(object sender, EventArgs e)
        {
            dbOperations.Logout();
            MessageBox.Show("Logout Successful");
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void cbRequirementEditSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRequirementEditSelectRequirement.Items.Clear();
            cbRequirementEditSelectRequirement.Text = V;

            if (!string.IsNullOrEmpty(cbRequirementEditSelectProject.Text))
            {
                List<string> requirementNames = dbOperations.LoadRequirements(cbRequirementEditSelectProject.Text);
                foreach (string requirementName in requirementNames)
                {
                    cbRequirementEditSelectRequirement.Items.Add(requirementName);
                }
            }

        }
        private void cbRequirementDeleteSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbRequirementDeleteSelectRequirement.Items.Clear();

            if (!string.IsNullOrEmpty(cbRequirementDeleteSelectProject.Text))
            {
                List<string> requirementNames = dbOperations.LoadRequirements(cbRequirementDeleteSelectProject.Text);
                foreach (string requirementName in requirementNames)
                {
                    cbRequirementDeleteSelectRequirement.Items.Add(requirementName);
                }
            }

        }
        private void FillDependenciesListBox()
        {
            listbRequirementEditDependenciesList.Items.Clear();

            if (!string.IsNullOrEmpty(cbRequirementEditSelectRequirement.Text))
            {
                List<string> DependentRequirementNames = dbOperations.LoadDependencies(cbRequirementEditSelectRequirement.Text);
                foreach (string dependencyName in DependentRequirementNames)
                {
                    listbRequirementEditDependenciesList.Items.Add(dependencyName);
                }
            }
        }
        private void cbRequirementEditSelectRequirement_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDependenciesListBox();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
        /*private void btRequirementEditUpdate_Click(object sender, EventArgs e)
        {
            dbOperations.UpdateDependency(dependencyDict[listBox1.SelectedItem.ToString()].ID, tbRequirementEditDependencyChangeTo.Text);
            MessageBox.Show("Update Successful");
            FillDependenciesListBox();
        }*/
        private void btRequirementEditDeleteDependency_Click(object sender, EventArgs e)
        {
            try
            {
                string dependentRequirementName = listbRequirementEditDependenciesList.SelectedItem.ToString();
                string requirementName = cbRequirementEditSelectRequirement.Text;
                string requirementId = dbOperations.GetRequirementID(requirementName);
                string dependentRequirementId = dbOperations.GetRequirementID(dependentRequirementName);
                int dependencyId = dbOperations.GetDependencyID(requirementId, dependentRequirementId);
                Service.ManageDependency(requirementName, dependentRequirementName, "", "Delete");
                MessageBox.Show("Delete Successful");
                FillDependenciesListBox();
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Delete Failed: " + ex.Message);
            }
        }

        private void btRequirementEditUpdateRequirement_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbRequirementEditSelectRequirement.SelectedItem == null)
                {
                    MessageBox.Show("Please select a requirement first");
                    return;
                }
                string requirementStatus = "Default";
                if (checkBox1.Checked)
                {
                    requirementStatus = "Active";
                }
                else if (checkBox2.Checked)
                {
                    requirementStatus = "Deactive";
                }
                string requirementId = dbOperations.GetRequirementID(cbRequirementEditSelectRequirement.Text);
                Service.ManageRequirement("", requirementId, "", "", requirementStatus, "",  "Edit");
                //dbOperations.UpdateRequirement(cbRequirementEditSelectProject.Text, requirementId, cbRequirementEditSelectRequirement.Text, requirementStatus);
                MessageBox.Show("Update Successful");
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Update Failed: " + ex.Message);
            }
        }
        private void btRequirementEditAddDependency_Click(object sender, EventArgs e)
        {
            if (cbRequirementEditSelectRequirement.SelectedItem == null)
            {
                MessageBox.Show("Please select a requirement first");
                return;
            }
            panel_requirement_edit_addDependency.Visible = true;
            panel_requirement_edit_addDependency.BringToFront();
            cbRequirementEditAddDependencySelectRequirement.Items.Clear();
            cbRequirementEditAddDependencySelectRequirement.Text = V;
            cbRequirementEditAddDependencySelectExplanation.Items.Clear();
            cbRequirementEditAddDependencySelectExplanation.Text = V;
            List<string> requirementNames = dbOperations.ListAllRequirements();
            List<string> dependentRequirementNames = dbOperations.LoadDependencies(cbRequirementEditSelectRequirement.Text);
            requirementNames = requirementNames.Except(dependentRequirementNames).ToList();
            requirementNames.Remove(cbRequirementEditSelectRequirement.Text);
            foreach (string requirementName in requirementNames)
            {
                cbRequirementEditAddDependencySelectRequirement.Items.Add(requirementName);
            }
            List<string> dependencyExplanations = dbOperations.ListAllDependencyExplanation();
            foreach (string dependencyExplanation in dependencyExplanations)
            {
                cbRequirementEditAddDependencySelectExplanation.Items.Add(dependencyExplanation);
            }
        }
        private void btRequirementEditAddDependencyBack_Click(object sender, EventArgs e)
        {
            panel_requirement_edit_addDependency.Visible = false;
        }
        private void btRequirementEditAddDependencySubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //dbOperations.InsertDependency(cbRequirementEditSelectRequirement.Text, cbRequirementEditAddDependencySelectRequirement.Text);
                string requirementName = cbRequirementEditSelectRequirement.Text;
                string dependentRequirementName = cbRequirementEditAddDependencySelectRequirement.Text;
                string dependencyDescriptionID = dbOperations.GetDependencyDescriptionID(cbRequirementEditAddDependencySelectExplanation.Text);
                Service.ManageDependency(requirementName, dependentRequirementName, dependencyDescriptionID, "Create");
                MessageBox.Show("Add Successful");
                panel_requirement_edit_addDependency.Visible = false;
                FillDependenciesListBox();
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Add Failed: " + ex.Message);
            }
        }

        private void btRequirementDeleteDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //dbOperations.DeleteRequirement(dbOperations.GetRequirementID(cbRequirementDeleteSelectRequirement.Text), cbRequirementDeleteSelectRequirement.Text);
                string requirementId = dbOperations.GetRequirementID(cbRequirementDeleteSelectRequirement.Text);
                Service.ManageRequirement("", requirementId, "", "", "", "", "Delete");
                MessageBox.Show("Delete Successful");
            }
            catch (Exception ex)
            {
                // if catch an exception, show the message
                MessageBox.Show("Delete Failed: " + ex.Message);
            }
        }
        private void FillSelectAdmin(DataGridView dgv)
        {
            List<string> list = dbOperations.ListAllUsersExceptSadmin();
            DataTable dt = new DataTable();
            dt.Columns.Add("user_name", typeof(string));

            string projectId = dbOperations.GetProjectID(cbUserProjectManagementSelectProject.Text);
            string adminUserId = dbOperations.AdminOfProject(projectId);
            string adminUser = dbOperations.GetUserName(adminUserId);

            foreach (string s in list)
            {
                if (s != adminUser)
                {
                    DataRow row = dt.NewRow();
                    row[0] = s;
                    dt.Rows.Add(row);
                }
            }

            dgv.DataSource = dt;
        }
        private void FillUsersBelongToProject(DataGridView dgv)
        {
            List<string> list = dbOperations.ListUsersBelongToProject(dbOperations.GetProjectID(cbMemberManagementSelectProject.Text));
            DataTable dt = new DataTable();
            dt.Columns.Add("user_name", typeof(string));
            foreach (string s in list)
            {
                DataRow row = dt.NewRow();
                row[0] = s;
                dt.Rows.Add(row);
            }
            dgv.DataSource = dt;
        }
        private void FillUsersDontBelongToProject(DataGridView dgv)
        {
            List<string> list = dbOperations.ListUsersDontBeloneToProject(dbOperations.GetProjectID(cbMemberManagementSelectProject.Text));
            DataTable dt = new DataTable();
            dt.Columns.Add("user_name", typeof(string));
            foreach (string s in list)
            {
                DataRow row = dt.NewRow();
                row[0] = s;
                dt.Rows.Add(row);
            }
            dgv.DataSource = dt;
        }
        private void cbUserProjectManagementSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAdminNow.Text = "Admin of this project: " + dbOperations.GetUserName(dbOperations.AdminOfProject(dbOperations.GetProjectID(cbUserProjectManagementSelectProject.Text)));
            FillSelectAdmin(dgvSelectProjectAdmin);
        }
        // control the checkbox, only one checkbox can be checked
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            DataGridViewCell cell = dgvSelectProjectAdmin.CurrentRow.Cells[1];
            if (cell is DataGridViewCheckBoxCell)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)cell;
                bool cellValue = (bool)cell.FormattedValue;
            }

            foreach (DataGridViewRow row in dgvSelectProjectAdmin.Rows)
            {
                if (row.Index != rowIndex)
                {
                    row.Cells[columnIndex].Value = false;
                }
            }
        }

        private void btUserProjectManagementSubmit_Click(object sender, EventArgs e)
        {
            string projectId = dbOperations.GetProjectID(cbUserProjectManagementSelectProject.Text);
            foreach (DataGridViewRow row in dgvSelectProjectAdmin.Rows)
            {
                try
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["Admin"];
                    if ((bool)cell.FormattedValue)
                    {
                        string userId = dbOperations.GetUserId(row.Cells["user_name"].Value.ToString());
                        dbOperations.SetProjectAdmin(userId, projectId);
                        MessageBox.Show("Submit Successful");
                    }
                }
                catch (Exception ex)
                {
                    // if catch an exception, show the message
                    MessageBox.Show("Submit Failed: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Event handler for the selection change of the project in the member management combobox.
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void cbMemberManagementSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAdmin_now.Text = "Admin of this project: " + dbOperations.GetUserName(dbOperations.AdminOfProject(dbOperations.GetProjectID(cbMemberManagementSelectProject.Text)));
            FillUsersDontBelongToProject(dgvUsersDontBelone);
            FillUsersBelongToProject(dgvProjectMembers);
        }

        /// <summary>
        /// Submit user project member changes
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void btUserProjectMembersSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string projectId = dbOperations.GetProjectID(cbMemberManagementSelectProject.Text);
                foreach (DataGridViewRow row in dgvUsersDontBelone.Rows)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["dgvcbAdd_To_Member"];
                    if (cell.FormattedValue != null && (bool)cell.FormattedValue)
                    {
                        string userId = dbOperations.GetUserId(row.Cells["dgvcbUsers_Dont_Belone"].Value.ToString());
                        string role = "User";
                        bool isAdd = true;
                        dbOperations.UpdateUserRoles(userId, projectId, role, isAdd);
                    }
                }

                foreach (DataGridViewRow row in dgvProjectMembers.Rows)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["dgvcbRemove_Member"];
                    if (cell.FormattedValue != null && (bool)cell.FormattedValue)
                    {
                        string userId = dbOperations.GetUserId(row.Cells["dgvcbMembers"].Value.ToString());
                        string role = "User";
                        bool isAdd = false;
                        dbOperations.UpdateUserRoles(userId, projectId, role, isAdd);
                    }
                }

                FillUsersBelongToProject(dgvProjectMembers);
                FillUsersDontBelongToProject(dgvUsersDontBelone);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Submission failed: " + ex.Message);
            }
        }

        private void btCommentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = dbOperations.GetUserId(Program.user_name);
                string commentContent = tbCommentAddText.Text;
                List<string> projectIds = new List<string>();
                List<string> requirementIds = new List<string>();

                foreach (string project in clbCommentAddSelectProject.CheckedItems)
                {
                    projectIds.Add(dbOperations.GetProjectID(project));
                }
                foreach (string requirement in clbCommentAddSelectRequirement.CheckedItems)
                {
                    requirementIds.Add(dbOperations.GetRequirementID(requirement));
                }

                dbOperations.InsertComment(userId, commentContent, projectIds, requirementIds);
                MessageBox.Show("Add Successful");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Add Failed: " + ex.Message);
            }
        }

        private void btListByRequirement_Click(object sender, EventArgs e)
        {
            panel_list_comments_by_requirement.Visible = true;
            panel_list_comments_by_requirement.BringToFront();
            cbListCommentsByRequirement.Items.Clear();
            cbListCommentsByRequirement.Text = V;
            lvCommentsByRequirement.Items.Clear();
            string userId = dbOperations.GetUserId(Program.user_name);
            List<string> requirementNames = dbOperations.ListAllRequirementsYouCanSee(userId);
            foreach (string requirementName in requirementNames)
            {
                cbListCommentsByRequirement.Items.Add(requirementName);
            }

        }

        private void cbListCommentsByRequirement_SelectedIndexChanged(object sender, EventArgs e)
        {
            string requirementId = dbOperations.GetRequirementID(cbListCommentsByRequirement.Text);
            List<string> comments = dbOperations.ListCommentsByRequirementId(requirementId);
            lvCommentsByRequirement.Items.Clear();
            foreach (string comment in comments)
            {
                string[] parts = comment.Split(',');
                ListViewItem item = new ListViewItem(parts[0]);
                item.SubItems.Add(parts[1]);
                item.SubItems.Add(parts[2]);
                item.SubItems.Add(parts[3]);
                item.SubItems.Add(parts[4]);
                item.SubItems.Add(parts[5]);
                lvCommentsByRequirement.Items.Add(item);
            }
        }

        private void btListCommentsByRequirement_Click(object sender, EventArgs e)
        {
            panel_list_comments_by_requirement.Visible = false;
            panel_list_comments_by_requirement.SendToBack();
            cbListCommentsByRequirement.Text = V;
            lvCommentsByRequirement.Items.Clear();
        }
        public void FillReportRequirementsListBox()
        {
            listbReportRequirementsList.Items.Clear();
            if (!string.IsNullOrEmpty(cbReportPrrgSelectProject.Text))
            {
                List<string> requirementNames = dbOperations.LoadRequirements(cbReportPrrgSelectProject.Text);
                foreach (string requirementName in requirementNames)
                {
                    listbReportRequirementsList.Items.Add(requirementName);
                }
            }
            
        }
        private void cbReportPrrgSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillReportRequirementsListBox();
        }
    }
}
