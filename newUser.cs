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
    public partial class newUserForm : Form
    {
        public newUserForm()
        {
            InitializeComponent();
        }

        private void newUserForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void adressBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sports_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
            MessageBox.Show(dateTimePicker1.Value.ToShortTimeString());
        }

        private void upload_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if(result==System.Windows.Forms.DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                pictureBox1.Load(file);
            }
        }

        private void cnicNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
