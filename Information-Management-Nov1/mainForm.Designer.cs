namespace Information_Management_Nov1
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkedImport = new System.Windows.Forms.LinkLabel();
            this.linkedReload = new System.Windows.Forms.LinkLabel();
            this.linkedBackup = new System.Windows.Forms.LinkLabel();
            this.linkedExport = new System.Windows.Forms.LinkLabel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.linkedMinimize = new System.Windows.Forms.LinkLabel();
            this.linkedLogout = new System.Windows.Forms.LinkLabel();
            this.mainGrid = new System.Windows.Forms.DataGridView();
            this.chassisInput = new System.Windows.Forms.TextBox();
            this.enginenumberInput = new System.Windows.Forms.TextBox();
            this.enginesizeInput = new System.Windows.Forms.TextBox();
            this.modelInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ownernameInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.purchaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.yearPicker = new System.Windows.Forms.DateTimePicker();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.timestampLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.linkedImport);
            this.panel1.Controls.Add(this.linkedReload);
            this.panel1.Controls.Add(this.linkedBackup);
            this.panel1.Controls.Add(this.linkedExport);
            this.panel1.Controls.Add(this.exitBtn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // linkedImport
            // 
            this.linkedImport.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkedImport, "linkedImport");
            this.linkedImport.BackColor = System.Drawing.Color.Transparent;
            this.linkedImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedImport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkedImport.LinkColor = System.Drawing.Color.White;
            this.linkedImport.Name = "linkedImport";
            this.linkedImport.TabStop = true;
            this.linkedImport.UseCompatibleTextRendering = true;
            this.linkedImport.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // linkedReload
            // 
            this.linkedReload.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkedReload, "linkedReload");
            this.linkedReload.BackColor = System.Drawing.Color.Transparent;
            this.linkedReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedReload.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkedReload.LinkColor = System.Drawing.Color.White;
            this.linkedReload.Name = "linkedReload";
            this.linkedReload.TabStop = true;
            this.linkedReload.UseCompatibleTextRendering = true;
            this.linkedReload.VisitedLinkColor = System.Drawing.Color.White;
            this.linkedReload.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedReload_LinkClicked);
            // 
            // linkedBackup
            // 
            this.linkedBackup.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkedBackup, "linkedBackup");
            this.linkedBackup.BackColor = System.Drawing.Color.Transparent;
            this.linkedBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedBackup.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkedBackup.LinkColor = System.Drawing.Color.White;
            this.linkedBackup.Name = "linkedBackup";
            this.linkedBackup.TabStop = true;
            this.linkedBackup.UseCompatibleTextRendering = true;
            this.linkedBackup.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // linkedExport
            // 
            this.linkedExport.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkedExport, "linkedExport");
            this.linkedExport.BackColor = System.Drawing.Color.Transparent;
            this.linkedExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedExport.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkedExport.LinkColor = System.Drawing.Color.White;
            this.linkedExport.Name = "linkedExport";
            this.linkedExport.TabStop = true;
            this.linkedExport.UseCompatibleTextRendering = true;
            this.linkedExport.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Firebrick;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.TabStop = false;
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Name = "label1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.linkedMinimize);
            this.panel2.Controls.Add(this.linkedLogout);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label14, "label14");
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label14.Name = "label14";
            // 
            // linkedMinimize
            // 
            this.linkedMinimize.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkedMinimize, "linkedMinimize");
            this.linkedMinimize.BackColor = System.Drawing.Color.Transparent;
            this.linkedMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedMinimize.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkedMinimize.LinkColor = System.Drawing.Color.White;
            this.linkedMinimize.Name = "linkedMinimize";
            this.linkedMinimize.TabStop = true;
            this.linkedMinimize.VisitedLinkColor = System.Drawing.Color.White;
            this.linkedMinimize.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedMinimize_LinkClicked);
            // 
            // linkedLogout
            // 
            this.linkedLogout.ActiveLinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.linkedLogout, "linkedLogout");
            this.linkedLogout.BackColor = System.Drawing.Color.Transparent;
            this.linkedLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkedLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkedLogout.LinkColor = System.Drawing.Color.White;
            this.linkedLogout.Name = "linkedLogout";
            this.linkedLogout.TabStop = true;
            this.linkedLogout.VisitedLinkColor = System.Drawing.Color.White;
            this.linkedLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedLogout_LinkClicked);
            // 
            // mainGrid
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.mainGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.mainGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.mainGrid, "mainGrid");
            this.mainGrid.Name = "mainGrid";
            this.mainGrid.RowTemplate.Height = 24;
            this.mainGrid.TabStop = false;
            // 
            // chassisInput
            // 
            resources.ApplyResources(this.chassisInput, "chassisInput");
            this.chassisInput.Name = "chassisInput";
            // 
            // enginenumberInput
            // 
            resources.ApplyResources(this.enginenumberInput, "enginenumberInput");
            this.enginenumberInput.Name = "enginenumberInput";
            // 
            // enginesizeInput
            // 
            resources.ApplyResources(this.enginesizeInput, "enginesizeInput");
            this.enginesizeInput.Name = "enginesizeInput";
            // 
            // modelInput
            // 
            resources.ApplyResources(this.modelInput, "modelInput");
            this.modelInput.Name = "modelInput";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Name = "label6";
            // 
            // ownernameInput
            // 
            resources.ApplyResources(this.ownernameInput, "ownernameInput");
            this.ownernameInput.Name = "ownernameInput";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label9.Name = "label9";
            // 
            // purchaseDatePicker
            // 
            this.purchaseDatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.purchaseDatePicker, "purchaseDatePicker");
            this.purchaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.purchaseDatePicker.Name = "purchaseDatePicker";
            this.purchaseDatePicker.Value = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // yearPicker
            // 
            this.yearPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.yearPicker, "yearPicker");
            this.yearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.yearPicker.Name = "yearPicker";
            this.yearPicker.Value = new System.DateTime(2025, 10, 19, 0, 0, 0, 0);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addBtn, "addBtn");
            this.addBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBtn.Name = "addBtn";
            this.addBtn.TabStop = false;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.deleteBtn, "deleteBtn");
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.TabStop = false;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Beige;
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.TabStop = false;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Beige;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.updateBtn, "updateBtn");
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.TabStop = false;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label11.Name = "label11";
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.ForeColor = System.Drawing.Color.Green;
            this.statusLabel.Name = "statusLabel";
            // 
            // timestampLabel
            // 
            resources.ApplyResources(this.timestampLabel, "timestampLabel");
            this.timestampLabel.BackColor = System.Drawing.Color.Transparent;
            this.timestampLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.timestampLabel.Name = "timestampLabel";
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.yearPicker);
            this.Controls.Add(this.purchaseDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.timestampLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelInput);
            this.Controls.Add(this.enginesizeInput);
            this.Controls.Add(this.enginenumberInput);
            this.Controls.Add(this.ownernameInput);
            this.Controls.Add(this.chassisInput);
            this.Controls.Add(this.mainGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkedLogout;
        private System.Windows.Forms.LinkLabel linkedMinimize;
        private System.Windows.Forms.DataGridView mainGrid;
        private System.Windows.Forms.TextBox chassisInput;
        private System.Windows.Forms.LinkLabel linkedExport;
        private System.Windows.Forms.TextBox enginenumberInput;
        private System.Windows.Forms.TextBox enginesizeInput;
        private System.Windows.Forms.TextBox modelInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ownernameInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker purchaseDatePicker;
        private System.Windows.Forms.DateTimePicker yearPicker;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label timestampLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel linkedBackup;
        private System.Windows.Forms.LinkLabel linkedImport;
        private System.Windows.Forms.LinkLabel linkedReload;
    }
}