using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Project : Form
    {
        private IDatabaseOperations dbOperations = new MySqlDatabaseOperations();
        public Project()
        {
            InitializeComponent();
            panel_Add.Visible = false;
            panel_Edit.Visible = false;
        }

        private void Project_Load(object sender, EventArgs e)
        {
            List<string> projectNames = dbOperations.LoadProjects();
            foreach (string projectName in projectNames)
            {
                cb_project_name.Items.Add(projectName);
            }
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            //show the panel_Add
            panel_Add.Visible = true;
            panel_Add.BringToFront();
            panel_Edit.Visible = false;
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            //show the panel_Edit
            panel_Edit.Visible = true;
            cb_Edit.Items.Clear();
            List<string> projectNames = dbOperations.LoadProjects();
            foreach (string projectName in projectNames)
            {
                cb_Edit.Items.Add(projectName);
            }
        }

        private void btAddSubmit_Click(object sender, EventArgs e)
        {
            dbOperations.InsertProject(tbName.Text, tbDescription.Text);
            MessageBox.Show("Add Successful");
            panel_Add.Visible = false;
            cb_project_name.Items.Clear();
            List<string> projectNames = dbOperations.LoadProjects();
            foreach (string projectName in projectNames)
            {
                cb_project_name.Items.Add(projectName);
            }
        }
        private void btAddCancle_Click(object sender, EventArgs e)
        {
            panel_Add.Visible = false;
        }
        private void btEditSubmit_Click(object sender, EventArgs e)
        {
            dbOperations.EditProject(cb_Edit.Text, tbEditDescription.Text);
            MessageBox.Show("Edit Successful");
            panel_Edit.Visible = false;
            cb_Edit.Items.Clear();
            List<string> projectNames = dbOperations.LoadProjects();
            foreach (string projectName in projectNames)
            {
                cb_Edit.Items.Add(projectName);
            }
            tbEditDescription.Clear();
        }
        private void btEditCancle_Click(object sender, EventArgs e)
        {
            panel_Edit.Visible = false;
            tbEditDescription.Clear();
        }
    }
}
