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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createRequirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRequirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRequirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activateRequirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateRequirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRequirementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.projectToolStripMenuItem1,
            this.requirementToolStripMenuItem1,
            this.commentToolStripMenuItem1,
            this.reportToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(915, 25);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip1";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.userToolStripMenuItem.Text = "User";
            // 
            // projectToolStripMenuItem1
            // 
            this.projectToolStripMenuItem1.Name = "projectToolStripMenuItem1";
            this.projectToolStripMenuItem1.Size = new System.Drawing.Size(60, 21);
            this.projectToolStripMenuItem1.Text = "Project";
            this.projectToolStripMenuItem1.Click += new System.EventHandler(this.projectToolStripMenuItem1_Click);
            // 
            // requirementToolStripMenuItem1
            // 
            this.requirementToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createRequirementToolStripMenuItem,
            this.selectRequirementToolStripMenuItem,
            this.editRequirementToolStripMenuItem,
            this.activateRequirementToolStripMenuItem,
            this.deactivateRequirementToolStripMenuItem,
            this.deleteRequirementToolStripMenuItem});
            this.requirementToolStripMenuItem1.Name = "requirementToolStripMenuItem1";
            this.requirementToolStripMenuItem1.Size = new System.Drawing.Size(94, 21);
            this.requirementToolStripMenuItem1.Text = "Requirement";
            // 
            // createRequirementToolStripMenuItem
            // 
            this.createRequirementToolStripMenuItem.Name = "createRequirementToolStripMenuItem";
            this.createRequirementToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.createRequirementToolStripMenuItem.Text = "Create";
            // 
            // selectRequirementToolStripMenuItem
            // 
            this.selectRequirementToolStripMenuItem.Name = "selectRequirementToolStripMenuItem";
            this.selectRequirementToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.selectRequirementToolStripMenuItem.Text = "Select";
            // 
            // editRequirementToolStripMenuItem
            // 
            this.editRequirementToolStripMenuItem.Name = "editRequirementToolStripMenuItem";
            this.editRequirementToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.editRequirementToolStripMenuItem.Text = "Edit";
            // 
            // activateRequirementToolStripMenuItem
            // 
            this.activateRequirementToolStripMenuItem.Name = "activateRequirementToolStripMenuItem";
            this.activateRequirementToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.activateRequirementToolStripMenuItem.Text = "Activate";
            // 
            // deactivateRequirementToolStripMenuItem
            // 
            this.deactivateRequirementToolStripMenuItem.Name = "deactivateRequirementToolStripMenuItem";
            this.deactivateRequirementToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deactivateRequirementToolStripMenuItem.Text = "Deactivate";
            // 
            // deleteRequirementToolStripMenuItem
            // 
            this.deleteRequirementToolStripMenuItem.Name = "deleteRequirementToolStripMenuItem";
            this.deleteRequirementToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.deleteRequirementToolStripMenuItem.Text = "Delete";
            // 
            // commentToolStripMenuItem1
            // 
            this.commentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCommentToolStripMenuItem,
            this.selectCommentToolStripMenuItem,
            this.editCommentToolStripMenuItem,
            this.deleteCommentToolStripMenuItem});
            this.commentToolStripMenuItem1.Name = "commentToolStripMenuItem1";
            this.commentToolStripMenuItem1.Size = new System.Drawing.Size(76, 21);
            this.commentToolStripMenuItem1.Text = "Comment";
            // 
            // createCommentToolStripMenuItem
            // 
            this.createCommentToolStripMenuItem.Name = "createCommentToolStripMenuItem";
            this.createCommentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.createCommentToolStripMenuItem.Text = "Create";
            // 
            // selectCommentToolStripMenuItem
            // 
            this.selectCommentToolStripMenuItem.Name = "selectCommentToolStripMenuItem";
            this.selectCommentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.selectCommentToolStripMenuItem.Text = "Select";
            // 
            // editCommentToolStripMenuItem
            // 
            this.editCommentToolStripMenuItem.Name = "editCommentToolStripMenuItem";
            this.editCommentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.editCommentToolStripMenuItem.Text = "Edit";
            // 
            // deleteCommentToolStripMenuItem
            // 
            this.deleteCommentToolStripMenuItem.Name = "deleteCommentToolStripMenuItem";
            this.deleteCommentToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteCommentToolStripMenuItem.Text = "Delete";
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportToolStripMenuItem,
            this.viewReportToolStripMenuItem});
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(60, 21);
            this.reportToolStripMenuItem1.Text = "Report";
            // 
            // generateReportToolStripMenuItem
            // 
            this.generateReportToolStripMenuItem.Name = "generateReportToolStripMenuItem";
            this.generateReportToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.generateReportToolStripMenuItem.Text = "Generate";
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.viewReportToolStripMenuItem.Text = "View";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 473);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Main";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem requirementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createRequirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRequirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRequirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activateRequirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateRequirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRequirementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}