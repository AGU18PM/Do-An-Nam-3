namespace TelevisionsStoreManagement.GUI
{
    partial class fSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSignUp));
            this.btnPickPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbPW2 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPW = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.cbAdmin = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnPickPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPickPicture
            // 
            this.btnPickPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPickPicture.Image = ((System.Drawing.Image)(resources.GetObject("btnPickPicture.Image")));
            this.btnPickPicture.Location = new System.Drawing.Point(118, 28);
            this.btnPickPicture.Name = "btnPickPicture";
            this.btnPickPicture.Size = new System.Drawing.Size(96, 96);
            this.btnPickPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPickPicture.TabIndex = 21;
            this.btnPickPicture.TabStop = false;
            this.btnPickPicture.Click += new System.EventHandler(this.btnPickPicture_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 306);
            this.panel1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Controls.Add(this.txbPW2);
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Location = new System.Drawing.Point(30, 128);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 41);
            this.panel4.TabIndex = 4;
            this.panel4.TabStop = true;
            // 
            // txbPW2
            // 
            this.txbPW2.BackColor = System.Drawing.Color.LightGray;
            this.txbPW2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPW2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPW2.ForeColor = System.Drawing.Color.DimGray;
            this.txbPW2.Location = new System.Drawing.Point(7, 5);
            this.txbPW2.Multiline = true;
            this.txbPW2.Name = "txbPW2";
            this.txbPW2.PasswordChar = '*';
            this.txbPW2.Size = new System.Drawing.Size(214, 27);
            this.txbPW2.TabIndex = 2;
            this.txbPW2.Text = "Nhập lại mật khẩu";
            this.txbPW2.UseSystemPasswordChar = true;
            this.txbPW2.Enter += new System.EventHandler(this.txbPW2_Enter);
            this.txbPW2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(227, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(175)))), ((int)(((byte)(252)))));
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.Location = new System.Drawing.Point(30, 212);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(275, 54);
            this.btnSignup.TabIndex = 3;
            this.btnSignup.TabStop = false;
            this.btnSignup.Text = "ĐĂNG KÝ";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.txbPW);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(30, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 41);
            this.panel3.TabIndex = 3;
            this.panel3.TabStop = true;
            // 
            // txbPW
            // 
            this.txbPW.BackColor = System.Drawing.Color.LightGray;
            this.txbPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPW.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPW.ForeColor = System.Drawing.Color.DimGray;
            this.txbPW.Location = new System.Drawing.Point(7, 5);
            this.txbPW.Multiline = true;
            this.txbPW.Name = "txbPW";
            this.txbPW.PasswordChar = '*';
            this.txbPW.Size = new System.Drawing.Size(214, 27);
            this.txbPW.TabIndex = 2;
            this.txbPW.Text = "Mật khẩu";
            this.txbPW.UseSystemPasswordChar = true;
            this.txbPW.Enter += new System.EventHandler(this.txbPW_Enter);
            this.txbPW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(227, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txbUsername);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(30, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 41);
            this.panel2.TabIndex = 1;
            this.panel2.TabStop = true;
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.LightGray;
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txbUsername.Location = new System.Drawing.Point(7, 8);
            this.txbUsername.Multiline = true;
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(214, 27);
            this.txbUsername.TabIndex = 1;
            this.txbUsername.Text = "Tên đăng nhập";
            this.txbUsername.UseSystemPasswordChar = true;
            this.txbUsername.TextChanged += new System.EventHandler(this.txbUsername_TextChanged);
            this.txbUsername.Enter += new System.EventHandler(this.txbUsername_Enter);
            this.txbUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbUsername_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(227, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.BackColor = System.Drawing.Color.LightGray;
            this.txbDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbDisplayName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayName.ForeColor = System.Drawing.Color.DimGray;
            this.txbDisplayName.Location = new System.Drawing.Point(56, 134);
            this.txbDisplayName.Multiline = true;
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(214, 27);
            this.txbDisplayName.TabIndex = 12;
            this.txbDisplayName.Text = "Nhập tên hiển thị";
            this.txbDisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbDisplayName.UseSystemPasswordChar = true;
            this.txbDisplayName.Enter += new System.EventHandler(this.txbDisplayName_Enter);
            // 
            // cbAdmin
            // 
            this.cbAdmin.AutoSize = true;
            this.cbAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.cbAdmin.Location = new System.Drawing.Point(125, 167);
            this.cbAdmin.Name = "cbAdmin";
            this.cbAdmin.Size = new System.Drawing.Size(86, 17);
            this.cbAdmin.TabIndex = 22;
            this.cbAdmin.Text = "Administrater";
            this.cbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(295, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 32);
            this.btnExit.TabIndex = 23;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // fSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(333, 496);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbAdmin);
            this.Controls.Add(this.txbDisplayName);
            this.Controls.Add(this.btnPickPicture);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSignUp";
            ((System.ComponentModel.ISupportInitialize)(this.btnPickPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnPickPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbPW2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbPW;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.CheckBox cbAdmin;
        private System.Windows.Forms.Button btnExit;
    }
}