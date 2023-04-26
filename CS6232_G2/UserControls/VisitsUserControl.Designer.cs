namespace CS6232_G2.UserControls
{
    partial class VisitsUserControl
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.patientVisitDataGridView = new System.Windows.Forms.DataGridView();
            this.patientVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visitLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.visitSearchButton = new System.Windows.Forms.Button();
            this.viewVisitButton = new System.Windows.Forms.Button();
            this.PatientVisitID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.13044F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.86956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tableLayoutPanel1.Controls.Add(this.patientVisitDataGridView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.visitLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.visitSearchButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewVisitButton, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.7905F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.2095F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(680, 463);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // patientVisitDataGridView
            // 
            this.patientVisitDataGridView.AllowUserToAddRows = false;
            this.patientVisitDataGridView.AllowUserToDeleteRows = false;
            this.patientVisitDataGridView.AutoGenerateColumns = false;
            this.patientVisitDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientVisitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientVisitID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn10,
            this.PatientName});
            this.tableLayoutPanel1.SetColumnSpan(this.patientVisitDataGridView, 3);
            this.patientVisitDataGridView.DataSource = this.patientVisitBindingSource;
            this.patientVisitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientVisitDataGridView.Location = new System.Drawing.Point(3, 77);
            this.patientVisitDataGridView.Name = "patientVisitDataGridView";
            this.patientVisitDataGridView.ReadOnly = true;
            this.patientVisitDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientVisitDataGridView.Size = new System.Drawing.Size(674, 317);
            this.patientVisitDataGridView.TabIndex = 3;
            // 
            // patientVisitBindingSource
            // 
            this.patientVisitBindingSource.DataSource = typeof(CS6232_G2.Model.PatientVisit);
            // 
            // visitLabel
            // 
            this.visitLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.visitLabel.AutoSize = true;
            this.visitLabel.Location = new System.Drawing.Point(88, 30);
            this.visitLabel.Name = "visitLabel";
            this.visitLabel.Size = new System.Drawing.Size(95, 13);
            this.visitLabel.TabIndex = 0;
            this.visitLabel.Text = "Filter By Visit Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.Location = new System.Drawing.Point(189, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // visitSearchButton
            // 
            this.visitSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visitSearchButton.Location = new System.Drawing.Point(478, 25);
            this.visitSearchButton.Name = "visitSearchButton";
            this.visitSearchButton.Size = new System.Drawing.Size(75, 23);
            this.visitSearchButton.TabIndex = 2;
            this.visitSearchButton.Text = "Search Visits";
            this.visitSearchButton.UseVisualStyleBackColor = true;
            this.visitSearchButton.Click += new System.EventHandler(this.visitSearchButton_Click);
            // 
            // viewVisitButton
            // 
            this.viewVisitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewVisitButton.Location = new System.Drawing.Point(266, 418);
            this.viewVisitButton.Name = "viewVisitButton";
            this.viewVisitButton.Size = new System.Drawing.Size(129, 23);
            this.viewVisitButton.TabIndex = 4;
            this.viewVisitButton.Text = "View Visit";
            this.viewVisitButton.UseVisualStyleBackColor = true;
            this.viewVisitButton.Click += new System.EventHandler(this.viewVisitButton_Click);
            // 
            // PatientVisitID
            // 
            this.PatientVisitID.DataPropertyName = "PatientVisitID";
            this.PatientVisitID.HeaderText = "PatientVisitID";
            this.PatientVisitID.Name = "PatientVisitID";
            this.PatientVisitID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VisitDateAndTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "VisitDateAndTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Symptoms";
            this.dataGridViewTextBoxColumn10.HeaderText = "Symptoms";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // VisitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VisitsUserControl";
            this.Size = new System.Drawing.Size(680, 463);
            this.Load += new System.EventHandler(this.VisitsUserControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label visitLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button visitSearchButton;
        private System.Windows.Forms.Button viewVisitButton;
        private System.Windows.Forms.DataGridView patientVisitDataGridView;
        private System.Windows.Forms.BindingSource patientVisitBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientVisitID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
    }
    }
