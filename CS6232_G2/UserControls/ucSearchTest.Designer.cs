namespace CS6232_G2.UserControls
{
    partial class ucSearchTest
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTests = new System.Windows.Forms.DataGridView();
            this.cbVisits = new System.Windows.Forms.ComboBox();
            this.cbTests = new System.Windows.Forms.ComboBox();
            this.lblPatientVisits = new System.Windows.Forms.Label();
            this.lblTests = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.dgvTests, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbVisits, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbTests, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPatientVisits, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTests, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 400);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvTests
            // 
            this.dgvTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvTests, 3);
            this.dgvTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTests.Location = new System.Drawing.Point(3, 109);
            this.dgvTests.Name = "dgvTests";
            this.dgvTests.Size = new System.Drawing.Size(709, 234);
            this.dgvTests.TabIndex = 0;
            // 
            // cbVisits
            // 
            this.cbVisits.FormattingEnabled = true;
            this.cbVisits.Location = new System.Drawing.Point(3, 56);
            this.cbVisits.Name = "cbVisits";
            this.cbVisits.Size = new System.Drawing.Size(121, 21);
            this.cbVisits.TabIndex = 1;
            this.cbVisits.SelectedIndexChanged += new System.EventHandler(this.cbAppointments_SelectedIndexChanged);
            // 
            // cbTests
            // 
            this.cbTests.FormattingEnabled = true;
            this.cbTests.Location = new System.Drawing.Point(241, 56);
            this.cbTests.Name = "cbTests";
            this.cbTests.Size = new System.Drawing.Size(121, 21);
            this.cbTests.TabIndex = 2;
            this.cbTests.SelectedIndexChanged += new System.EventHandler(this.cbTests_SelectedIndexChanged);
            // 
            // lblPatientVisits
            // 
            this.lblPatientVisits.AutoSize = true;
            this.lblPatientVisits.Location = new System.Drawing.Point(3, 0);
            this.lblPatientVisits.Name = "lblPatientVisits";
            this.lblPatientVisits.Size = new System.Drawing.Size(30, 13);
            this.lblPatientVisits.TabIndex = 3;
            this.lblPatientVisits.Text = "visits";
            // 
            // lblTests
            // 
            this.lblTests.AutoSize = true;
            this.lblTests.Location = new System.Drawing.Point(241, 0);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(29, 13);
            this.lblTests.TabIndex = 4;
            this.lblTests.Text = "tests";
            // 
            // ucSearchTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucSearchTest";
            this.Size = new System.Drawing.Size(715, 400);
            this.Load += new System.EventHandler(this.ucSearchTest_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvTests;
        private System.Windows.Forms.ComboBox cbVisits;
        private System.Windows.Forms.ComboBox cbTests;
        private System.Windows.Forms.Label lblPatientVisits;
        private System.Windows.Forms.Label lblTests;
    }
}
