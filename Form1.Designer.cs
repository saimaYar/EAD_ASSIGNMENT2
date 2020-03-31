namespace PRACTICE_EAD
{
    partial class Form1
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
            this.newUser = new System.Windows.Forms.Button();
            this.existingUser = new System.Windows.Forms.Button();
            this.adminBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newUser
            // 
            this.newUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.newUser.ForeColor = System.Drawing.Color.Olive;
            this.newUser.Location = new System.Drawing.Point(139, 12);
            this.newUser.Name = "newUser";
            this.newUser.Size = new System.Drawing.Size(102, 60);
            this.newUser.TabIndex = 0;
            this.newUser.Text = "new user\r\n";
            this.newUser.UseVisualStyleBackColor = false;
            this.newUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // existingUser
            // 
            this.existingUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.existingUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.existingUser.Location = new System.Drawing.Point(139, 78);
            this.existingUser.Name = "existingUser";
            this.existingUser.Size = new System.Drawing.Size(102, 59);
            this.existingUser.TabIndex = 1;
            this.existingUser.Text = "Existing User";
            this.existingUser.UseVisualStyleBackColor = false;
            this.existingUser.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.adminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.adminBtn.Location = new System.Drawing.Point(139, 158);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(102, 60);
            this.adminBtn.TabIndex = 2;
            this.adminBtn.Text = "Admin";
            this.adminBtn.UseVisualStyleBackColor = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Location = new System.Drawing.Point(139, 261);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(102, 32);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(443, 334);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.adminBtn);
            this.Controls.Add(this.existingUser);
            this.Controls.Add(this.newUser);
            this.Name = "Form1";
            this.Text = "main form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button existingUser;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Button exitBtn;
        public System.Windows.Forms.Button newUser;
    }
}

