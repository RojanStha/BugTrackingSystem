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
    }
}
