using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;


namespace Management_System
{
    public partial class Main : Form
    {
        private const string V = "";

        //bt = button
        //cb = combobox
        //tb = textbox
        //nd = node
        //lb = label
        private IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
        private Dictionary<string, string> userRoles = new Dictionary<string, string>();


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
        }
        private void Main_Load(object sender, EventArgs e)
        {


        }
        public void UpdateUserNow()
        {
            lbUser_Now.Text = "User: " + Program.user_name;
        }
        //select project
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
                    panel_comment_view.BringToFront();
                    List<string> comments = dbOperations.ListAllCommentsYouCanSee(userId);
                    foreach (string comment in comments)
                    {
                        string[] parts = comment.Split(',');
                        ListViewItem item = new ListViewItem(parts[0]);
                        item.SubItems.Add(parts[1]);
                        item.SubItems.Add(parts[2]);
                        item.SubItems.Add(parts[3]);
                        lvComments.Items.Add(item);
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
                dbOperations.InsertProject(tbProjectAddName.Text, tbProjectAddDescription.Text);
                MessageBox.Show("Add Successful");
                cbProjectSelect.Items.Clear();
                tbProjectAddName.Text = V;
                tbProjectAddDescription.Text = V;
                List<string> projectNames = dbOperations.LoadProjects();
                foreach (string projectName in projectNames)
                {
                    cbProjectSelect.Items.Add(projectName);
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
                dbOperations.EditProject(cbProjectSelect.Text, tbProjectEditDescription.Text);
                MessageBox.Show("Edit Successful");
                cbProjectSelect.Items.Clear();
                List<string> projectNames = dbOperations.LoadProjects();
                foreach (string projectName in projectNames)
                {
                    cbProjectSelect.Items.Add(projectName);
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

                dbOperations.DeleteProject(cbProjectDeleteSelectProject.Text);
                MessageBox.Show("Delete Successful");
                cbProjectDeleteSelectProject.Items.Clear();
                List<string> projectNames = dbOperations.LoadProjects();
                foreach (string projectName in projectNames)
                {
                    cbProjectDeleteSelectProject.Items.Add(projectName);
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
                dbOperations.InsertRequirement(cbRequirementAddProject.Text, tbRequirementAddName.Text, tbRequirementAddDescription.Text, cbRequirementAddStatus.Text, tbRequirementAddVersion.Text);
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
            listBox1.Items.Clear();

            if (!string.IsNullOrEmpty(cbRequirementEditSelectRequirement.Text))
            {
                List<string> DependentRequirementNames = dbOperations.LoadDependencies(cbRequirementEditSelectRequirement.Text);
                foreach (string dependencyName in DependentRequirementNames)
                {
                    listBox1.Items.Add(dependencyName);
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
                string dependentRequirementName = listBox1.SelectedItem.ToString();
                string requirementName = cbRequirementEditSelectRequirement.Text;
                string requirementId = dbOperations.GetRequirementID(requirementName);
                string dependentRequirementId = dbOperations.GetRequirementID(dependentRequirementName);
                int dependencyId = dbOperations.GetDependencyID(requirementId, dependentRequirementId);
                dbOperations.DeleteDependency(dependencyId);
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
                dbOperations.UpdateRequirement(cbRequirementEditSelectProject.Text, requirementId, cbRequirementEditSelectRequirement.Text, requirementStatus);
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
            List<string> requirementNames = dbOperations.ListAllRequirements();
            requirementNames.Remove(cbRequirementEditSelectRequirement.Text);
            foreach (string requirementName in requirementNames)
            {
                cbRequirementEditAddDependencySelectRequirement.Items.Add(requirementName);
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
                dbOperations.InsertDependency(cbRequirementEditSelectRequirement.Text, cbRequirementEditAddDependencySelectRequirement.Text);
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
                dbOperations.DeleteRequirement(dbOperations.GetRequirementID(cbRequirementDeleteSelectRequirement.Text), cbRequirementDeleteSelectRequirement.Text);
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
            foreach (DataGridViewRow row in dgvSelectProjectAdmin.Rows)
            {
                try
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["Admin"];
                    if ((bool)cell.FormattedValue)
                    {
                        string userId = dbOperations.GetUserId(row.Cells["user_name"].Value.ToString());
                        dbOperations.SetProjectAdmin(userId, dbOperations.GetProjectID(cbUserProjectManagementSelectProject.Text));
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

        private void cbMemberManagementSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAdmin_now.Text = "Admin of this project: " + dbOperations.GetUserName(dbOperations.AdminOfProject(dbOperations.GetProjectID(cbMemberManagementSelectProject.Text)));
            FillUsersDontBelongToProject(dgvUsersDontBelone);
            FillUsersBelongToProject(dgvProjectMembers);
        }

        private void btUserProjectMembersSubmit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvUsersDontBelone.Rows)
            {
                try
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["dgvcbAdd_To_Member"];
                    if (cell.FormattedValue != null && (bool)cell.FormattedValue)
                    {
                        string userId = dbOperations.GetUserId(row.Cells["dgvcbUsers_Dont_Belone"].Value.ToString());
                        string projectId = dbOperations.GetProjectID(cbMemberManagementSelectProject.Text);
                        string role = "User";
                        bool isAdd = true;
                        dbOperations.UpdateUserRoles(userId, projectId, role, isAdd);
                    }
                }
                catch (Exception ex)
                {
                    // if catch an exception, show the message
                    MessageBox.Show("Submit Failed: " + ex.Message);
                }
            }
            foreach (DataGridViewRow row in dgvProjectMembers.Rows)
            {
                try
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells["dgvcbRemove_Member"];
                    if (cell.FormattedValue != null && (bool)cell.FormattedValue)
                    {
                        string userId = dbOperations.GetUserId(row.Cells["dgvcbMembers"].Value.ToString());
                        string projectId = dbOperations.GetProjectID(cbMemberManagementSelectProject.Text);
                        string role = "User";
                        bool isAdd = false;
                        dbOperations.UpdateUserRoles(userId, projectId, role, isAdd);
                    }
                }
                catch (Exception ex)
                {
                    // if catch an exception, show the message
                    MessageBox.Show("Submit Failed: " + ex.Message);
                }
            }
            FillUsersBelongToProject(dgvProjectMembers);
            FillUsersDontBelongToProject(dgvUsersDontBelone);
        }
    }
}
