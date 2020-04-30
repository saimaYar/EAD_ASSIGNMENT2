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
            string applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            System.IO.Directory.CreateDirectory(applicationBasePath + @"\images\");

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
                pictureBox1.Image = Image.FromFile(file);
            }
        }

        private void cnicNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();
            string login = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();
           // char gender = ComboBox.text.trim();
            string adress = adressBox.Text.Trim();
            string age = ageBox.Text.Trim();
            string nic =cnicNo.Text.Trim();
            string dob = dateTimePicker1.Text.Trim();
             string cricket=(checkBox1.Checked== true ? "1" : "0");
            string tennis = (checkBox2.Checked == true ? "1" : "0");
            string baseBall = (checkBox3.Checked == true ? "1" : "0");
            string email = textBox3.Text.Trim();

            string uniqueName = "";
            if(pictureBox1.Image !=null)
            {
                string applicationBasePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                string pathToSaveImage = applicationBasePath + @"\images\";
                uniqueName = Guid.NewGuid().ToString() + ".jpg";
                string imgPath = pathToSaveImage + uniqueName;
                pictureBox1.Image.Save(imgPath);

            }







            this.Hide();
            Home hom = new Home();
            hom.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ageBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
