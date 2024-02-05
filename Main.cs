﻿using System;
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
            panel_project_add.Visible = false;
            panel_project_edit.Visible = false;
            panel_project_delete.Visible = false;
            panel_requirement_add.Visible = false;
            panel_requirement_edit.Visible = false;
            panel_requirement_delete.Visible = false;
            panel_project_management.Visible = false;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        // select project
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string user_name = Program.user_name;
            string userId = dbOperations.GetUserId(user_name);
            bool issuperadmin = dbOperations.IsSuperAdmin(userId);
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

                        FillUserNames(dataGridView1);

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
                    if (issuperadmin == true)
                    {
                        panel_project_add.Visible = false;
                        panel_project_delete.Visible = false;
                        panel_project_edit.Visible = true;
                        panel_project_edit.BringToFront();
                        cbProjectSelect.Items.Clear();
                        cbProjectSelect.Text = V;
                        List<string> projectNames = dbOperations.LoadProjects();
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
                    panel_requirement_add.Visible = true;
                    panel_requirement_add.BringToFront();
                    cbRequirementAddProject.Items.Clear();
                    cbRequirementAddProject.Text = V;
                    cbRequirementAddStatus.Text = V;
                    List<string> projectNamesRequirement = dbOperations.LoadProjects();
                    foreach (string projectName in projectNamesRequirement)
                    {
                        cbRequirementAddProject.Items.Add(projectName);
                    }
                    break;
                case "ndRequirementEdit":// if the node is ndRequirementEdit
                    panel_requirement_edit.Visible = true;
                    panel_requirement_edit_addDependency.Visible = false;
                    panel_requirement_edit.BringToFront();
                    cbRequirementEditSelectProject.Items.Clear();
                    cbRequirementEditSelectProject.Text = V;
                    cbRequirementEditSelectRequirement.Items.Clear();
                    cbRequirementEditSelectRequirement.Text = V;
                    List<string> projectNames3 = dbOperations.LoadProjects();
                    foreach (string projectName in projectNames3)
                    {
                        cbRequirementEditSelectProject.Items.Add(projectName);
                    }
                    break;
                case "ndRequirementDelete":// if the node is ndRequirementDelete
                    cbRequirementDeleteSelectProject.Items.Clear();
                    cbRequirementDeleteSelectProject.Text = V;
                    cbRequirementDeleteSelectRequirement.Items.Clear();
                    cbRequirementDeleteSelectRequirement.Text = V;
                    panel_requirement_delete.Visible = true;
                    panel_requirement_delete.BringToFront();
                    List<string> projectNames4 = dbOperations.LoadProjects();
                    foreach (string projectName in projectNames4)
                    {
                        cbRequirementDeleteSelectProject.Items.Add(projectName);
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
        private void FillUserNames(DataGridView dgv)
        {
            List<string> list = dbOperations.ListUsers();
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
            FillUserNames(dataGridView1);
        }
    }
}
