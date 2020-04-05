namespace PRACTICE_EAD
{
    partial class admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminBtn = new System.Windows.Forms.Label();
            this.passwrdBtn = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // adminBtn
            // 
            this.adminBtn.AutoSize = true;
            this.adminBtn.Location = new System.Drawing.Point(24, 38);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(39, 13);
            this.adminBtn.TabIndex = 0;
            this.adminBtn.Text = "Admin:";
            // 
            // passwrdBtn
            // 
            this.passwrdBtn.AutoSize = true;
            this.passwrdBtn.Location = new System.Drawing.Point(24, 78);
            this.passwrdBtn.Name = "passwrdBtn";
            this.passwrdBtn.Size = new System.Drawing.Size(55, 13);
            this.passwrdBtn.TabIndex = 1;
            this.passwrdBtn.Text = "password:";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(39, 144);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(197, 144);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(179, 220);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwrdBtn);
            this.Controls.Add(this.adminBtn);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminBtn;
        private System.Windows.Forms.Label passwrdBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}