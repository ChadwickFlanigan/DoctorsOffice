﻿namespace CS6232_G2.View
{
    partial class SearchPatientForm
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
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.PatientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.firstLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.dobRadioButton = new System.Windows.Forms.RadioButton();
            this.dobLastnameradioButton = new System.Windows.Forms.RadioButton();
            this.patientLabel = new System.Windows.Forms.Label();
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.patientDetailsLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.fLabel = new System.Windows.Forms.Label();
            this.lLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lnkLogout = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.AllowUserToResizeColumns = false;
            this.appointmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientId,
            this.colFirtName,
            this.colLastName,
            this.colDOB});
            this.searchTableLayoutPanel.SetColumnSpan(this.appointmentDataGridView, 3);
            this.appointmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentDataGridView.Location = new System.Drawing.Point(3, 248);
            this.appointmentDataGridView.MultiSelect = false;
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDataGridView.Size = new System.Drawing.Size(794, 165);
            this.appointmentDataGridView.TabIndex = 18;
            this.appointmentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellClick);
            // 
            // PatientId
            // 
            this.PatientId.DataPropertyName = "PatientId";
            this.PatientId.HeaderText = "PatientId";
            this.PatientId.Name = "PatientId";
            this.PatientId.ReadOnly = true;
            // 
            // colFirtName
            // 
            this.colFirtName.DataPropertyName = "FirstName";
            this.colFirtName.HeaderText = "First Name";
            this.colFirtName.Name = "colFirtName";
            this.colFirtName.ReadOnly = true;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colDOB
            // 
            this.colDOB.DataPropertyName = "DOB";
            this.colDOB.HeaderText = "Date of Birth";
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(3, 2);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(274, 16);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search Patient Information";
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatient.Location = new System.Drawing.Point(3, 419);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(274, 27);
            this.btnViewPatient.TabIndex = 13;
            this.btnViewPatient.Text = "View Patient";
            this.btnViewPatient.UseVisualStyleBackColor = true;
            this.btnViewPatient.Click += new System.EventHandler(this.btnViewPatient_Click);
            // 
            // firstLastNameRadioButton
            // 
            this.firstLastNameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstLastNameRadioButton.AutoSize = true;
            this.firstLastNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLastNameRadioButton.Location = new System.Drawing.Point(3, 50);
            this.firstLastNameRadioButton.Name = "firstLastNameRadioButton";
            this.firstLastNameRadioButton.Size = new System.Drawing.Size(274, 17);
            this.firstLastNameRadioButton.TabIndex = 0;
            this.firstLastNameRadioButton.TabStop = true;
            this.firstLastNameRadioButton.Text = "First name and Last name";
            this.firstLastNameRadioButton.UseVisualStyleBackColor = true;
            this.firstLastNameRadioButton.CheckedChanged += new System.EventHandler(this.firstLastNameRadioButton_CheckedChanged);
            // 
            // dobRadioButton
            // 
            this.dobRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dobRadioButton.AutoSize = true;
            this.dobRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobRadioButton.Location = new System.Drawing.Point(283, 50);
            this.dobRadioButton.Name = "dobRadioButton";
            this.dobRadioButton.Size = new System.Drawing.Size(274, 17);
            this.dobRadioButton.TabIndex = 1;
            this.dobRadioButton.TabStop = true;
            this.dobRadioButton.Text = "Date of Birth";
            this.dobRadioButton.UseVisualStyleBackColor = true;
            this.dobRadioButton.CheckedChanged += new System.EventHandler(this.dobRadioButton_CheckedChanged);
            // 
            // dobLastnameradioButton
            // 
            this.dobLastnameradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dobLastnameradioButton.AutoSize = true;
            this.dobLastnameradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLastnameradioButton.Location = new System.Drawing.Point(563, 50);
            this.dobLastnameradioButton.Name = "dobLastnameradioButton";
            this.dobLastnameradioButton.Size = new System.Drawing.Size(234, 17);
            this.dobLastnameradioButton.TabIndex = 2;
            this.dobLastnameradioButton.TabStop = true;
            this.dobLastnameradioButton.Text = "Date of Birth and Last name";
            this.dobLastnameradioButton.UseVisualStyleBackColor = true;
            this.dobLastnameradioButton.CheckedChanged += new System.EventHandler(this.dobLastnameradioButton_CheckedChanged);
            // 
            // patientLabel
            // 
            this.patientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(563, 192);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(234, 26);
            this.patientLabel.TabIndex = 9;
            this.patientLabel.Text = "(Click patient name to edit or update patient information)";
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 3;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchTableLayoutPanel.Controls.Add(this.appointmentDataGridView, 0, 8);
            this.searchTableLayoutPanel.Controls.Add(this.searchLabel, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.patientDetailsLabel, 0, 7);
            this.searchTableLayoutPanel.Controls.Add(this.firstLastNameRadioButton, 0, 2);
            this.searchTableLayoutPanel.Controls.Add(this.dobRadioButton, 1, 2);
            this.searchTableLayoutPanel.Controls.Add(this.dobLastnameradioButton, 2, 2);
            this.searchTableLayoutPanel.Controls.Add(this.patientLabel, 2, 6);
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 2, 5);
            this.searchTableLayoutPanel.Controls.Add(this.clearButton, 2, 4);
            this.searchTableLayoutPanel.Controls.Add(this.dateTimePicker, 1, 5);
            this.searchTableLayoutPanel.Controls.Add(this.lastNameTextBox, 1, 4);
            this.searchTableLayoutPanel.Controls.Add(this.firstNameTextBox, 1, 3);
            this.searchTableLayoutPanel.Controls.Add(this.fLabel, 0, 3);
            this.searchTableLayoutPanel.Controls.Add(this.lLabel, 0, 4);
            this.searchTableLayoutPanel.Controls.Add(this.dateLabel, 0, 5);
            this.searchTableLayoutPanel.Controls.Add(this.btnAddPatient, 2, 9);
            this.searchTableLayoutPanel.Controls.Add(this.lblUsername, 2, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lnkLogout, 1, 0);
            this.searchTableLayoutPanel.Controls.Add(this.lblName, 2, 1);
            this.searchTableLayoutPanel.Controls.Add(this.btnDeletePatient, 1, 9);
            this.searchTableLayoutPanel.Controls.Add(this.btnViewPatient, 0, 9);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 10;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.619048F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.619048F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.619048F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.571428F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761905F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.searchTableLayoutPanel.TabIndex = 1;
            // 
            // patientDetailsLabel
            // 
            this.patientDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.patientDetailsLabel.AutoSize = true;
            this.patientDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDetailsLabel.Location = new System.Drawing.Point(3, 228);
            this.patientDetailsLabel.Name = "patientDetailsLabel";
            this.patientDetailsLabel.Size = new System.Drawing.Size(274, 13);
            this.patientDetailsLabel.TabIndex = 11;
            this.patientDetailsLabel.Text = "Patient appointment Information : ";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(563, 153);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(234, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Enabled = false;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(563, 115);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(234, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(283, 155);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(274, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(283, 117);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(283, 83);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // fLabel
            // 
            this.fLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fLabel.AutoSize = true;
            this.fLabel.Location = new System.Drawing.Point(3, 86);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(274, 13);
            this.fLabel.TabIndex = 16;
            this.fLabel.Text = "First Name:";
            // 
            // lLabel
            // 
            this.lLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lLabel.AutoSize = true;
            this.lLabel.Location = new System.Drawing.Point(3, 120);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(274, 13);
            this.lLabel.TabIndex = 17;
            this.lLabel.Text = "Last Name:";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 158);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(274, 13);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "Date:";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Location = new System.Drawing.Point(563, 419);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(234, 27);
            this.btnAddPatient.TabIndex = 13;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblUsername.Location = new System.Drawing.Point(742, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 19;
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
            this.lnkLogout.TabIndex = 20;
            this.lnkLogout.TabStop = true;
            this.lnkLogout.Text = "Logout";
            this.lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.lblName.Location = new System.Drawing.Point(742, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePatient.Location = new System.Drawing.Point(283, 419);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(274, 27);
            this.btnDeletePatient.TabIndex = 22;
            this.btnDeletePatient.Text = "Delete Patient";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // SearchPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTableLayoutPanel);
            this.Name = "SearchPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NurseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchPatient_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label patientDetailsLabel;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.RadioButton firstLastNameRadioButton;
        private System.Windows.Forms.RadioButton dobRadioButton;
        private System.Windows.Forms.RadioButton dobLastnameradioButton;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Label lLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.LinkLabel lnkLogout;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDeletePatient;
    }
}