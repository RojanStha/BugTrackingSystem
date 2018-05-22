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
    public partial class MemberListView : Form
    {
        public MemberListView()
        {
            InitializeComponent();
        }

        private void DataToMemberTable()
        {
            MemberController userController = new MemberController();
            DataTable dataTable = userController.LoadAllUsers();

            userView.DataSource = dataTable;

            userView.Columns["password"].Visible = false;

            userView.Rows.Remove(userView.Rows[0]);

            userView.Columns["id"].HeaderText = "User ID";
            userView.Columns["name"].HeaderText = "Name";
            userView.Columns["address"].HeaderText = "Address";
            userView.Columns["dob"].HeaderText = "DOB";
            userView.Columns["email"].HeaderText = "Email";
            userView.Columns["role"].HeaderText = "Role";

            userView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userView.AllowUserToAddRows = false;
            userView.AllowUserToDeleteRows = false;
            userView.MultiSelect = false;
            userView.AllowUserToResizeRows = false;
            userView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }


        private void MemberListView_Load(object sender, EventArgs e)
        {
            DataToMemberTable();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
