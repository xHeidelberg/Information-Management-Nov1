namespace Information_Management_Nov1
{
    partial class loginForm
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.err1 = new System.Windows.Forms.Label();
            this.err2 = new System.Windows.Forms.Label();
            this.err3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.usernamePan = new System.Windows.Forms.Panel();
            this.passwordPan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Crimson;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(935, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(64, 51);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // userInput
            // 
            this.userInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInput.BackColor = System.Drawing.SystemColors.Control;
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.userInput.Location = new System.Drawing.Point(651, 209);
            this.userInput.MaxLength = 100;
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(283, 23);
            this.userInput.TabIndex = 1;
            this.userInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // passInput
            // 
            this.passInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passInput.BackColor = System.Drawing.SystemColors.Control;
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.passInput.Location = new System.Drawing.Point(651, 286);
            this.passInput.MaxLength = 100;
            this.passInput.Name = "passInput";
            this.passInput.PasswordChar = '●';
            this.passInput.Size = new System.Drawing.Size(283, 23);
            this.passInput.TabIndex = 2;
            this.passInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label5.Location = new System.Drawing.Point(712, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 26);
            this.label5.TabIndex = 1;
            this.label5.Text = "Admin Login";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loginBtn.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(651, 401);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(283, 40);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatAppearance.BorderSize = 0;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F);
            this.checkBox1.Location = new System.Drawing.Point(651, 333);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // err1
            // 
            this.err1.AutoSize = true;
            this.err1.BackColor = System.Drawing.Color.Transparent;
            this.err1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.err1.ForeColor = System.Drawing.Color.Red;
            this.err1.Location = new System.Drawing.Point(671, 381);
            this.err1.Name = "err1";
            this.err1.Size = new System.Drawing.Size(143, 17);
            this.err1.TabIndex = 7;
            this.err1.Text = "                           ";
            // 
            // err2
            // 
            this.err2.AutoSize = true;
            this.err2.BackColor = System.Drawing.Color.Transparent;
            this.err2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.err2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.err2.ForeColor = System.Drawing.Color.Red;
            this.err2.Location = new System.Drawing.Point(940, 286);
            this.err2.Name = "err2";
            this.err2.Size = new System.Drawing.Size(41, 29);
            this.err2.TabIndex = 0;
            this.err2.Text = "    ";
            // 
            // err3
            // 
            this.err3.AutoSize = true;
            this.err3.BackColor = System.Drawing.Color.Transparent;
            this.err3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.err3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.err3.ForeColor = System.Drawing.Color.Red;
            this.err3.Location = new System.Drawing.Point(940, 205);
            this.err3.Name = "err3";
            this.err3.Size = new System.Drawing.Size(62, 29);
            this.err3.TabIndex = 0;
            this.err3.Text = "       ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 6.2F);
            this.label6.Location = new System.Drawing.Point(594, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Version: 0.1";
            // 
            // usernamePan
            // 
            this.usernamePan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.usernamePan.Location = new System.Drawing.Point(651, 233);
            this.usernamePan.Name = "usernamePan";
            this.usernamePan.Size = new System.Drawing.Size(283, 2);
            this.usernamePan.TabIndex = 8;
            // 
            // passwordPan
            // 
            this.passwordPan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordPan.Location = new System.Drawing.Point(651, 310);
            this.passwordPan.Name = "passwordPan";
            this.passwordPan.Size = new System.Drawing.Size(283, 2);
            this.passwordPan.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Information_Management_Nov1.Properties.Resources.backLogin;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 537);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 21.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(52, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 45);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome to Login Menu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(62, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(427, 92);
            this.label2.TabIndex = 0;
            this.label2.Text = "Created By Robyn Kristoffer Fernandez from BSIT 2-F1\r\nBasic Create, Read, Update " +
    "and Delete (CRUD) \r\nA Requirements for Information Management\r\n\r\n";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(999, 537);
            this.ControlBox = false;
            this.Controls.Add(this.passwordPan);
            this.Controls.Add(this.usernamePan);
            this.Controls.Add(this.err3);
            this.Controls.Add(this.err2);
            this.Controls.Add(this.err1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label err1;
        private System.Windows.Forms.Label err2;
        private System.Windows.Forms.Label err3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel usernamePan;
        private System.Windows.Forms.Panel passwordPan;
    }
}

