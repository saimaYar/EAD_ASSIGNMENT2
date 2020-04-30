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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ff = new Form1();
            ff.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ff = new Home();
            ff.ShowDialog();
        }
    }
}
