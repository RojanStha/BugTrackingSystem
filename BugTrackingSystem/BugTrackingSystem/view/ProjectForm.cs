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

namespace BugTrackingSystem
{
    public partial class ProjectForm : Form
    {

        string userName;
        public ProjectForm(string username)
        {
            this.userName = username;
            InitializeComponent();
        }

        public ProjectForm()
        {
            InitializeComponent();
        }

        private void lblMember_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string project = txtProject.Text;
            


                if (project != "")
                {
                    projectModel projectMod = new projectModel();
                    ProjectController projControll = new ProjectController();
                    projectMod.ProjectId = Convert.ToInt32(projectList.CurrentRow.Cells[0].Value.ToString());
                
                    

                    Boolean projectAdded = projControll.AddProject(projectMod); ;
                    if (projectAdded)
                    {
                        MessageBox.Show("Project successfully Deleted!");
                        makeFieldsBlank();
                    this.Close();


                    }
                    else
                    {
                        MessageBox.Show("Unable to Delete Project!");
                    }
                }
                else
                {
                    MessageBox.Show("Project field is empty!");
                    txtProject.Focus();
                }
           
        }

        private void MemberListdataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(projectList.SelectedRows.Count != 0)
            {

                txtProject.Text = projectList.CurrentRow.Cells[1].Value.ToString();
                txtCreatedDate.Text = projectList.CurrentRow.Cells[2].Value.ToString();
                txtEndDate.Text = projectList.CurrentRow.Cells[3].Value.ToString();
            }else{
                MessageBox.Show("No row selected! Please select a row!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string project = txtProject.Text;
            string createdDate = txtCreatedDate.Text;
            string enddate = txtEndDate.Text;


            if (!string.IsNullOrEmpty(project) && !string.IsNullOrEmpty(createdDate) && !string.IsNullOrEmpty(enddate)
               )
            {
                if (project != "")
                {
                    projectModel projectMod = new projectModel();
                    ProjectController projControll = new ProjectController();
                   
                    projectMod.ProjectName = project;
                    projectMod.CreatedDate = createdDate;
                    projectMod.EndDate = enddate;

                    Boolean projectAdded = projControll.AddProject(projectMod); ;
                    if (projectAdded)
                    {
                        MessageBox.Show("Project successfully Created!");
                        makeFieldsBlank();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Unable to create Project!");
                    }
                }
                else
                {
                    MessageBox.Show("please Fill Created Date!");
                    txtCreatedDate.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter Project name!");
                txtProject.Focus();
            }
        }
    

        private void makeFieldsBlank()
        {
            txtProject.Clear();
            txtCreatedDate.Text = "";
            txtEndDate.Text = "";

        }

        private void DataToMemberTable()
        {
            ProjectController proController = new ProjectController();
            DataTable dataTable = proController.LoadAllProject();

            projectList.DataSource = dataTable;

           // projectList.Rows.Remove(projectList.Rows[0]);

            projectList.Columns["projectId"].HeaderText = "Project ID";
            projectList.Columns["projectName"].HeaderText = "Project Name";
            projectList.Columns["createdDate"].HeaderText = "Created Date";
            projectList.Columns["EndDate"].HeaderText = "End Date";

            projectList.Columns["userName"].HeaderText = "Updated By";


            projectList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            projectList.AllowUserToAddRows = false;
            projectList.AllowUserToDeleteRows = false;
            projectList.MultiSelect = false;
            projectList.AllowUserToResizeRows = false;
            projectList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            txtCreatedDate.Format = DateTimePickerFormat.Custom;
            txtCreatedDate.CustomFormat = "yyyy-MM-dd";
            txtEndDate.Format = DateTimePickerFormat.Custom;
            txtEndDate.CustomFormat = "yyyy-MM-dd";
            DataToMemberTable();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
           
        {  

            string project = txtProject.Text;
            string createdDate = txtCreatedDate.Text;
            string enddate = txtEndDate.Text;


            if (!string.IsNullOrEmpty(project) && !string.IsNullOrEmpty(createdDate) && !string.IsNullOrEmpty(enddate)
               )
            {
                if (project != "")
                {
                    projectModel projectMod = new projectModel();
                    ProjectController projControll = new ProjectController();
                    projectMod.ProjectId = Convert.ToInt32(projectList.CurrentRow.Cells[0].Value.ToString());
                    projectMod.ProjectName = project;
                    projectMod.CreatedDate = createdDate;
                    projectMod.EndDate = enddate;
                    projectMod.Username = userName;
                    

                    Boolean updateProject = projControll.UpdateProject(projectMod); ;
                    if (updateProject)
                    {
                        MessageBox.Show("Update successfully!");
                        makeFieldsBlank();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to update Project!");
                    }
                }
                else
                {
                    MessageBox.Show("please Fill Created Date!");
                    txtCreatedDate.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter Project name!");
                txtProject.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
