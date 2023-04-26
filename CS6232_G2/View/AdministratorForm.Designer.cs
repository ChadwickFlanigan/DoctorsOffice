namespace CS6232_G2.View
{
    partial class AdministratorForm
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
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tabNurses = new System.Windows.Forms.TabPage();
            this.ucSearchNurse1 = new CS6232_G2.UserControls.ucSearchNurse();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.ucLabTestStatistic1 = new CS6232_G2.UserControls.ucLabTestStatistic();
            this.searchTableLayoutPanel.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.tabNurses.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 3;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchTableLayoutPanel.Controls.Add(this.lblAdministrator, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lblUsername, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lnkLogout, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lblName, 2, 1);
            this.searchTableLayoutPanel.Controls.Add(this.tabAdmin, 0, 2);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 3;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.75F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.75F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.5F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.searchTableLayoutPanel.TabIndex = 2;
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrator.Location = new System.Drawing.Point(3, 2);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(274, 16);
            this.lblAdministrator.TabIndex = 0;
            this.lblAdministrator.Text = "Administrator";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblUsername.Location = new System.Drawing.Point(742, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 20;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkLogout
            // 
            this.lnkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLogout.AutoSize = true;
            this.lnkLogout.Location = new System.Drawing.Point(517, 0);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(40, 13);
            this.lnkLogout.TabIndex = 21;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.Click += new System.EventHandler(this.lnkLogout_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblName.Location = new System.Drawing.Point(742, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabAdmin
            // 
            this.searchTableLayoutPanel.SetColumnSpan(this.tabAdmin, 3);
            this.tabAdmin.Controls.Add(this.tabNurses);
            this.tabAdmin.Controls.Add(this.tabStats);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(3, 45);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(794, 402);
            this.tabAdmin.TabIndex = 23;
            // 
            // tabNurses
            // 
            this.tabNurses.Controls.Add(this.ucSearchNurse1);
            this.tabNurses.Location = new System.Drawing.Point(4, 22);
            this.tabNurses.Name = "tabNurses";
            this.tabNurses.Padding = new System.Windows.Forms.Padding(3);
            this.tabNurses.Size = new System.Drawing.Size(786, 376);
            this.tabNurses.TabIndex = 0;
            this.tabNurses.Text = "Nurses";
            this.tabNurses.UseVisualStyleBackColor = true;
            // 
            // ucSearchNurse1
            // 
            this.ucSearchNurse1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearchNurse1.Location = new System.Drawing.Point(3, 3);
            this.ucSearchNurse1.Name = "ucSearchNurse1";
            this.ucSearchNurse1.Size = new System.Drawing.Size(780, 370);
            this.ucSearchNurse1.TabIndex = 0;
            // 
            // tabStats
            // 
            this.tabStats.Controls.Add(this.ucLabTestStatistic1);
            this.tabStats.Location = new System.Drawing.Point(4, 22);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabStats.Size = new System.Drawing.Size(786, 376);
            this.tabStats.TabIndex = 1;
            this.tabStats.Text = "Stats";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // ucLabTestStatistic1
            // 
            this.ucLabTestStatistic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLabTestStatistic1.Location = new System.Drawing.Point(3, 3);
            this.ucLabTestStatistic1.Name = "ucLabTestStatistic1";
            this.ucLabTestStatistic1.Size = new System.Drawing.Size(780, 370);
            this.ucLabTestStatistic1.TabIndex = 0;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTableLayoutPanel);
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministratorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdministratorForm_FormClosing);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.tabAdmin.ResumeLayout(false);
            this.tabNurses.ResumeLayout(false);
            this.tabStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.TabPage tabNurses;
        private System.Windows.Forms.TabPage tabStats;
        private UserControls.ucSearchNurse ucSearchNurse1;
        private UserControls.ucLabTestStatistic ucLabTestStatistic1;
    }
}