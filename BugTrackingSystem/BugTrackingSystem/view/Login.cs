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
using MySql;
using BugTrackingSystem.model;
using BugTrackingSystem.controller;
using BugTrackingSystem.view;

namespace BugTrackingSystem
{
    public partial class Login : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public Login()
        {
            server = "Localhost";
            database = "bugtrackingsystem";
            uid = "root";
            password = "";

            string connString;
            connString = $"Server={server}; Database={database};Uid={uid};Pwd={password};SSlMode=none;";

            conn = new MySqlConnection(connString);
            InitializeComponent();

        }
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (IsLogin(user, pass)){

                MessageBox.Show($"Welcome{user}!");
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();

            }
            else
            {
                MessageBox.Show($"User Does not Exist");
            }*/

            string username = txtUser.Text;
            string password = txtPass.Text;
            if (!string.IsNullOrEmpty(username))
            {
                if (!string.IsNullOrEmpty(password))
                {
                    MemberModel user = new MemberModel();
                    
                    user.Email = username;
                    user.Password = password;
                    MemberController userController = new MemberController();
                    Boolean valid = userController.Authenticate(user);
                    if (valid)
                    {
                        string role = userController.RetrieveRole(user);
                        //opening required user dashboard
                        if (role == "Admin")
                        {
                            this.Hide();
                            Dashboard Dash = new Dashboard(username);
                            Dash.ShowDialog();
                            this.Close();
                        }
                        else if (role == "Developer")
                        {
                            this.Hide();
                            DevDashboard devDash = new DevDashboard(username);
                            devDash.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            this.Hide();
                            TesterDashboard testDash = new TesterDashboard(username);
                            testDash.ShowDialog();
                            this.Close();

                        }


                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                        txtUser.Text = "";
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your password!");
                    txtPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter your username!");
                txtUser.Focus();
            }


        }
        

       

       /* private void DbConnection()
        {
            //Data Source=127.0.0.1;Database=MyDb1;User Id=root;Password=blabla;SSL Mode=Required"
            string ConnectString = "Server=localhost; Database=bugtrackingsystem;Uid=root;Pwd=;SSlMode=none;";
            MySqlConnection Dbconnect = new MySqlConnection(ConnectString);
            try
            {
                Dbconnect.Open();
                MessageBox.Show("Ok you are connected");
            }
            catch(Exception e) {
                MessageBox.Show(e.Message);
            }

        }
        */

    }
}
