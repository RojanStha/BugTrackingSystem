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

namespace BugTrackingSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
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
            ProjectForm Pfrom = new ProjectForm();
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
    }
}
