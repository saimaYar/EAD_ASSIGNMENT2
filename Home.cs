using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICE_EAD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 res = new Form1();
            res.Show();
        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            newUserForm rr = new newUserForm();
            rr.Show();
        }
    }
}
