using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BugTrackingSystem.controller;
using BugTrackingSystem.model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class Bug : Form
    {
        private string username;
        public string role;
        private MySqlConnection databaseConnection = null;
       

       

        public Bug(string username, string role)
        {
          
            this.username = username;
            this.role = role;
           
            InitializeComponent();
        }

        public void FormEnable()
        {
            if (role == "dev")
            {
                txtdate.Enabled = false;
                txtFile.Enabled = false;
                txtIssue.Enabled = false;
                txtLine.Enabled = false;
                txtProject.Enabled = false;
                


            }else
            {
                txtdate.Enabled = true;
                txtFile.Enabled = true;
                txtIssue.Enabled = true;
                txtLine.Enabled = true;
                txtProject.Enabled = true;
                txtLine.Show();
            }
        }



       public void projectList()
        {

            if (databaseConnection == null)
            {
                databaseConnection = DbConnection.GetConnection();
            }

            string query = "select * from project;";

            MySqlCommand cmdDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader myReader;

            try
            {
                databaseConnection.Open();
               
                myReader = cmdDatabase.ExecuteReader();
                while (myReader.Read())
                {

                
                    string pName = myReader.GetString("projectName");
                    txtProject.Items.Add(pName);
                   
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MemberListdataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bugtableview.SelectedRows.Count != 0)
            {

                txtProject.Text = bugtableview.CurrentRow.Cells[2].Value.ToString();
                txtIssue.Text = bugtableview.CurrentRow.Cells[3].Value.ToString();
                txtLine.Text = bugtableview.CurrentRow.Cells[5].Value.ToString();
                txtFile.Text = bugtableview.CurrentRow.Cells[4].Value.ToString();
                txtdate.Text = bugtableview.CurrentRow.Cells[6].Value.ToString();
                txtstatus.Text = bugtableview.CurrentRow.Cells[7].Value.ToString();
            }
            else
            {
                MessageBox.Show("No row selected! Please select a row!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string project = txtProject.Text;
            string file = txtFile.Text;
            string lineno = txtLine.Text;
            string issue = txtIssue.Text;
            string cdate = txtdate.Text;
            string status = txtstatus.Text;
            
           
            if (!string.IsNullOrEmpty(project))
            {
                if (!string.IsNullOrEmpty(issue))
                {
                    Bugs bug = new Bugs();
                    bug.Username = username;
                    bug.ProjectName = project;
                    bug.FileName = file;
                    bug.LineNo = lineno;
                    bug.Issue = issue;
                    bug.CreatedDate = cdate;
                    bug.Status = status;
                  
                    
                    BugController bugController = new BugController();
                    Boolean reported = bugController.ReportBug(bug);
                    if (reported)
                    {
                        MessageBox.Show("Bug successfully reported!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to report bug!");
                    }
                }
                else
                {
                    MessageBox.Show("Project name cannot be blank!");
                    txtProject.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bug Issue cannot be blank!");
                txtIssue.Focus();
            }
        }



        public void LoadBugs()
        {
            BugController bugController = new BugController();
            DataTable dataTable = bugController.LoadMyBugs();
            //populating datagridview with source

            bugtableview.DataSource = dataTable;
            //setting columns visibility
            
            bugtableview.Columns["fixDate"].Visible = false;
            
            //editing columns header text
            bugtableview.Columns["bugId"].HeaderText = "Bug ID";
            bugtableview.Columns["projectName"].HeaderText = "Project Name";
            bugtableview.Columns["issue"].HeaderText = "Bug Description";
            bugtableview.Columns["fileName"].HeaderText = "File Name";
            bugtableview.Columns["lineNo"].HeaderText = "Line No";
            bugtableview.Columns["createdDate"].HeaderText = "Created Date";
            bugtableview.Columns["userName"].HeaderText = "Issue By";

            bugtableview.Columns["status"].HeaderText = "Status";
            bugtableview.Columns["fixDate"].HeaderText = "Fix Date";
            
            //setting user edit role
            bugtableview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bugtableview.AllowUserToAddRows = false;
            bugtableview.AllowUserToDeleteRows = false;
            bugtableview.MultiSelect = false;
            bugtableview.AllowUserToResizeRows = false;
            bugtableview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }

        private void Bug_Load(object sender, EventArgs e)
        {
            txtdate.Format = DateTimePickerFormat.Custom;
            txtdate.CustomFormat = "yyyy-MM-dd";
            LoadBugs();
            projectList();
            FormEnable();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string project = txtProject.Text;
            string file = txtFile.Text;
            string lineno = txtLine.Text;
            string issue = txtIssue.Text;
            string cdate = txtdate.Text;
            string status = txtstatus.Text;


            if (!string.IsNullOrEmpty(project))
            {
                if (!string.IsNullOrEmpty(issue))
                {
                    Bugs bug = new Bugs();
                    bug.BugId = Convert.ToInt32(bugtableview.CurrentRow.Cells[0].Value.ToString());
                    bug.Username = username;
                    bug.ProjectName = project;
                    bug.FileName = file;
                    bug.LineNo = lineno;
                    bug.Issue = issue;
                    bug.CreatedDate = cdate;
                    bug.Status = status;
                    bug.FixBy = username;


                    BugController bugController = new BugController();
                    Boolean reported = bugController.UpdateBug(bug);
                    if (reported)
                    {
                        MessageBox.Show("Bug successfully updated!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to update bug!");
                    }
                }
                else
                {
                    MessageBox.Show("Project name cannot be blank!");
                    txtProject.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bug Issue cannot be blank!");
                txtIssue.Focus();
            }





        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            string project = txtProject.Text;
            string file = txtFile.Text;
            string lineno = txtLine.Text;
            string issue = txtIssue.Text;
            string cdate = txtdate.Text;
            string status = txtstatus.Text;


                if (!string.IsNullOrEmpty(project))
                {
                    Bugs bug = new Bugs();
                    bug.BugId = Convert.ToInt32(bugtableview.CurrentRow.Cells[0].Value.ToString());
                    bug.Username = username;
                    bug.ProjectName = project;
                    bug.FileName = file;
                    bug.LineNo = lineno;
                    bug.Issue = issue;
                    bug.CreatedDate = cdate;
                    bug.Status = status;


                    BugController bugController = new BugController();
                    Boolean reported = bugController.DeleteBug(bug);
                    if (reported)
                    {
                        MessageBox.Show("Bug successfully Deleted!");
                    this.Close();
                }
                    else
                    {
                        MessageBox.Show("Unable to Delete bug!");
                    }
                }
                else
                {
                    MessageBox.Show("Project cannot be blank!");
                    txtProject.Focus();
                }
           

        }
    }
}
