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
            this.searchLabel = new System.Windows.Forms.Label();
            this.dobRadioButton = new System.Windows.Forms.RadioButton();
            this.firstLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.dobLastnameradioButton = new System.Windows.Forms.RadioButton();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.dobTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.patientDetailsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.searchTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTableLayoutPanel
            // 
            this.searchTableLayoutPanel.ColumnCount = 3;
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.searchTableLayoutPanel.Controls.Add(this.firstNameTextBox, 0, 4);
            this.searchTableLayoutPanel.Controls.Add(this.searchLabel, 0, 0);
            this.searchTableLayoutPanel.Controls.Add(this.dobRadioButton, 0, 1);
            this.searchTableLayoutPanel.Controls.Add(this.firstLastNameRadioButton, 0, 2);
            this.searchTableLayoutPanel.Controls.Add(this.dobLastnameradioButton, 0, 3);
            this.searchTableLayoutPanel.Controls.Add(this.clearButton, 1, 1);
            this.searchTableLayoutPanel.Controls.Add(this.searchButton, 1, 2);
            this.searchTableLayoutPanel.Controls.Add(this.dobTextBox, 2, 4);
            this.searchTableLayoutPanel.Controls.Add(this.lastNameTextBox, 1, 4);
            this.searchTableLayoutPanel.Controls.Add(this.patientLabel, 2, 5);
            this.searchTableLayoutPanel.Controls.Add(this.patientLinkLabel, 0, 5);
            this.searchTableLayoutPanel.Controls.Add(this.patientDetailsLabel, 0, 6);
            this.searchTableLayoutPanel.Controls.Add(this.button2, 1, 8);
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
            this.searchTableLayoutPanel.Size = new System.Drawing.Size(526, 376);
            this.searchTableLayoutPanel.TabIndex = 0;
            this.searchTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchTableLayoutPanel_Paint);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(3, 1);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(204, 16);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search Patient Information";
            // 
            // dobRadioButton
            // 
            this.dobRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dobRadioButton.AutoSize = true;
            this.dobRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobRadioButton.Location = new System.Drawing.Point(3, 24);
            this.dobRadioButton.Name = "dobRadioButton";
            this.dobRadioButton.Size = new System.Drawing.Size(204, 17);
            this.dobRadioButton.TabIndex = 1;
            this.dobRadioButton.TabStop = true;
            this.dobRadioButton.Text = "Date of Birth";
            this.dobRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstLastNameRadioButton
            // 
            this.firstLastNameRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstLastNameRadioButton.AutoSize = true;
            this.firstLastNameRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLastNameRadioButton.Location = new System.Drawing.Point(3, 54);
            this.firstLastNameRadioButton.Name = "firstLastNameRadioButton";
            this.firstLastNameRadioButton.Size = new System.Drawing.Size(204, 17);
            this.firstLastNameRadioButton.TabIndex = 2;
            this.firstLastNameRadioButton.TabStop = true;
            this.firstLastNameRadioButton.Text = "First name and Last name";
            this.firstLastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // dobLastnameradioButton
            // 
            this.dobLastnameradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dobLastnameradioButton.AutoSize = true;
            this.dobLastnameradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLastnameradioButton.Location = new System.Drawing.Point(3, 84);
            this.dobLastnameradioButton.Name = "dobLastnameradioButton";
            this.dobLastnameradioButton.Size = new System.Drawing.Size(204, 17);
            this.dobLastnameradioButton.TabIndex = 3;
            this.dobLastnameradioButton.TabStop = true;
            this.dobLastnameradioButton.Text = "Date of Birth and Last name";
            this.dobLastnameradioButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(213, 21);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(151, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(213, 51);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(151, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // dobTextBox
            // 
            this.dobTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dobTextBox.Location = new System.Drawing.Point(370, 116);
            this.dobTextBox.Name = "dobTextBox";
            this.dobTextBox.Size = new System.Drawing.Size(153, 20);
            this.dobTextBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameTextBox.Location = new System.Drawing.Point(3, 116);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(204, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextBox.Location = new System.Drawing.Point(213, 116);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.lastNameTextBox.TabIndex = 8;
            // 
            // patientLabel
            // 
            this.patientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.patientLabel.AutoSize = true;
            this.patientLabel.Location = new System.Drawing.Point(370, 148);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(153, 26);
            this.patientLabel.TabIndex = 9;
            this.patientLabel.Text = "(Click patient name to edit or update patient information)";
            // 
            // patientLinkLabel
            // 
            this.patientLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.patientLinkLabel.AutoSize = true;
            this.searchTableLayoutPanel.SetColumnSpan(this.patientLinkLabel, 2);
            this.patientLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLinkLabel.Location = new System.Drawing.Point(3, 153);
            this.patientLinkLabel.Name = "patientLinkLabel";
            this.patientLinkLabel.Size = new System.Drawing.Size(361, 16);
            this.patientLinkLabel.TabIndex = 10;
            this.patientLinkLabel.TabStop = true;
            this.patientLinkLabel.Text = "testlater-patient name";
            // 
            // patientDetailsLabel
            // 
            this.patientDetailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.patientDetailsLabel.AutoSize = true;
            this.patientDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientDetailsLabel.Location = new System.Drawing.Point(3, 180);
            this.patientDetailsLabel.Name = "patientDetailsLabel";
            this.patientDetailsLabel.Size = new System.Drawing.Size(204, 13);
            this.patientDetailsLabel.TabIndex = 11;
            this.patientDetailsLabel.Text = "Patient appointment Information : ";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(213, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Appointment";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SearchPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchTableLayoutPanel);
            this.Name = "SearchPatientUserControl";
            this.Size = new System.Drawing.Size(526, 376);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox dobTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.LinkLabel patientLinkLabel;
        private System.Windows.Forms.Label patientDetailsLabel;
        private System.Windows.Forms.Button button2;
    }
}
