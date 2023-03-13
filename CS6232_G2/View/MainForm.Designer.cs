namespace CS6232_G2
{
    partial class MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNurse = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchPatient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.ucAppointments = new CS6232_G2.UserControls.ucAppointments();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblUsername);
            this.flowLayoutPanel1.Controls.Add(this.lnkLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 54);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblUsername.Location = new System.Drawing.Point(714, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 20);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdmin,
            this.mnuNurse});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(800, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "Admin";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // mnuNurse
            // 
            this.mnuNurse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchPatient,
            this.mnuNewAppointment});
            this.mnuNurse.Name = "mnuNurse";
            this.mnuNurse.Size = new System.Drawing.Size(50, 20);
            this.mnuNurse.Text = "Nurse";
            // 
            // mnuSearchPatient
            // 
            this.mnuSearchPatient.Name = "mnuSearchPatient";
            this.mnuSearchPatient.Size = new System.Drawing.Size(172, 22);
            this.mnuSearchPatient.Text = "Search Patient";
            // 
            // mnuNewAppointment
            // 
            this.mnuNewAppointment.Name = "mnuNewAppointment";
            this.mnuNewAppointment.Size = new System.Drawing.Size(172, 22);
            this.mnuNewAppointment.Text = "New Appointment";
            this.mnuNewAppointment.Click += new System.EventHandler(this.mnuNewAppointment_Click);
            // 
            // ucAppointments
            // 
            this.ucAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAppointments.Location = new System.Drawing.Point(0, 78);
            this.ucAppointments.Name = "ucAppointments";
            this.ucAppointments.Size = new System.Drawing.Size(800, 372);
            this.ucAppointments.TabIndex = 3;
            // 
            // lnkLogout
            // 
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(649, 0);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(59, 20);
            this.lnkLogout.TabIndex = 7;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucAppointments);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing_1);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNurse;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchPatient;
        private System.Windows.Forms.ToolStripMenuItem mnuNewAppointment;
        private UserControls.ucAppointments ucAppointments;
        private System.Windows.Forms.LinkLabel lnkLogout;
    }
}

