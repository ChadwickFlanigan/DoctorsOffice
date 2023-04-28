namespace CS6232_G2.View
{
    partial class PatientTabsForm
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
            this.tbPatientInfo = new System.Windows.Forms.TabControl();
            this.appointments = new System.Windows.Forms.TabPage();
            this.ucPatientAppointments = new CS6232_G2.UserControls.ucPatientAppointments();
            this.tabVisits = new System.Windows.Forms.TabPage();
            this.visitsUserControl = new CS6232_G2.UserControls.VisitsUserControl();
            this.tbPatientInfo.SuspendLayout();
            this.appointments.SuspendLayout();
            this.tabVisits.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPatientInfo
            // 
            this.tbPatientInfo.Controls.Add(this.appointments);
            this.tbPatientInfo.Controls.Add(this.tabVisits);
            this.tbPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPatientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientInfo.Location = new System.Drawing.Point(0, 0);
            this.tbPatientInfo.Name = "tbPatientInfo";
            this.tbPatientInfo.SelectedIndex = 0;
            this.tbPatientInfo.Size = new System.Drawing.Size(1021, 450);
            this.tbPatientInfo.TabIndex = 0;
            // 
            // appointments
            // 
            this.appointments.Controls.Add(this.ucPatientAppointments);
            this.appointments.Location = new System.Drawing.Point(4, 25);
            this.appointments.Name = "appointments";
            this.appointments.Padding = new System.Windows.Forms.Padding(3);
            this.appointments.Size = new System.Drawing.Size(1013, 421);
            this.appointments.TabIndex = 0;
            this.appointments.Text = "Appointments";
            this.appointments.UseVisualStyleBackColor = true;
            // 
            // ucPatientAppointments
            // 
            this.ucPatientAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPatientAppointments.Location = new System.Drawing.Point(3, 3);
            this.ucPatientAppointments.Name = "ucPatientAppointments";
            this.ucPatientAppointments.Size = new System.Drawing.Size(1007, 415);
            this.ucPatientAppointments.TabIndex = 0;
            // 
            // tabVisits
            // 
            this.tabVisits.Controls.Add(this.visitsUserControl);
            this.tabVisits.Location = new System.Drawing.Point(4, 25);
            this.tabVisits.Name = "tabVisits";
            this.tabVisits.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisits.Size = new System.Drawing.Size(1013, 421);
            this.tabVisits.TabIndex = 1;
            this.tabVisits.Text = "Visits";
            this.tabVisits.UseVisualStyleBackColor = true;
            // 
            // visitsUserControl
            // 
            this.visitsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitsUserControl.Location = new System.Drawing.Point(3, 3);
            this.visitsUserControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.visitsUserControl.Name = "visitsUserControl";
            this.visitsUserControl.Size = new System.Drawing.Size(1007, 415);
            this.visitsUserControl.TabIndex = 0;
            // 
            // PatientTabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 450);
            this.Controls.Add(this.tbPatientInfo);
            this.Name = "PatientTabsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientTabsForm";
            this.tbPatientInfo.ResumeLayout(false);
            this.appointments.ResumeLayout(false);
            this.tabVisits.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbPatientInfo;
        private System.Windows.Forms.TabPage appointments;
        private UserControls.ucPatientAppointments ucPatientAppointments;
        private System.Windows.Forms.TabPage tabVisits;
        private UserControls.VisitsUserControl visitsUserControl;
    }
}