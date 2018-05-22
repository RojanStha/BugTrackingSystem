using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTrackingSystem.view
{
    public partial class DevDashboard : Form
    {

        int mousex = 0;
        int mousey = 0;
        bool mousedown;
        string username;
        string role = "dev";
       
        public DevDashboard(string user)
        {
            this.username = user;
           
            InitializeComponent();
        }

        private void DevDashboard_Load(object sender, EventArgs e)
        {
            lbluser.Text = username;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            ProjectForm Pfrom = new ProjectForm(username);
            Pfrom.FormBorderStyle = FormBorderStyle.None;
            Pfrom.TopLevel = false;
            Pfrom.AutoScroll = true;
            contentPanel.Controls.Add(Pfrom);
            Pfrom.Show();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            MemberListView mb = new MemberListView();
            mb.FormBorderStyle = FormBorderStyle.None;
            mb.TopLevel = false;
            mb.AutoScroll = true;
            contentPanel.Controls.Add(mb);
            mb.Show();
        }

        private void btnBug_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            Bug bg = new Bug(username, role);
            bg.FormBorderStyle = FormBorderStyle.None;
            bg.TopLevel = false;
            bg.AutoScroll = true;
            contentPanel.Controls.Add(bg);
            bg.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVersion_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RojanStha/BugTrackingSystem");
        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
