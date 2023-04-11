﻿namespace CS6232_G2.View
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
            this.visits = new System.Windows.Forms.TabPage();
            this.visitsUserControl = new CS6232_G2.UserControls.VisitsUserControl();
            this.labTests = new System.Windows.Forms.TabPage();
            this.ucSearchTest = new CS6232_G2.UserControls.ucSearchTest();
            this.tbPatientInfo.SuspendLayout();
            this.appointments.SuspendLayout();
            this.visits.SuspendLayout();
            this.labTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPatientInfo
            // 
            this.tbPatientInfo.Controls.Add(this.appointments);
            this.tbPatientInfo.Controls.Add(this.visits);
            this.tbPatientInfo.Controls.Add(this.labTests);
            this.tbPatientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPatientInfo.Location = new System.Drawing.Point(0, 0);
            this.tbPatientInfo.Name = "tbPatientInfo";
            this.tbPatientInfo.SelectedIndex = 0;
            this.tbPatientInfo.Size = new System.Drawing.Size(800, 450);
            this.tbPatientInfo.TabIndex = 0;
            // 
            // appointments
            // 
            this.appointments.Controls.Add(this.ucPatientAppointments);
            this.appointments.Location = new System.Drawing.Point(4, 22);
            this.appointments.Name = "appointments";
            this.appointments.Padding = new System.Windows.Forms.Padding(3);
            this.appointments.Size = new System.Drawing.Size(792, 424);
            this.appointments.TabIndex = 0;
            this.appointments.Text = "Appointments";
            this.appointments.UseVisualStyleBackColor = true;
            // 
            // ucPatientAppointments
            // 
            this.ucPatientAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPatientAppointments.Location = new System.Drawing.Point(3, 3);
            this.ucPatientAppointments.Name = "ucPatientAppointments";
            this.ucPatientAppointments.Size = new System.Drawing.Size(786, 418);
            this.ucPatientAppointments.TabIndex = 0;
            // 
            // visits
            // 
            this.visits.Controls.Add(this.visitsUserControl);
            this.visits.Location = new System.Drawing.Point(4, 22);
            this.visits.Name = "visits";
            this.visits.Padding = new System.Windows.Forms.Padding(3);
            this.visits.Size = new System.Drawing.Size(792, 424);
            this.visits.TabIndex = 1;
            this.visits.Text = "Visits";
            this.visits.UseVisualStyleBackColor = true;
            // 
            // visitsUserControl
            // 
            this.visitsUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visitsUserControl.Location = new System.Drawing.Point(3, 3);
            this.visitsUserControl.Name = "visitsUserControl";
            this.visitsUserControl.Size = new System.Drawing.Size(186, 68);
            this.visitsUserControl.TabIndex = 0;
            // 
            // labTests
            // 
            this.labTests.Controls.Add(this.ucSearchTest);
            this.labTests.Location = new System.Drawing.Point(4, 22);
            this.labTests.Name = "labTests";
            this.labTests.Size = new System.Drawing.Size(792, 424);
            this.labTests.TabIndex = 2;
            this.labTests.Text = "LabTests";
            this.labTests.UseVisualStyleBackColor = true;
            // 
            // ucSearchTest
            // 
            this.ucSearchTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearchTest.Location = new System.Drawing.Point(0, 0);
            this.ucSearchTest.Name = "ucSearchTest";
            this.ucSearchTest.Size = new System.Drawing.Size(792, 424);
            this.ucSearchTest.TabIndex = 0;
            // 
            // PatientTabsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPatientInfo);
            this.Name = "PatientTabsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientTabsForm";
            this.tbPatientInfo.ResumeLayout(false);
            this.appointments.ResumeLayout(false);
            this.visits.ResumeLayout(false);
            this.labTests.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbPatientInfo;
        private System.Windows.Forms.TabPage appointments;
        private System.Windows.Forms.TabPage visits;
        private System.Windows.Forms.TabPage labTests;
        private UserControls.ucSearchTest ucSearchTest;
        private UserControls.VisitsUserControl visitsUserControl;
        private UserControls.ucPatientAppointments ucPatientAppointments;
    }
}