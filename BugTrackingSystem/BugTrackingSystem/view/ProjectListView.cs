using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTrackingSystem.model;
using BugTrackingSystem.controller;

namespace BugTrackingSystem.view
{
    public partial class ProjectListView : Form
    {
        public ProjectListView()
        {
            InitializeComponent();
        }
        private void DataToProjectTable()
        {
            ProjectController proController = new ProjectController();
            DataTable dataTable = proController.LoadAllProject();

            projectList.DataSource = dataTable;

            // projectList.Rows.Remove(projectList.Rows[0]);

            projectList.Columns["projectId"].HeaderText = "Project ID";
            projectList.Columns["projectName"].HeaderText = "Project Name";
            projectList.Columns["createdDate"].HeaderText = "Created Date";
            projectList.Columns["EndDate"].HeaderText = "End Date";


            projectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            projectList.AllowUserToAddRows = false;
            projectList.AllowUserToDeleteRows = false;
            projectList.MultiSelect = false;
            projectList.AllowUserToResizeRows = false;
            projectList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private void ProjectListView_Load(object sender, EventArgs e)
        {
            DataToProjectTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
