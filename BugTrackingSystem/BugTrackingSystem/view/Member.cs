using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BugTrackingSystem.model;
using BugTrackingSystem.controller;

namespace BugTrackingSystem
{
    public partial class Member : Form
    {
       
       
            public Member()
        {
            
           // DataToMemberTable();
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string role = txtrole.Text;
            string name = txtname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string dob = txtdob.Text;
            string address = txtAddress.Text;
        

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(dob) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(role)
                && !string.IsNullOrEmpty(password))
            {
                if (password != "")
                {
                    MemberModel user = new MemberModel();
                    user.Email = email;
                    MemberController userController = new MemberController();
                    Boolean usernameFound = userController.CheckUsername(user);
                    if (!usernameFound)
                    {
                        user.Email = email;
                        Boolean emailFound = userController.CheckEmail(user);
                        if (!emailFound)
                        {
                            user.MemberName = name;
                            user.Address = address;
                            user.Email = email;
                            user.Role = role;
                            user.Password = password;
                            user.Dob = dob;
                            Boolean userAdded = userController.AddUser(user);
                            if (userAdded)
                            {
                                MessageBox.Show("Member successfully added!");
                                makeFieldsBlank();
                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("Unable to add member!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("This email already exists!");
                            txtEmail.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("This username is already taken! Enter a different username!");
                        txtEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Password must be 6 digit!");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please input all the fields!");
            }




        }

       
        public void makeFieldsBlank()
        {
            txtname.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtrole.Text = "";
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void MemberListdataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
           

        }
        private void DataToMemberTable()
        {
            MemberController userController = new MemberController();
            DataTable dataTable = userController.LoadAllUsers();
 
            MemberListdataView.DataSource = dataTable;
           
            MemberListdataView.Columns["password"].Visible = false;
            
            MemberListdataView.Rows.Remove(MemberListdataView.Rows[0]);
         
            MemberListdataView.Columns["id"].HeaderText = "User ID";
            MemberListdataView.Columns["name"].HeaderText = "Name";
            MemberListdataView.Columns["address"].HeaderText = "Address";
            MemberListdataView.Columns["dob"].HeaderText = "DOB";
            MemberListdataView.Columns["email"].HeaderText = "Email";
            MemberListdataView.Columns["role"].HeaderText = "Role";
           
            MemberListdataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MemberListdataView.AllowUserToAddRows = false;
            MemberListdataView.AllowUserToDeleteRows = false;
            MemberListdataView.MultiSelect = false;
            MemberListdataView.AllowUserToResizeRows = false;
            MemberListdataView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

        }

        private void MemberListdataView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtrole.Text = MemberListdataView.CurrentRow.Cells[2].Value.ToString();
            txtname.Text = MemberListdataView.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = MemberListdataView.CurrentRow.Cells[3].Value.ToString();
            txtAddress.Text = MemberListdataView.CurrentRow.Cells[6].Value.ToString();
          
           
        }

        private void Member_Load(object sender, EventArgs e)
        {
            txtdob.Format = DateTimePickerFormat.Custom;
            txtdob.CustomFormat = "yyyy-MM-dd";
            DataToMemberTable();

        }

        private void lblclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            // update action
            string role = txtrole.Text;
            string name = txtname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string dob = txtdob.Text;
            string address = txtAddress.Text;
          

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address)
                && !string.IsNullOrEmpty(dob) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(role)
                && !string.IsNullOrEmpty(password))
            {
                if (password != "")
                {
                    MemberModel user = new MemberModel();
                    user.Email = email;
                    MemberController userController = new MemberController();
                            user.MemberName = name;
                            user.Address = address;
                            user.Email = email;
                            user.Role = role;
                            user.Password = password;
                            user.Dob = dob;

                            Boolean userupdate = userController.UpdateUser(user);
                            if (userupdate)
                            {
                                MessageBox.Show("Member successfully Updated!");
                                makeFieldsBlank();
                                this.Close();

                    }
                            else
                            {
                                MessageBox.Show("Unable to update member!");
                            }
                        
                    
                
                }
                else
                {
                    MessageBox.Show("Password must be 6 digit!");
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please input all the fields!");
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete selected row?", "Delete User?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int userId = Convert.ToInt32(MemberListdataView.SelectedRows[0].Cells[0].Value);
               // string username = MemberListdataView.SelectedRows[0].Cells[7].Value.ToString();
                MemberModel user = new MemberModel();
                user.MemberId = userId;
               // user.Username = username;
                MemberController userController = new MemberController();
                Boolean userDeleted = userController.DeleteUser(user);
                if (userDeleted)
                {
                    MessageBox.Show("Member Deleted!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unable to delete member!");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtdob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
