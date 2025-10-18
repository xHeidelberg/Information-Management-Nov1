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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkedLogout = new System.Windows.Forms.LinkLabel();
            this.linkedMinimize = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chasisNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frameColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearAcquire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
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
            this.panel2.Controls.Add(this.linkedMinimize);
            this.panel2.Controls.Add(this.linkedLogout);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
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
            this.linkedLogout.VisitedLinkColor = System.Drawing.Color.White;
            this.linkedLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkedLogout_LinkClicked);
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
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNumber,
            this.engineNumber,
            this.chasisNumber,
            this.engineSize,
            this.model,
            this.yearModel,
            this.frameColor,
            this.ownerName,
            this.yearAcquire});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            // 
            // idNumber
            // 
            resources.ApplyResources(this.idNumber, "idNumber");
            this.idNumber.Name = "idNumber";
            // 
            // engineNumber
            // 
            resources.ApplyResources(this.engineNumber, "engineNumber");
            this.engineNumber.Name = "engineNumber";
            // 
            // chasisNumber
            // 
            resources.ApplyResources(this.chasisNumber, "chasisNumber");
            this.chasisNumber.Name = "chasisNumber";
            // 
            // engineSize
            // 
            resources.ApplyResources(this.engineSize, "engineSize");
            this.engineSize.Name = "engineSize";
            // 
            // model
            // 
            resources.ApplyResources(this.model, "model");
            this.model.Name = "model";
            // 
            // yearModel
            // 
            resources.ApplyResources(this.yearModel, "yearModel");
            this.yearModel.Name = "yearModel";
            // 
            // frameColor
            // 
            resources.ApplyResources(this.frameColor, "frameColor");
            this.frameColor.Name = "frameColor";
            // 
            // ownerName
            // 
            resources.ApplyResources(this.ownerName, "ownerName");
            this.ownerName.Name = "ownerName";
            // 
            // yearAcquire
            // 
            resources.ApplyResources(this.yearAcquire, "yearAcquire");
            this.yearAcquire.Name = "yearAcquire";
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkedLogout;
        private System.Windows.Forms.LinkLabel linkedMinimize;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn chasisNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn model;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn frameColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearAcquire;
    }
}