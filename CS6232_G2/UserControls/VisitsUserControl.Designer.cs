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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitsUserControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.visitLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.visitSearchButton = new System.Windows.Forms.Button();
            this.viewVisitButton = new System.Windows.Forms.Button();
            this.patientVisitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientVisitBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.patientVisitBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.patientVisitDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitBindingNavigator)).BeginInit();
            this.patientVisitBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.13044F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.86956F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
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
            // visitLabel
            // 
            this.visitLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.visitLabel.AutoSize = true;
            this.visitLabel.Location = new System.Drawing.Point(100, 30);
            this.visitLabel.Name = "visitLabel";
            this.visitLabel.Size = new System.Drawing.Size(95, 13);
            this.visitLabel.TabIndex = 0;
            this.visitLabel.Text = "Filter By Visit Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker.Location = new System.Drawing.Point(201, 27);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // visitSearchButton
            // 
            this.visitSearchButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.visitSearchButton.Location = new System.Drawing.Point(508, 25);
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
            this.viewVisitButton.Location = new System.Drawing.Point(287, 418);
            this.viewVisitButton.Name = "viewVisitButton";
            this.viewVisitButton.Size = new System.Drawing.Size(129, 23);
            this.viewVisitButton.TabIndex = 4;
            this.viewVisitButton.Text = "View Visit";
            this.viewVisitButton.UseVisualStyleBackColor = true;
            // 
            // patientVisitBindingSource
            // 
            this.patientVisitBindingSource.DataSource = typeof(CS6232_G2.Model.PatientVisit);
            // 
            // patientVisitBindingNavigator
            // 
            this.patientVisitBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientVisitBindingNavigator.BindingSource = this.patientVisitBindingSource;
            this.patientVisitBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientVisitBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientVisitBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientVisitBindingNavigatorSaveItem});
            this.patientVisitBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientVisitBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientVisitBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientVisitBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientVisitBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientVisitBindingNavigator.Name = "patientVisitBindingNavigator";
            this.patientVisitBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientVisitBindingNavigator.Size = new System.Drawing.Size(680, 25);
            this.patientVisitBindingNavigator.TabIndex = 1;
            this.patientVisitBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // patientVisitBindingNavigatorSaveItem
            // 
            this.patientVisitBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientVisitBindingNavigatorSaveItem.Enabled = false;
            this.patientVisitBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientVisitBindingNavigatorSaveItem.Image")));
            this.patientVisitBindingNavigatorSaveItem.Name = "patientVisitBindingNavigatorSaveItem";
            this.patientVisitBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientVisitBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // patientVisitDataGridView
            // 
            this.patientVisitDataGridView.AllowUserToAddRows = false;
            this.patientVisitDataGridView.AllowUserToDeleteRows = false;
            this.patientVisitDataGridView.AutoGenerateColumns = false;
            this.patientVisitDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientVisitDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientVisitDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn10});
            this.tableLayoutPanel1.SetColumnSpan(this.patientVisitDataGridView, 3);
            this.patientVisitDataGridView.DataSource = this.patientVisitBindingSource;
            this.patientVisitDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientVisitDataGridView.Location = new System.Drawing.Point(3, 77);
            this.patientVisitDataGridView.Name = "patientVisitDataGridView";
            this.patientVisitDataGridView.ReadOnly = true;
            this.patientVisitDataGridView.Size = new System.Drawing.Size(674, 317);
            this.patientVisitDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "NurseID";
            this.dataGridViewTextBoxColumn13.HeaderText = "NurseID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatientVisitID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatientVisitID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VisitDateAndTime";
            this.dataGridViewTextBoxColumn2.HeaderText = "VisitDateAndTime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Symptoms";
            this.dataGridViewTextBoxColumn10.HeaderText = "Symptoms";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // VisitsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.patientVisitBindingNavigator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VisitsUserControl";
            this.Size = new System.Drawing.Size(680, 463);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitBindingNavigator)).EndInit();
            this.patientVisitBindingNavigator.ResumeLayout(false);
            this.patientVisitBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientVisitDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label visitLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button visitSearchButton;
        private System.Windows.Forms.Button viewVisitButton;
        private System.Windows.Forms.DataGridView patientVisitDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource patientVisitBindingSource;
        private System.Windows.Forms.BindingNavigator patientVisitBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientVisitBindingNavigatorSaveItem;
    }
}
