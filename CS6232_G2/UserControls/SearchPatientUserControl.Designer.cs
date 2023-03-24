namespace CS6232_G2.UserControls
{
    partial class SearchPatientUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.colFirtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchLabel = new System.Windows.Forms.Label();
            this.patientDetailsLabel = new System.Windows.Forms.Label();
            this.btnViewPatient = new System.Windows.Forms.Button();
            this.firstLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.dobRadioButton = new System.Windows.Forms.RadioButton();
            this.dobLastnameradioButton = new System.Windows.Forms.RadioButton();
            this.patientLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.fLabel = new System.Windows.Forms.Label();
            this.lLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.searchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 3;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchTableLayoutPanel.Controls.Add(this.appointmentDataGridView, 0, 7);
            this.searchTableLayoutPanel.Controls.Add(this.searchLabel, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.patientDetailsLabel, 0, 6);
            this.searchTableLayoutPanel.Controls.Add(this.btnViewPatient, 1, 8);
            this.searchTableLayoutPanel.Controls.Add(this.firstLastNameRadioButton, 0, 1);
            this.searchTableLayoutPanel.Controls.Add(this.dobRadioButton, 1, 1);
            this.searchTableLayoutPanel.Controls.Add(this.dobLastnameradioButton, 2, 1);
            this.searchTableLayoutPanel.Controls.Add(this.patientLabel, 2, 5);
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 2, 4);
            this.searchTableLayoutPanel.Controls.Add(this.clearButton, 2, 3);
            this.searchTableLayoutPanel.Controls.Add(this.dateTimePicker, 1, 4);
            this.searchTableLayoutPanel.Controls.Add(this.lastNameTextBox, 1, 3);
            this.searchTableLayoutPanel.Controls.Add(this.firstNameTextBox, 1, 2);
            this.searchTableLayoutPanel.Controls.Add(this.fLabel, 0, 2);
            this.searchTableLayoutPanel.Controls.Add(this.lLabel, 0, 3);
            this.searchTableLayoutPanel.Controls.Add(this.dateLabel, 0, 4);
            this.searchTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.searchTableLayoutPanel.Name = "searchTableLayoutPanel";
            this.searchTableLayoutPanel.RowCount = 9;
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(542, 386);
            this.searchTableLayoutPanel.TabIndex = 0;
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.AllowUserToAddRows = false;
            this.appointmentDataGridView.AllowUserToDeleteRows = false;
            this.appointmentDataGridView.AllowUserToOrderColumns = true;
            this.appointmentDataGridView.AllowUserToResizeColumns = false;
            this.appointmentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirtName,
            this.colLastName,
            this.colDOB});
            this.searchTableLayoutPanel.SetColumnSpan(this.appointmentDataGridView, 3);
            this.appointmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentDataGridView.Location = new System.Drawing.Point(3, 203);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.ReadOnly = true;
            this.appointmentDataGridView.Size = new System.Drawing.Size(536, 148);
            this.appointmentDataGridView.TabIndex = 18;
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
            this.searchLabel.Location = new System.Drawing.Point(3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(183, 19);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search Patient Information";
            // 
            // patientDetailsLabel
            // 
            this.patientDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.patientDetailsLabel.AutoSize = true;
            this.patientDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDetailsLabel.Location = new System.Drawing.Point(3, 181);
            this.patientDetailsLabel.Name = "patientDetailsLabel";
            this.patientDetailsLabel.Size = new System.Drawing.Size(183, 19);
            this.patientDetailsLabel.TabIndex = 11;
            this.patientDetailsLabel.Text = "Patient appointment Information : ";
            // 
            // btnViewPatient
            // 
            this.btnViewPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPatient.Location = new System.Drawing.Point(192, 360);
            this.btnViewPatient.Name = "btnViewPatient";
            this.btnViewPatient.Size = new System.Drawing.Size(183, 20);
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
            this.firstLastNameRadioButton.Location = new System.Drawing.Point(3, 25);
            this.firstLastNameRadioButton.Name = "firstLastNameRadioButton";
            this.firstLastNameRadioButton.Size = new System.Drawing.Size(183, 17);
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
            this.dobRadioButton.Location = new System.Drawing.Point(192, 25);
            this.dobRadioButton.Name = "dobRadioButton";
            this.dobRadioButton.Size = new System.Drawing.Size(183, 17);
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
            this.dobLastnameradioButton.Location = new System.Drawing.Point(381, 25);
            this.dobLastnameradioButton.Name = "dobLastnameradioButton";
            this.dobLastnameradioButton.Size = new System.Drawing.Size(158, 17);
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
            this.patientLabel.Location = new System.Drawing.Point(381, 151);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(158, 26);
            this.patientLabel.TabIndex = 9;
            this.patientLabel.Text = "(Click patient name to edit or update patient information)";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Enabled = false;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(381, 116);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(158, 23);
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
            this.clearButton.Location = new System.Drawing.Point(381, 82);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(158, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(192, 118);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(183, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Enabled = false;
            this.lastNameTextBox.Location = new System.Drawing.Point(192, 84);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Enabled = false;
            this.firstNameTextBox.Location = new System.Drawing.Point(192, 54);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(183, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // fLabel
            // 
            this.fLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fLabel.AutoSize = true;
            this.fLabel.Location = new System.Drawing.Point(3, 57);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(183, 13);
            this.fLabel.TabIndex = 16;
            this.fLabel.Text = "First Name:";
            // 
            // lLabel
            // 
            this.lLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lLabel.AutoSize = true;
            this.lLabel.Location = new System.Drawing.Point(3, 87);
            this.lLabel.Name = "lLabel";
            this.lLabel.Size = new System.Drawing.Size(183, 13);
            this.lLabel.TabIndex = 17;
            this.lLabel.Text = "Last Name:";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(3, 121);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(183, 13);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "Date:";
            // 
            // SearchPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchTableLayoutPanel);
            this.Name = "SearchPatientUserControl";
            this.Size = new System.Drawing.Size(542, 386);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel searchTableLayoutPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.RadioButton dobRadioButton;
        private System.Windows.Forms.RadioButton firstLastNameRadioButton;
        private System.Windows.Forms.RadioButton dobLastnameradioButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label patientDetailsLabel;
        private System.Windows.Forms.Button btnViewPatient;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Label lLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
    }
}
