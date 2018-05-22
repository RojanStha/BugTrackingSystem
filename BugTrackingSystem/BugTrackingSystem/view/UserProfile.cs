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
    public partial class UserProfile : Form
    {
        public UserProfile(string name,string email, string address, string dob,string role)
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
