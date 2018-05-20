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

namespace BugTrackingSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            DbConnection();

           // Dashboard db = new Dashboard();
          //  db.Show();
        }

        private void DbConnection()
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

    }
}
