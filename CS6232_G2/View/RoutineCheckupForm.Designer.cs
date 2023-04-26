namespace CS6232_G2.View
{
    partial class RoutineCheckupForm
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
            this.components = new System.ComponentModel.Container();
            this.routineTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxVisitTime = new System.Windows.Forms.TextBox();
            this.textBoxPatAddress = new System.Windows.Forms.TextBox();
            this.textBoxNurName = new System.Windows.Forms.TextBox();
            this.textBoxPatDOB = new System.Windows.Forms.TextBox();
            this.textBoxDocName = new System.Windows.Forms.TextBox();
            this.labelPatient = new System.Windows.Forms.Label();
            this.testDataGridView = new System.Windows.Forms.DataGridView();
            this.TestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Normal = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.saveVisitButton = new System.Windows.Forms.Button();
            this.lblSaveFirst = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.fDiagnosesTextBox = new System.Windows.Forms.TextBox();
            this.iDiagnosisTextBox = new System.Windows.Forms.TextBox();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.pulseTextBox = new System.Windows.Forms.TextBox();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.diaTextBox = new System.Windows.Forms.TextBox();
            this.sysTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.poundLabel = new System.Windows.Forms.Label();
            this.inchLabel = new System.Windows.Forms.Label();
            this.fDiagnosesLabel = new System.Windows.Forms.Label();
            this.idiagnosisLabel = new System.Windows.Forms.Label();
            this.symptomsLabel = new System.Windows.Forms.Label();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.diaLabel = new System.Windows.Forms.Label();
            this.syslabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.labelDoc = new System.Windows.Forms.Label();
            this.labelNurse = new System.Windows.Forms.Label();
            this.labelPatDOB = new System.Windows.Forms.Label();
            this.labelPatAdd = new System.Windows.Forms.Label();
            this.labelVisit = new System.Windows.Forms.Label();
            this.textBoxPatName = new System.Windows.Forms.TextBox();
            this.selectLabTestComboBox = new System.Windows.Forms.ComboBox();
            this.addTestButton = new System.Windows.Forms.Button();
            this.submitLabOrderButton = new System.Windows.Forms.Button();
            this.removeTestButton = new System.Windows.Forms.Button();
            this.updateTestButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.labelTemp = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routineTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // routineTableLayoutPanel
            // 
            this.routineTableLayoutPanel.ColumnCount = 4;
            this.routineTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.routineTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.routineTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.routineTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.routineTableLayoutPanel.Controls.Add(this.textBoxVisitTime, 3, 2);
            this.routineTableLayoutPanel.Controls.Add(this.textBoxPatAddress, 1, 2);
            this.routineTableLayoutPanel.Controls.Add(this.textBoxNurName, 3, 1);
            this.routineTableLayoutPanel.Controls.Add(this.textBoxPatDOB, 1, 1);
            this.routineTableLayoutPanel.Controls.Add(this.textBoxDocName, 3, 0);
            this.routineTableLayoutPanel.Controls.Add(this.labelPatient, 0, 0);
            this.routineTableLayoutPanel.Controls.Add(this.testDataGridView, 0, 13);
            this.routineTableLayoutPanel.Controls.Add(this.saveVisitButton, 1, 19);
            this.routineTableLayoutPanel.Controls.Add(this.lblSaveFirst, 0, 19);
            this.routineTableLayoutPanel.Controls.Add(this.errorLabel, 2, 18);
            this.routineTableLayoutPanel.Controls.Add(this.fDiagnosesTextBox, 1, 12);
            this.routineTableLayoutPanel.Controls.Add(this.iDiagnosisTextBox, 1, 11);
            this.routineTableLayoutPanel.Controls.Add(this.symptomsTextBox, 1, 10);
            this.routineTableLayoutPanel.Controls.Add(this.pulseTextBox, 1, 9);
            this.routineTableLayoutPanel.Controls.Add(this.tempTextBox, 1, 8);
            this.routineTableLayoutPanel.Controls.Add(this.diaTextBox, 1, 7);
            this.routineTableLayoutPanel.Controls.Add(this.sysTextBox, 1, 6);
            this.routineTableLayoutPanel.Controls.Add(this.weightTextBox, 1, 5);
            this.routineTableLayoutPanel.Controls.Add(this.heightTextBox, 1, 4);
            this.routineTableLayoutPanel.Controls.Add(this.poundLabel, 2, 5);
            this.routineTableLayoutPanel.Controls.Add(this.inchLabel, 2, 4);
            this.routineTableLayoutPanel.Controls.Add(this.fDiagnosesLabel, 0, 12);
            this.routineTableLayoutPanel.Controls.Add(this.idiagnosisLabel, 0, 11);
            this.routineTableLayoutPanel.Controls.Add(this.symptomsLabel, 0, 10);
            this.routineTableLayoutPanel.Controls.Add(this.pulseLabel, 0, 9);
            this.routineTableLayoutPanel.Controls.Add(this.tempLabel, 0, 8);
            this.routineTableLayoutPanel.Controls.Add(this.weightLabel, 0, 5);
            this.routineTableLayoutPanel.Controls.Add(this.diaLabel, 0, 7);
            this.routineTableLayoutPanel.Controls.Add(this.syslabel, 0, 6);
            this.routineTableLayoutPanel.Controls.Add(this.heightLabel, 0, 4);
            this.routineTableLayoutPanel.Controls.Add(this.labelDoc, 2, 0);
            this.routineTableLayoutPanel.Controls.Add(this.labelNurse, 2, 1);
            this.routineTableLayoutPanel.Controls.Add(this.labelPatDOB, 0, 1);
            this.routineTableLayoutPanel.Controls.Add(this.labelPatAdd, 0, 2);
            this.routineTableLayoutPanel.Controls.Add(this.labelVisit, 2, 2);
            this.routineTableLayoutPanel.Controls.Add(this.textBoxPatName, 1, 0);
            this.routineTableLayoutPanel.Controls.Add(this.selectLabTestComboBox, 3, 14);
            this.routineTableLayoutPanel.Controls.Add(this.addTestButton, 3, 15);
            this.routineTableLayoutPanel.Controls.Add(this.submitLabOrderButton, 3, 16);
            this.routineTableLayoutPanel.Controls.Add(this.removeTestButton, 3, 17);
            this.routineTableLayoutPanel.Controls.Add(this.updateTestButton, 3, 19);
            this.routineTableLayoutPanel.Controls.Add(this.cancelButton, 3, 20);
            this.routineTableLayoutPanel.Controls.Add(this.labelTemp, 2, 8);
            this.routineTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routineTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.routineTableLayoutPanel.Name = "routineTableLayoutPanel";
            this.routineTableLayoutPanel.RowCount = 21;
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.761907F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.838391F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.848073F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.848073F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.741574F));
            this.routineTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.838391F));
            this.routineTableLayoutPanel.Size = new System.Drawing.Size(880, 632);
            this.routineTableLayoutPanel.TabIndex = 0;
            // 
            // textBoxVisitTime
            // 
            this.textBoxVisitTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVisitTime.Enabled = false;
            this.textBoxVisitTime.Location = new System.Drawing.Point(707, 63);
            this.textBoxVisitTime.Name = "textBoxVisitTime";
            this.textBoxVisitTime.Size = new System.Drawing.Size(170, 20);
            this.textBoxVisitTime.TabIndex = 44;
            // 
            // textBoxPatAddress
            // 
            this.textBoxPatAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatAddress.Enabled = false;
            this.textBoxPatAddress.Location = new System.Drawing.Point(179, 63);
            this.textBoxPatAddress.Name = "textBoxPatAddress";
            this.textBoxPatAddress.Size = new System.Drawing.Size(346, 20);
            this.textBoxPatAddress.TabIndex = 43;
            // 
            // textBoxNurName
            // 
            this.textBoxNurName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNurName.Enabled = false;
            this.textBoxNurName.Location = new System.Drawing.Point(707, 34);
            this.textBoxNurName.Name = "textBoxNurName";
            this.textBoxNurName.Size = new System.Drawing.Size(170, 20);
            this.textBoxNurName.TabIndex = 42;
            // 
            // textBoxPatDOB
            // 
            this.textBoxPatDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatDOB.Enabled = false;
            this.textBoxPatDOB.Location = new System.Drawing.Point(179, 34);
            this.textBoxPatDOB.Name = "textBoxPatDOB";
            this.textBoxPatDOB.Size = new System.Drawing.Size(346, 20);
            this.textBoxPatDOB.TabIndex = 41;
            // 
            // textBoxDocName
            // 
            this.textBoxDocName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDocName.Enabled = false;
            this.textBoxDocName.Location = new System.Drawing.Point(707, 5);
            this.textBoxDocName.Name = "textBoxDocName";
            this.textBoxDocName.Size = new System.Drawing.Size(170, 20);
            this.textBoxDocName.TabIndex = 40;
            // 
            // labelPatient
            // 
            this.labelPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPatient.AutoSize = true;
            this.labelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatient.Location = new System.Drawing.Point(3, 8);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(170, 13);
            this.labelPatient.TabIndex = 35;
            this.labelPatient.Text = "Patient Name(ID):";
            // 
            // testDataGridView
            // 
            this.testDataGridView.AllowUserToAddRows = false;
            this.testDataGridView.AllowUserToDeleteRows = false;
            this.testDataGridView.AutoGenerateColumns = false;
            this.testDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.TestName,
            this.dataGridViewTextBoxColumn5,
            this.Result,
            this.Normal});
            this.routineTableLayoutPanel.SetColumnSpan(this.testDataGridView, 3);
            this.testDataGridView.DataSource = this.labTestBindingSource;
            this.testDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testDataGridView.Location = new System.Drawing.Point(3, 382);
            this.testDataGridView.Name = "testDataGridView";
            this.routineTableLayoutPanel.SetRowSpan(this.testDataGridView, 6);
            this.testDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.testDataGridView.Size = new System.Drawing.Size(698, 170);
            this.testDataGridView.TabIndex = 27;
            this.testDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.testDataGridView_DataError);
            this.testDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.testDataGridView_RowEnter);
            // 
            // TestName
            // 
            this.TestName.DataPropertyName = "TestName";
            this.TestName.HeaderText = "TestName";
            this.TestName.Name = "TestName";
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // Normal
            // 
            this.Normal.DataPropertyName = "Normal";
            this.Normal.HeaderText = "Normal";
            this.Normal.Name = "Normal";
            this.Normal.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Normal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // saveVisitButton
            // 
            this.saveVisitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.saveVisitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveVisitButton.Location = new System.Drawing.Point(179, 558);
            this.saveVisitButton.Name = "saveVisitButton";
            this.saveVisitButton.Size = new System.Drawing.Size(346, 22);
            this.saveVisitButton.TabIndex = 14;
            this.saveVisitButton.Text = "Save Visit";
            this.saveVisitButton.UseVisualStyleBackColor = true;
            this.saveVisitButton.Click += new System.EventHandler(this.saveVisitButton_Click);
            // 
            // lblSaveFirst
            // 
            this.lblSaveFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaveFirst.AutoSize = true;
            this.lblSaveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSaveFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveFirst.ForeColor = System.Drawing.Color.White;
            this.lblSaveFirst.Location = new System.Drawing.Point(3, 577);
            this.lblSaveFirst.Name = "lblSaveFirst";
            this.routineTableLayoutPanel.SetRowSpan(this.lblSaveFirst, 2);
            this.lblSaveFirst.Size = new System.Drawing.Size(170, 32);
            this.lblSaveFirst.TabIndex = 28;
            this.lblSaveFirst.Text = "Save Visit Before Adding Labs";
            this.lblSaveFirst.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(707, 533);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(170, 13);
            this.errorLabel.TabIndex = 22;
            // 
            // fDiagnosesTextBox
            // 
            this.fDiagnosesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fDiagnosesTextBox.Location = new System.Drawing.Point(179, 354);
            this.fDiagnosesTextBox.Name = "fDiagnosesTextBox";
            this.fDiagnosesTextBox.Size = new System.Drawing.Size(346, 20);
            this.fDiagnosesTextBox.TabIndex = 9;
            // 
            // iDiagnosisTextBox
            // 
            this.iDiagnosisTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iDiagnosisTextBox.Location = new System.Drawing.Point(179, 325);
            this.iDiagnosisTextBox.Name = "iDiagnosisTextBox";
            this.iDiagnosisTextBox.Size = new System.Drawing.Size(346, 20);
            this.iDiagnosisTextBox.TabIndex = 8;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsTextBox.Location = new System.Drawing.Point(179, 295);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(346, 20);
            this.symptomsTextBox.TabIndex = 7;
            // 
            // pulseTextBox
            // 
            this.pulseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseTextBox.Location = new System.Drawing.Point(179, 266);
            this.pulseTextBox.MaxLength = 3;
            this.pulseTextBox.Name = "pulseTextBox";
            this.pulseTextBox.Size = new System.Drawing.Size(346, 20);
            this.pulseTextBox.TabIndex = 6;
            this.pulseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pulseTextBox_KeyPress);
            // 
            // tempTextBox
            // 
            this.tempTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tempTextBox.Location = new System.Drawing.Point(179, 237);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(346, 20);
            this.tempTextBox.TabIndex = 5;
            this.tempTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempTextBox_KeyPress);
            // 
            // diaTextBox
            // 
            this.diaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diaTextBox.Location = new System.Drawing.Point(179, 208);
            this.diaTextBox.MaxLength = 3;
            this.diaTextBox.Name = "diaTextBox";
            this.diaTextBox.Size = new System.Drawing.Size(346, 20);
            this.diaTextBox.TabIndex = 4;
            this.diaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diaTextBox_KeyPress);
            // 
            // sysTextBox
            // 
            this.sysTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.sysTextBox.Location = new System.Drawing.Point(179, 179);
            this.sysTextBox.MaxLength = 3;
            this.sysTextBox.Name = "sysTextBox";
            this.sysTextBox.Size = new System.Drawing.Size(346, 20);
            this.sysTextBox.TabIndex = 3;
            this.sysTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sysTextBox_KeyPress);
            // 
            // weightTextBox
            // 
            this.weightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weightTextBox.Location = new System.Drawing.Point(179, 150);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(346, 20);
            this.weightTextBox.TabIndex = 2;
            this.weightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightTextBox_KeyPress);
            // 
            // heightTextBox
            // 
            this.heightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.heightTextBox.Location = new System.Drawing.Point(179, 121);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(346, 20);
            this.heightTextBox.TabIndex = 1;
            this.heightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.heightTextBox_KeyPress);
            // 
            // poundLabel
            // 
            this.poundLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.poundLabel.AutoSize = true;
            this.poundLabel.Location = new System.Drawing.Point(531, 154);
            this.poundLabel.Name = "poundLabel";
            this.poundLabel.Size = new System.Drawing.Size(170, 13);
            this.poundLabel.TabIndex = 5;
            this.poundLabel.Text = "pound";
            // 
            // inchLabel
            // 
            this.inchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.inchLabel.AutoSize = true;
            this.inchLabel.Location = new System.Drawing.Point(531, 125);
            this.inchLabel.Name = "inchLabel";
            this.inchLabel.Size = new System.Drawing.Size(170, 13);
            this.inchLabel.TabIndex = 2;
            this.inchLabel.Text = "inches";
            // 
            // fDiagnosesLabel
            // 
            this.fDiagnosesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fDiagnosesLabel.AutoSize = true;
            this.fDiagnosesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fDiagnosesLabel.Location = new System.Drawing.Point(3, 358);
            this.fDiagnosesLabel.Name = "fDiagnosesLabel";
            this.fDiagnosesLabel.Size = new System.Drawing.Size(170, 13);
            this.fDiagnosesLabel.TabIndex = 20;
            this.fDiagnosesLabel.Text = "Final Diagnoses:";
            this.fDiagnosesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idiagnosisLabel
            // 
            this.idiagnosisLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.idiagnosisLabel.AutoSize = true;
            this.idiagnosisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idiagnosisLabel.Location = new System.Drawing.Point(3, 328);
            this.idiagnosisLabel.Name = "idiagnosisLabel";
            this.idiagnosisLabel.Size = new System.Drawing.Size(170, 13);
            this.idiagnosisLabel.TabIndex = 19;
            this.idiagnosisLabel.Text = "Initial Diagnosis:";
            this.idiagnosisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // symptomsLabel
            // 
            this.symptomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.symptomsLabel.AutoSize = true;
            this.symptomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptomsLabel.Location = new System.Drawing.Point(3, 299);
            this.symptomsLabel.Name = "symptomsLabel";
            this.symptomsLabel.Size = new System.Drawing.Size(170, 13);
            this.symptomsLabel.TabIndex = 18;
            this.symptomsLabel.Text = "Symptoms:";
            this.symptomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pulseLabel
            // 
            this.pulseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pulseLabel.AutoSize = true;
            this.pulseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pulseLabel.Location = new System.Drawing.Point(3, 270);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(170, 13);
            this.pulseLabel.TabIndex = 16;
            this.pulseLabel.Text = "Pulse:";
            this.pulseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tempLabel
            // 
            this.tempLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(3, 241);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(170, 13);
            this.tempLabel.TabIndex = 12;
            this.tempLabel.Text = "Body Temprature:";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLabel.Location = new System.Drawing.Point(3, 154);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(170, 13);
            this.weightLabel.TabIndex = 3;
            this.weightLabel.Text = "Weight:";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // diaLabel
            // 
            this.diaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.diaLabel.AutoSize = true;
            this.diaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaLabel.Location = new System.Drawing.Point(3, 212);
            this.diaLabel.Name = "diaLabel";
            this.diaLabel.Size = new System.Drawing.Size(170, 13);
            this.diaLabel.TabIndex = 30;
            this.diaLabel.Text = "BP diastolic:";
            // 
            // syslabel
            // 
            this.syslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.syslabel.AutoSize = true;
            this.syslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syslabel.Location = new System.Drawing.Point(3, 183);
            this.syslabel.Name = "syslabel";
            this.syslabel.Size = new System.Drawing.Size(170, 13);
            this.syslabel.TabIndex = 31;
            this.syslabel.Text = "BP systolic:";
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightLabel.Location = new System.Drawing.Point(3, 125);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(170, 13);
            this.heightLabel.TabIndex = 32;
            this.heightLabel.Text = "Height:";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDoc
            // 
            this.labelDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDoc.AutoSize = true;
            this.labelDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDoc.Location = new System.Drawing.Point(531, 8);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(170, 13);
            this.labelDoc.TabIndex = 33;
            this.labelDoc.Text = "Doctor Name(ID):";
            // 
            // labelNurse
            // 
            this.labelNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNurse.AutoSize = true;
            this.labelNurse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNurse.Location = new System.Drawing.Point(531, 38);
            this.labelNurse.Name = "labelNurse";
            this.labelNurse.Size = new System.Drawing.Size(170, 13);
            this.labelNurse.TabIndex = 34;
            this.labelNurse.Text = "Nurse Name(ID):";
            // 
            // labelPatDOB
            // 
            this.labelPatDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPatDOB.AutoSize = true;
            this.labelPatDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatDOB.Location = new System.Drawing.Point(3, 38);
            this.labelPatDOB.Name = "labelPatDOB";
            this.labelPatDOB.Size = new System.Drawing.Size(170, 13);
            this.labelPatDOB.TabIndex = 36;
            this.labelPatDOB.Text = "Patient DOB:";
            // 
            // labelPatAdd
            // 
            this.labelPatAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPatAdd.AutoSize = true;
            this.labelPatAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPatAdd.Location = new System.Drawing.Point(3, 67);
            this.labelPatAdd.Name = "labelPatAdd";
            this.labelPatAdd.Size = new System.Drawing.Size(170, 13);
            this.labelPatAdd.TabIndex = 37;
            this.labelPatAdd.Text = "Patient Address:";
            // 
            // labelVisit
            // 
            this.labelVisit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVisit.AutoSize = true;
            this.labelVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVisit.Location = new System.Drawing.Point(531, 67);
            this.labelVisit.Name = "labelVisit";
            this.labelVisit.Size = new System.Drawing.Size(170, 13);
            this.labelVisit.TabIndex = 38;
            this.labelVisit.Text = "Visit Time:";
            // 
            // textBoxPatName
            // 
            this.textBoxPatName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPatName.Enabled = false;
            this.textBoxPatName.Location = new System.Drawing.Point(179, 5);
            this.textBoxPatName.Name = "textBoxPatName";
            this.textBoxPatName.Size = new System.Drawing.Size(346, 20);
            this.textBoxPatName.TabIndex = 39;
            // 
            // selectLabTestComboBox
            // 
            this.selectLabTestComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selectLabTestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectLabTestComboBox.FormattingEnabled = true;
            this.selectLabTestComboBox.Location = new System.Drawing.Point(707, 412);
            this.selectLabTestComboBox.Name = "selectLabTestComboBox";
            this.selectLabTestComboBox.Size = new System.Drawing.Size(170, 21);
            this.selectLabTestComboBox.TabIndex = 10;
            // 
            // addTestButton
            // 
            this.addTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.addTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTestButton.Location = new System.Drawing.Point(707, 440);
            this.addTestButton.Name = "addTestButton";
            this.addTestButton.Size = new System.Drawing.Size(170, 22);
            this.addTestButton.TabIndex = 11;
            this.addTestButton.Text = "Add Test";
            this.addTestButton.UseVisualStyleBackColor = true;
            this.addTestButton.Click += new System.EventHandler(this.addTestButton_Click);
            // 
            // submitLabOrderButton
            // 
            this.submitLabOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.submitLabOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitLabOrderButton.Location = new System.Drawing.Point(707, 469);
            this.submitLabOrderButton.Name = "submitLabOrderButton";
            this.submitLabOrderButton.Size = new System.Drawing.Size(170, 22);
            this.submitLabOrderButton.TabIndex = 13;
            this.submitLabOrderButton.Text = "Submit Lab Order";
            this.submitLabOrderButton.UseVisualStyleBackColor = true;
            this.submitLabOrderButton.Click += new System.EventHandler(this.submitLabOrderButton_Click);
            // 
            // removeTestButton
            // 
            this.removeTestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.removeTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTestButton.Location = new System.Drawing.Point(707, 498);
            this.removeTestButton.Name = "removeTestButton";
            this.removeTestButton.Size = new System.Drawing.Size(170, 23);
            this.removeTestButton.TabIndex = 12;
            this.removeTestButton.Text = "Remove Selected Test";
            this.removeTestButton.UseVisualStyleBackColor = true;
            this.removeTestButton.Click += new System.EventHandler(this.removeTestButton_Click);
            // 
            // updateTestButton
            // 
            this.updateTestButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateTestButton.Enabled = false;
            this.updateTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTestButton.Location = new System.Drawing.Point(707, 558);
            this.updateTestButton.Name = "updateTestButton";
            this.updateTestButton.Size = new System.Drawing.Size(170, 22);
            this.updateTestButton.TabIndex = 29;
            this.updateTestButton.Text = "Update Tests";
            this.updateTestButton.UseVisualStyleBackColor = true;
            this.updateTestButton.Click += new System.EventHandler(this.updateTestButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(707, 596);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(170, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // labelTemp
            // 
            this.labelTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(531, 241);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(170, 13);
            this.labelTemp.TabIndex = 45;
            this.labelTemp.Text = "fahrenheit";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TestCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "TestCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TestDateTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "TestDateTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // labTestBindingSource
            // 
            this.labTestBindingSource.DataSource = typeof(CS6232_G2.Model.LabTest);
            // 
            // RoutineCheckupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 632);
            this.Controls.Add(this.routineTableLayoutPanel);
            this.Name = "RoutineCheckupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoutineCheckup";
            this.Load += new System.EventHandler(this.RoutineCheckup_Load);
            this.routineTableLayoutPanel.ResumeLayout(false);
            this.routineTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labTestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel routineTableLayoutPanel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label inchLabel;
        private System.Windows.Forms.TextBox sysTextBox;
        private System.Windows.Forms.Label poundLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label fDiagnosesLabel;
        private System.Windows.Forms.Label idiagnosisLabel;
        private System.Windows.Forms.Label symptomsLabel;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.TextBox diaTextBox;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox pulseTextBox;
        private System.Windows.Forms.TextBox fDiagnosesTextBox;
        private System.Windows.Forms.TextBox iDiagnosisTextBox;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.ComboBox selectLabTestComboBox;
        private System.Windows.Forms.Button addTestButton;
        private System.Windows.Forms.Button removeTestButton;
        private System.Windows.Forms.Button submitLabOrderButton;
        private System.Windows.Forms.Button saveVisitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.DataGridView testDataGridView;
        private System.Windows.Forms.BindingSource labTestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label lblSaveFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Normal;
        private System.Windows.Forms.Button updateTestButton;
        private System.Windows.Forms.Label diaLabel;
        private System.Windows.Forms.Label syslabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.TextBox textBoxVisitTime;
        private System.Windows.Forms.TextBox textBoxPatAddress;
        private System.Windows.Forms.TextBox textBoxNurName;
        private System.Windows.Forms.TextBox textBoxPatDOB;
        private System.Windows.Forms.TextBox textBoxDocName;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Label labelNurse;
        private System.Windows.Forms.Label labelPatDOB;
        private System.Windows.Forms.Label labelPatAdd;
        private System.Windows.Forms.Label labelVisit;
        private System.Windows.Forms.TextBox textBoxPatName;
        private System.Windows.Forms.Label labelTemp;
    }
}