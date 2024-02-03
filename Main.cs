using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Management_System.MySqlDatabaseOperations;


namespace Management_System
{
    public partial class Main : Form
    {
        //bt = button
        //cb = combobox
        //tb = textbox
        //nd = node
        //lb = label
        private IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
        private Dictionary<string, Dependency> dependencyDict = new Dictionary<string, Dependency>();
        public Main()
        {
            InitializeComponent();
            panel_project_add.Visible = false;
            panel_project_edit.Visible = false;
            panel_project_delete.Visible = false;
            panel_requirement_add.Visible = false;
            panel_requirement_edit.Visible = false;
            panel_requirement_delete.Visible = false;
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
        // select project
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectdNode = e.Node;//get the select node
            switch (selectdNode.Name)
            {
                case "ndProjectAdd"://if the node is ndProjectAdd
                    panel_project_add.Visible = true;
                    panel_project_add.BringToFront();
                    panel_project_edit.Visible = false;
                    panel_project_delete.Visible = false;
                    break;
                case "ndProjectEdit"://if the node is ndProjectEdit
                    panel_project_add.Visible = false;
                    panel_project_delete.Visible = false;
                    panel_project_edit.Visible = true;
                    panel_project_edit.BringToFront();
                    cbProjectSelect.Items.Clear();
                    cbProjectSelect.Text = "";
                    List<string> projectNames = dbOperations.LoadProjects();
                    foreach (string projectName in projectNames)
                    {
                        cbProjectSelect.Items.Add(projectName);
                    }
                    break;
                case "ndProjectDelete":// if the node is ndProjectDelete
                    panel_project_add.Visible = false;
                    panel_project_edit.Visible = false;
                    panel_project_delete.Visible = true;
                    panel_project_delete.BringToFront();
                    cbProjectDeleteSelectProject.Items.Clear();
                    cbProjectDeleteSelectProject.Text = "";
                    List<string> projectNames2 = dbOperations.LoadProjects();
                    foreach (string projectName in projectNames2)
                    {
                        cbProjectDeleteSelectProject.Items.Add(projectName);
                    }
                    break;
                case "ndRequirementAdd":// if the node is ndRequirementAdd
                    panel_requirement_add.Visible = true;
                    panel_requirement_add.BringToFront();
                    cbRequirementAddProject.Items.Clear();
                    cbRequirementAddProject.Text = "";
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
                    cbRequirementEditSelectProject.Text = "";
                    cbRequirementEditSelectRequirement.Items.Clear();
                    cbRequirementEditSelectRequirement.Text = "";
                    listBox1.Items.Clear();

                    List<string> projectNames3 = dbOperations.LoadProjects();
                    foreach (string projectName in projectNames3)
                    {
                        cbRequirementEditSelectProject.Items.Add(projectName);
                    }
                    /*if (!string.IsNullOrEmpty(cbRequirementEditSelectProject.Text))
                    {
                        List<string> requirementNames = dbOperations.LoadRequirements(cbRequirementEditSelectProject.Text);
                        foreach (string requirementName in requirementNames)
                        {
                            cbRequirementEditSelectRequirement.Items.Add(requirementName);
                        }
                    }*/
                    break;
                case "ndRequirementDelete":// if the node is ndRequirementDelete
                    cbRequirementDeleteSelectProject.Items.Clear();
                    cbRequirementDeleteSelectProject.Text = "";
                    cbRequirementDeleteSelectRequirement.Items.Clear();
                    cbRequirementDeleteSelectRequirement.Text = "";
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
            dbOperations.InsertProject(tbProjectAddName.Text, tbProjectAddDescription.Text);
            MessageBox.Show("Add Successful");
            cbProjectSelect.Items.Clear();
            List<string> projectNames = dbOperations.LoadProjects();
            foreach (string projectName in projectNames)
            {
                cbProjectSelect.Items.Add(projectName);
            }
        }
        // edit project
        private void btProjectEditSubmit_Click(object sender, EventArgs e)
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
            cbProjectSelect.Text = "";
        }
        // delete project
        private void btProjectDeleteDelete_Click(object sender, EventArgs e)
        {
            dbOperations.DeleteProject(cbProjectDeleteSelectProject.Text);
            MessageBox.Show("Delete Successful");
            cbProjectDeleteSelectProject.Items.Clear();
            List<string> projectNames = dbOperations.LoadProjects();
            foreach (string projectName in projectNames)
            {
                cbProjectDeleteSelectProject.Items.Add(projectName);
            }
            cbProjectDeleteSelectProject.Text = "";
        }
        private void btRequirementAddSubmit_Click(object sender, EventArgs e)
        {
            dbOperations.InsertRequirement(cbRequirementAddProject.Text, tbRequirementAddName.Text, tbRequirementAddDescription.Text, cbRequirementAddStatus.Text, tbRequirementAddVersion.Text);
            MessageBox.Show("Add Successful");
            cbRequirementAddProject.Text = "";
            tbRequirementAddName.Clear();
            tbRequirementAddDescription.Clear();
            cbRequirementAddStatus.Text = "";
            tbRequirementAddVersion.Clear();
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
            dependencyDict.Clear();

            if (!string.IsNullOrEmpty(cbRequirementEditSelectRequirement.Text))
            {
                List<Dependency> dependencies = dbOperations.LoadDependencies(cbRequirementEditSelectRequirement.Text);
                foreach (Dependency dependency in dependencies)
                {
                    string item = $"ID: {dependency.ID}, Description: {dependency.Description}";
                    listBox1.Items.Add(item);
                    dependencyDict[item] = dependency;
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
        private void btRequirementEditUpdate_Click(object sender, EventArgs e)
        {
            dbOperations.UpdateDependency(dependencyDict[listBox1.SelectedItem.ToString()].ID, tbRequirementEditDependencyChangeTo.Text);
            MessageBox.Show("Update Successful");
            FillDependenciesListBox();
        }
        private void btRequirementEditDeleteDependency_Click(object sender, EventArgs e)
        {
            dbOperations.DeleteDependency(dependencyDict[listBox1.SelectedItem.ToString()].ID);
            MessageBox.Show("Delete Successful");
            FillDependenciesListBox();
        }
        private void btRequirementEditUpdateRequirement_Click(object sender, EventArgs e)
        {
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
            dbOperations.UpdateRequirement(cbRequirementEditSelectProject.Text, requirementId, cbRequirementEditSelectRequirement.Text, tbRequirementEditDescription.Text, requirementStatus);
            MessageBox.Show("Update Successful");
        }
        private void btRequirementEditAddDependency_Click(object sender, EventArgs e)
        {
            panel_requirement_edit_addDependency.Visible = true;
            tbRequirementEditAddDependency.Clear();
        }
        private void btRequirementEditAddDependencyBack_Click(object sender, EventArgs e)
        {
            panel_requirement_edit_addDependency.Visible = false;
        }
        private void btRequirementEditAddDependencySubmit_Click(object sender, EventArgs e)
        {
            dbOperations.InsertDependency(cbRequirementEditSelectRequirement.Text, tbRequirementEditAddDependency.Text);
            MessageBox.Show("Add Successful");
            panel_requirement_edit_addDependency.Visible = false;
            FillDependenciesListBox();
        }

        private void btRequirementDeleteDelete_Click(object sender, EventArgs e)
        {
            dbOperations.DeleteRequirement(dbOperations.GetRequirementID(cbRequirementDeleteSelectRequirement.Text), cbRequirementDeleteSelectRequirement.Text);
            MessageBox.Show("Delete Successful");
        }

    }
}
