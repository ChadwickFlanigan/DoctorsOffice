namespace CS6232_G2.View
{
    partial class NurseForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchPatientUserControl1 = new CS6232_G2.UserControls.SearchPatientUserControl();
            this.tabControl.SuspendLayout();
            this.searchTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.searchTabPage);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // searchTabPage
            // 
            this.searchTabPage.Controls.Add(this.searchPatientUserControl1);
            this.searchTabPage.Location = new System.Drawing.Point(4, 22);
            this.searchTabPage.Name = "searchTabPage";
            this.searchTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchTabPage.Size = new System.Drawing.Size(792, 424);
            this.searchTabPage.TabIndex = 0;
            this.searchTabPage.Text = "Search";
            this.searchTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchPatientUserControl1
            // 
            this.searchPatientUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPatientUserControl1.Location = new System.Drawing.Point(3, 3);
            this.searchPatientUserControl1.Name = "searchPatientUserControl1";
            this.searchPatientUserControl1.Size = new System.Drawing.Size(786, 418);
            this.searchPatientUserControl1.TabIndex = 0;
            // 
            // NurseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "NurseForm";
            this.Text = "NurseForm";
            this.tabControl.ResumeLayout(false);
            this.searchTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage searchTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControls.SearchPatientUserControl searchPatientUserControl1;
    }
}