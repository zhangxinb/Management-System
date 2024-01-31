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


namespace Management_System
{
    public partial class Main : Form
    {
        private IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
        public Main()
        {
            InitializeComponent();
            panel_project_add.Visible = false;
            panel_project_edit.Visible = false;
        }
        private void Main_Load(object sender, EventArgs e)
        {

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

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectdNode = e.Node;//get the select node
            switch (selectdNode.Name)
            {
                case "ndProjectAdd":
                    panel_project_add.Visible = true;
                    panel_project_add.BringToFront();
                    panel_project_edit.Visible = false;
                    break;
                case "ndProjectEdit":
                    panel_project_add.Visible = false;
                    panel_project_edit.Visible = true;
                    panel_project_edit.BringToFront();
                    cbProjectSelect.Items.Clear();
                    List<string> projectNames = dbOperations.LoadProjects();
                    foreach (string projectName in projectNames)
                    {
                        cbProjectSelect.Items.Add(projectName);
                    }
                    break;
            }
        }
    }
}
