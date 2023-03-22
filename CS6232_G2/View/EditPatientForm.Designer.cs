namespace CS6232_G2.View
{
    partial class EditPatientForm
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
            this.editPatientUserControl1 = new CS6232_G2.UserControls.EditPatientUserControl(new NurseForm());
            this.SuspendLayout();
            // 
            // editPatientUserControl1
            // 
            this.editPatientUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editPatientUserControl1.Location = new System.Drawing.Point(0, 0);
            this.editPatientUserControl1.Name = "editPatientUserControl1";
            this.editPatientUserControl1.Size = new System.Drawing.Size(800, 450);
            this.editPatientUserControl1.TabIndex = 0;
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editPatientUserControl1);
            this.Name = "EditPatientForm";
            this.Text = "EditPatientForm";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.EditPatientUserControl editPatientUserControl1;
    }
}