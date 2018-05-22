using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using BugTrackingSystem.controller;
using BugTrackingSystem.model;
using BugTrackingSystem.view;

namespace BugTrackingSystem
{
    public partial class Dashboard : Form
    {
        
        string userName;
        string role = "admin";
        
        public Dashboard(string userName)
        {
            this.userName = userName;
          
            InitializeComponent();
        }
       
        int mousex = 0;
        int mousey = 0;
        bool mousedown;

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

             contentPanel.Controls.Clear();
             ProjectForm Pfrom = new ProjectForm(userName);
             Pfrom.FormBorderStyle = FormBorderStyle.None;
             Pfrom.TopLevel = false;
             Pfrom.AutoScroll = true;
             contentPanel.Controls.Add(Pfrom);
             Pfrom.Show();



        }

        private void panel_Load(object sender, EventArgs e)
        {

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mousex = MousePosition.X - 250;
                mousey = MousePosition.Y - 40;

                this.SetDesktopLocation(mousex, mousey);
            }

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            Member mb = new Member();
            mb.FormBorderStyle = FormBorderStyle.None;
            mb.TopLevel = false;
            mb.AutoScroll = true;
            contentPanel.Controls.Add(mb);
            mb.Show();

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnBug_Click(object sender, EventArgs e)
        {
            
            
            contentPanel.Controls.Clear();
            Bug bg = new Bug(userName,role);
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.TopLevel = false;
            bg.AutoScroll = true;
            contentPanel.Controls.Add(bg);
            bg.Show();

        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RojanStha/BugTrackingSystem");
        }

        private void SideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Header_Paint(object sender, PaintEventArgs e)
        {
            lbluser.Text = userName;
        }
    }
}
