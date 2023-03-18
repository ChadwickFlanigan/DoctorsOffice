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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPatientUserControl));
            this.searchTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.searchLabel = new System.Windows.Forms.Label();
            this.patientDetailsLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.firstLastNameRadioButton = new System.Windows.Forms.RadioButton();
            this.dobRadioButton = new System.Windows.Forms.RadioButton();
            this.dobLastnameradioButton = new System.Windows.Forms.RadioButton();
            this.patientLinkLabel = new System.Windows.Forms.LinkLabel();
            this.patientLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.fLabel = new System.Windows.Forms.Label();
            this.lLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.appointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.appointmentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).BeginInit();
            this.appointmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
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
            this.searchTableLayoutPanel.Controls.Add(this.button2, 1, 8);
            this.searchTableLayoutPanel.Controls.Add(this.firstLastNameRadioButton, 0, 1);
            this.searchTableLayoutPanel.Controls.Add(this.dobRadioButton, 1, 1);
            this.searchTableLayoutPanel.Controls.Add(this.dobLastnameradioButton, 2, 1);
            this.searchTableLayoutPanel.Controls.Add(this.patientLinkLabel, 0, 5);
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
            this.appointmentDataGridView.AutoGenerateColumns = false;
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.searchTableLayoutPanel.SetColumnSpan(this.appointmentDataGridView, 3);
            this.appointmentDataGridView.DataSource = this.appointmentBindingSource;
            this.appointmentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appointmentDataGridView.Location = new System.Drawing.Point(3, 203);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.Size = new System.Drawing.Size(536, 148);
            this.appointmentDataGridView.TabIndex = 18;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(192, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add Appointment";
            this.button2.UseVisualStyleBackColor = true;
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
            // patientLinkLabel
            // 
            this.patientLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.patientLinkLabel.AutoSize = true;
            this.searchTableLayoutPanel.SetColumnSpan(this.patientLinkLabel, 2);
            this.patientLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientLinkLabel.Location = new System.Drawing.Point(3, 156);
            this.patientLinkLabel.Name = "patientLinkLabel";
            this.patientLinkLabel.Size = new System.Drawing.Size(372, 16);
            this.patientLinkLabel.TabIndex = 10;
            this.patientLinkLabel.TabStop = true;
            this.patientLinkLabel.Text = "12";
            this.patientLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.patientLinkLabel_LinkClicked);
            this.patientLinkLabel.BindingContextChanged += new System.EventHandler(this.searchButton_Click);
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
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(192, 112);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(151, 20);
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
            // appointmentBindingNavigator
            // 
            this.appointmentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.appointmentBindingNavigator.BindingSource = this.appointmentBindingSource;
            this.appointmentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.appointmentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.appointmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.appointmentBindingNavigatorSaveItem});
            this.appointmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointmentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.appointmentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.appointmentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.appointmentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.appointmentBindingNavigator.Name = "appointmentBindingNavigator";
            this.appointmentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.appointmentBindingNavigator.Size = new System.Drawing.Size(542, 25);
            this.appointmentBindingNavigator.TabIndex = 1;
            this.appointmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // appointmentBindingNavigatorSaveItem
            // 
            this.appointmentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.appointmentBindingNavigatorSaveItem.Enabled = false;
            this.appointmentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentBindingNavigatorSaveItem.Image")));
            this.appointmentBindingNavigatorSaveItem.Name = "appointmentBindingNavigatorSaveItem";
            this.appointmentBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.appointmentBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(CS6232_G2.Model.Appointment);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatientId";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatientId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DoctorId";
            this.dataGridViewTextBoxColumn4.HeaderText = "DoctorId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AppointmentTime";
            this.dataGridViewTextBoxColumn5.HeaderText = "AppointmentTime";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumn6.HeaderText = "Reason";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // SearchPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.appointmentBindingNavigator);
            this.Controls.Add(this.searchTableLayoutPanel);
            this.Name = "SearchPatientUserControl";
            this.Size = new System.Drawing.Size(542, 386);
            this.searchTableLayoutPanel.ResumeLayout(false);
            this.searchTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).EndInit();
            this.appointmentBindingNavigator.ResumeLayout(false);
            this.appointmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.LinkLabel patientLinkLabel;
        private System.Windows.Forms.Label patientDetailsLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.BindingNavigator appointmentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton appointmentBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Label lLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}
