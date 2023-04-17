namespace CS6232_G2.UserControls
{
    partial class ucSearchNurse
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
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.radDOBAndLastName = new System.Windows.Forms.RadioButton();
            this.radDOB = new System.Windows.Forms.RadioButton();
            this.lblDOB = new System.Windows.Forms.Label();
            this.radFullName = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.dgNurses = new System.Windows.Forms.DataGridView();
            this.NurseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnViewNurse = new System.Windows.Forms.Button();
            this.btnAddNurse = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.tblLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNurses)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 3;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblLayout.Controls.Add(this.radDOBAndLastName, 2, 0);
            this.tblLayout.Controls.Add(this.radDOB, 1, 0);
            this.tblLayout.Controls.Add(this.lblDOB, 0, 3);
            this.tblLayout.Controls.Add(this.radFullName, 0, 0);
            this.tblLayout.Controls.Add(this.txtFirstName, 1, 1);
            this.tblLayout.Controls.Add(this.txtLastName, 1, 2);
            this.tblLayout.Controls.Add(this.lblFirstName, 0, 1);
            this.tblLayout.Controls.Add(this.lblLastName, 0, 2);
            this.tblLayout.Controls.Add(this.btnSearch, 2, 3);
            this.tblLayout.Controls.Add(this.btnClear, 2, 2);
            this.tblLayout.Controls.Add(this.dtDOB, 1, 3);
            this.tblLayout.Controls.Add(this.dgNurses, 0, 4);
            this.tblLayout.Controls.Add(this.btnViewNurse, 0, 5);
            this.tblLayout.Controls.Add(this.btnAddNurse, 2, 5);
            this.tblLayout.Controls.Add(this.lblError, 2, 1);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 6;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayout.Size = new System.Drawing.Size(715, 400);
            this.tblLayout.TabIndex = 0;
            // 
            // radDOBAndLastName
            // 
            this.radDOBAndLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radDOBAndLastName.AutoSize = true;
            this.radDOBAndLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDOBAndLastName.Location = new System.Drawing.Point(431, 11);
            this.radDOBAndLastName.Name = "radDOBAndLastName";
            this.radDOBAndLastName.Size = new System.Drawing.Size(281, 17);
            this.radDOBAndLastName.TabIndex = 2;
            this.radDOBAndLastName.Text = "Date of Birth and Last name";
            this.radDOBAndLastName.UseVisualStyleBackColor = true;
            this.radDOBAndLastName.CheckedChanged += new System.EventHandler(this.radDOBAndLastName_CheckedChanged);
            // 
            // radDOB
            // 
            this.radDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radDOB.AutoSize = true;
            this.radDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radDOB.Location = new System.Drawing.Point(217, 11);
            this.radDOB.Name = "radDOB";
            this.radDOB.Size = new System.Drawing.Size(208, 17);
            this.radDOB.TabIndex = 1;
            this.radDOB.Text = "Date of Birth";
            this.radDOB.UseVisualStyleBackColor = true;
            this.radDOB.CheckedChanged += new System.EventHandler(this.radDOB_CheckedChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(3, 133);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(208, 13);
            this.lblDOB.TabIndex = 24;
            this.lblDOB.Text = "DOB:";
            // 
            // radFullName
            // 
            this.radFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radFullName.AutoSize = true;
            this.radFullName.Checked = true;
            this.radFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFullName.Location = new System.Drawing.Point(3, 11);
            this.radFullName.Name = "radFullName";
            this.radFullName.Size = new System.Drawing.Size(208, 17);
            this.radFullName.TabIndex = 0;
            this.radFullName.TabStop = true;
            this.radFullName.Text = "First name and Last name";
            this.radFullName.UseVisualStyleBackColor = true;
            this.radFullName.CheckedChanged += new System.EventHandler(this.radFullName_CheckedChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(217, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(208, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(217, 90);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(208, 20);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 53);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(208, 13);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(3, 93);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(208, 13);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(431, 128);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(281, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(431, 88);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(281, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtDOB
            // 
            this.dtDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDOB.Enabled = false;
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB.Location = new System.Drawing.Point(217, 130);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(208, 20);
            this.dtDOB.TabIndex = 5;
            this.dtDOB.ValueChanged += new System.EventHandler(this.dtDOB_ValueChanged);
            // 
            // dgNurses
            // 
            this.dgNurses.AllowUserToAddRows = false;
            this.dgNurses.AllowUserToDeleteRows = false;
            this.dgNurses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNurses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNurses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNurses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NurseId,
            this.FirstName,
            this.LastName,
            this.IsActive});
            this.tblLayout.SetColumnSpan(this.dgNurses, 3);
            this.dgNurses.Location = new System.Drawing.Point(3, 163);
            this.dgNurses.Name = "dgNurses";
            this.dgNurses.ReadOnly = true;
            this.dgNurses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNurses.Size = new System.Drawing.Size(709, 194);
            this.dgNurses.TabIndex = 7;
            // 
            // NurseId
            // 
            this.NurseId.DataPropertyName = "NurseId";
            this.NurseId.HeaderText = "Nurse Id";
            this.NurseId.Name = "NurseId";
            this.NurseId.ReadOnly = true;
            this.NurseId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FirstName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LastName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Is Active";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            this.IsActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnViewNurse
            // 
            this.btnViewNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewNurse.Location = new System.Drawing.Point(3, 368);
            this.btnViewNurse.Name = "btnViewNurse";
            this.btnViewNurse.Size = new System.Drawing.Size(208, 23);
            this.btnViewNurse.TabIndex = 8;
            this.btnViewNurse.Text = "View Nurse";
            this.btnViewNurse.UseVisualStyleBackColor = true;
            // 
            // btnAddNurse
            // 
            this.btnAddNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNurse.Location = new System.Drawing.Point(431, 368);
            this.btnAddNurse.Name = "btnAddNurse";
            this.btnAddNurse.Size = new System.Drawing.Size(281, 23);
            this.btnAddNurse.TabIndex = 9;
            this.btnAddNurse.Text = "Add Nurse";
            this.btnAddNurse.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(431, 52);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(281, 16);
            this.lblError.TabIndex = 32;
            // 
            // ucSearchNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayout);
            this.Name = "ucSearchNurse";
            this.Size = new System.Drawing.Size(715, 400);
            this.tblLayout.ResumeLayout(false);
            this.tblLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNurses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.DataGridView dgNurses;
        private System.Windows.Forms.Button btnViewNurse;
        private System.Windows.Forms.Button btnAddNurse;
        private System.Windows.Forms.RadioButton radFullName;
        private System.Windows.Forms.RadioButton radDOB;
        private System.Windows.Forms.RadioButton radDOBAndLastName;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
    }
}
