namespace CS6232_G2.View
{
    partial class EditPatientForm
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
            this.tlpEditPatient = new System.Windows.Forms.TableLayoutPanel();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblStreetNumber = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblZipcode = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbSSN = new System.Windows.Forms.TextBox();
            this.tbStreetNumber = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbZipcode = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEditUserControlTitle = new System.Windows.Forms.Label();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.lblFirstNameError = new System.Windows.Forms.Label();
            this.lblDateOfBirthError = new System.Windows.Forms.Label();
            this.lblSSNError = new System.Windows.Forms.Label();
            this.lblGenderError = new System.Windows.Forms.Label();
            this.lblStreetNumberError = new System.Windows.Forms.Label();
            this.lblCityError = new System.Windows.Forms.Label();
            this.lblStateError = new System.Windows.Forms.Label();
            this.lblCountryError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblZipcodeError = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tlpEditPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpEditPatient
            // 
            this.tlpEditPatient.ColumnCount = 3;
            this.tlpEditPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.51F));
            this.tlpEditPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.51F));
            this.tlpEditPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.98F));
            this.tlpEditPatient.Controls.Add(this.lblLastName, 0, 1);
            this.tlpEditPatient.Controls.Add(this.lblFirstName, 0, 2);
            this.tlpEditPatient.Controls.Add(this.lblDateOfBirth, 0, 3);
            this.tlpEditPatient.Controls.Add(this.lblSSN, 0, 4);
            this.tlpEditPatient.Controls.Add(this.lblGender, 0, 5);
            this.tlpEditPatient.Controls.Add(this.lblStreetNumber, 0, 6);
            this.tlpEditPatient.Controls.Add(this.lblCity, 0, 7);
            this.tlpEditPatient.Controls.Add(this.lblState, 0, 8);
            this.tlpEditPatient.Controls.Add(this.lblCountry, 0, 9);
            this.tlpEditPatient.Controls.Add(this.lblPhone, 0, 10);
            this.tlpEditPatient.Controls.Add(this.lblZipcode, 0, 11);
            this.tlpEditPatient.Controls.Add(this.tbLastName, 1, 1);
            this.tlpEditPatient.Controls.Add(this.tbFirstName, 1, 2);
            this.tlpEditPatient.Controls.Add(this.tbSSN, 1, 4);
            this.tlpEditPatient.Controls.Add(this.tbStreetNumber, 1, 6);
            this.tlpEditPatient.Controls.Add(this.tbCity, 1, 7);
            this.tlpEditPatient.Controls.Add(this.tbState, 1, 8);
            this.tlpEditPatient.Controls.Add(this.tbCountry, 1, 9);
            this.tlpEditPatient.Controls.Add(this.tbPhone, 1, 10);
            this.tlpEditPatient.Controls.Add(this.tbZipcode, 1, 11);
            this.tlpEditPatient.Controls.Add(this.btnBack, 0, 12);
            this.tlpEditPatient.Controls.Add(this.btnUpdate, 1, 12);
            this.tlpEditPatient.Controls.Add(this.lblEditUserControlTitle, 1, 0);
            this.tlpEditPatient.Controls.Add(this.lblLastNameError, 2, 1);
            this.tlpEditPatient.Controls.Add(this.lblFirstNameError, 2, 2);
            this.tlpEditPatient.Controls.Add(this.lblDateOfBirthError, 2, 3);
            this.tlpEditPatient.Controls.Add(this.lblSSNError, 2, 4);
            this.tlpEditPatient.Controls.Add(this.lblGenderError, 2, 5);
            this.tlpEditPatient.Controls.Add(this.lblStreetNumberError, 2, 6);
            this.tlpEditPatient.Controls.Add(this.lblCityError, 2, 7);
            this.tlpEditPatient.Controls.Add(this.lblStateError, 2, 8);
            this.tlpEditPatient.Controls.Add(this.lblCountryError, 2, 9);
            this.tlpEditPatient.Controls.Add(this.lblPhoneError, 2, 10);
            this.tlpEditPatient.Controls.Add(this.lblZipcodeError, 2, 11);
            this.tlpEditPatient.Controls.Add(this.lblMessage, 2, 12);
            this.tlpEditPatient.Controls.Add(this.dtpDateOfBirth, 1, 3);
            this.tlpEditPatient.Controls.Add(this.cbGender, 1, 5);
            this.tlpEditPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEditPatient.Location = new System.Drawing.Point(0, 0);
            this.tlpEditPatient.Name = "tlpEditPatient";
            this.tlpEditPatient.RowCount = 13;
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.689469F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692546F));
            this.tlpEditPatient.Size = new System.Drawing.Size(800, 450);
            this.tlpEditPatient.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 43);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 16);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(6, 77);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(6, 111);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(79, 16);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "Date of Birth";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(6, 145);
            this.lblSSN.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(35, 16);
            this.lblSSN.TabIndex = 3;
            this.lblSSN.Text = "SSN";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(6, 179);
            this.lblGender.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblStreetNumber
            // 
            this.lblStreetNumber.AutoSize = true;
            this.lblStreetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetNumber.Location = new System.Drawing.Point(6, 213);
            this.lblStreetNumber.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblStreetNumber.Name = "lblStreetNumber";
            this.lblStreetNumber.Size = new System.Drawing.Size(93, 16);
            this.lblStreetNumber.TabIndex = 5;
            this.lblStreetNumber.Text = "Street Number";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(6, 247);
            this.lblCity.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(6, 281);
            this.lblState.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(38, 16);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(6, 315);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(52, 16);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 349);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 16);
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // lblZipcode
            // 
            this.lblZipcode.AutoSize = true;
            this.lblZipcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipcode.Location = new System.Drawing.Point(6, 383);
            this.lblZipcode.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(57, 16);
            this.lblZipcode.TabIndex = 10;
            this.lblZipcode.Text = "Zipcode";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(241, 37);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(169, 20);
            this.tbLastName.TabIndex = 0;
            this.tbLastName.TextChanged += new System.EventHandler(this.LastNameTextBox_TextBoxChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(241, 71);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(169, 20);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextBoxChanged);
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(241, 139);
            this.tbSSN.MaxLength = 9;
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(169, 20);
            this.tbSSN.TabIndex = 3;
            this.tbSSN.TextChanged += new System.EventHandler(this.SSNTextBox_TextBoxChanged);
            // 
            // tbStreetNumber
            // 
            this.tbStreetNumber.Location = new System.Drawing.Point(241, 207);
            this.tbStreetNumber.Name = "tbStreetNumber";
            this.tbStreetNumber.Size = new System.Drawing.Size(169, 20);
            this.tbStreetNumber.TabIndex = 5;
            this.tbStreetNumber.TextChanged += new System.EventHandler(this.StreetNumberTextBox_TextBoxChanged);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(241, 241);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(169, 20);
            this.tbCity.TabIndex = 6;
            this.tbCity.TextChanged += new System.EventHandler(this.CityTextBox_TextBoxChanged);
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(241, 275);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(169, 20);
            this.tbState.TabIndex = 7;
            this.tbState.TextChanged += new System.EventHandler(this.StateTextBox_TextBoxChanged);
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(241, 309);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(169, 20);
            this.tbCountry.TabIndex = 8;
            this.tbCountry.TextChanged += new System.EventHandler(this.CountryTextBox_TextBoxChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(241, 343);
            this.tbPhone.MaxLength = 13;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(169, 20);
            this.tbPhone.TabIndex = 9;
            this.tbPhone.TextChanged += new System.EventHandler(this.PhoneTextBox_TextBoxChanged);
            // 
            // tbZipcode
            // 
            this.tbZipcode.Location = new System.Drawing.Point(241, 377);
            this.tbZipcode.MaxLength = 5;
            this.tbZipcode.Name = "tbZipcode";
            this.tbZipcode.Size = new System.Drawing.Size(169, 20);
            this.tbZipcode.TabIndex = 10;
            this.tbZipcode.TextChanged += new System.EventHandler(this.ZipcodeTextBox_TextBoxChanged);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.Location = new System.Drawing.Point(3, 411);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(232, 36);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.Location = new System.Drawing.Point(241, 411);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 36);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblEditUserControlTitle
            // 
            this.lblEditUserControlTitle.AutoSize = true;
            this.lblEditUserControlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEditUserControlTitle.Location = new System.Drawing.Point(241, 8);
            this.lblEditUserControlTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblEditUserControlTitle.Name = "lblEditUserControlTitle";
            this.lblEditUserControlTitle.Size = new System.Drawing.Size(86, 16);
            this.lblEditUserControlTitle.TabIndex = 24;
            this.lblEditUserControlTitle.Text = "Edit Patient";
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblLastNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameError.Location = new System.Drawing.Point(479, 42);
            this.lblLastNameError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(0, 13);
            this.lblLastNameError.TabIndex = 25;
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.AutoSize = true;
            this.lblFirstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(479, 76);
            this.lblFirstNameError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(0, 13);
            this.lblFirstNameError.TabIndex = 26;
            // 
            // lblDateOfBirthError
            // 
            this.lblDateOfBirthError.AutoSize = true;
            this.lblDateOfBirthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirthError.ForeColor = System.Drawing.Color.Red;
            this.lblDateOfBirthError.Location = new System.Drawing.Point(479, 110);
            this.lblDateOfBirthError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblDateOfBirthError.Name = "lblDateOfBirthError";
            this.lblDateOfBirthError.Size = new System.Drawing.Size(0, 13);
            this.lblDateOfBirthError.TabIndex = 27;
            // 
            // lblSSNError
            // 
            this.lblSSNError.AutoSize = true;
            this.lblSSNError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblSSNError.ForeColor = System.Drawing.Color.Red;
            this.lblSSNError.Location = new System.Drawing.Point(479, 144);
            this.lblSSNError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblSSNError.Name = "lblSSNError";
            this.lblSSNError.Size = new System.Drawing.Size(0, 13);
            this.lblSSNError.TabIndex = 28;
            // 
            // lblGenderError
            // 
            this.lblGenderError.AutoSize = true;
            this.lblGenderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblGenderError.ForeColor = System.Drawing.Color.Red;
            this.lblGenderError.Location = new System.Drawing.Point(479, 178);
            this.lblGenderError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblGenderError.Name = "lblGenderError";
            this.lblGenderError.Size = new System.Drawing.Size(0, 13);
            this.lblGenderError.TabIndex = 29;
            // 
            // lblStreetNumberError
            // 
            this.lblStreetNumberError.AutoSize = true;
            this.lblStreetNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblStreetNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblStreetNumberError.Location = new System.Drawing.Point(479, 212);
            this.lblStreetNumberError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblStreetNumberError.Name = "lblStreetNumberError";
            this.lblStreetNumberError.Size = new System.Drawing.Size(0, 13);
            this.lblStreetNumberError.TabIndex = 30;
            // 
            // lblCityError
            // 
            this.lblCityError.AutoSize = true;
            this.lblCityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCityError.ForeColor = System.Drawing.Color.Red;
            this.lblCityError.Location = new System.Drawing.Point(479, 246);
            this.lblCityError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblCityError.Name = "lblCityError";
            this.lblCityError.Size = new System.Drawing.Size(0, 13);
            this.lblCityError.TabIndex = 31;
            // 
            // lblStateError
            // 
            this.lblStateError.AutoSize = true;
            this.lblStateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblStateError.ForeColor = System.Drawing.Color.Red;
            this.lblStateError.Location = new System.Drawing.Point(479, 280);
            this.lblStateError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblStateError.Name = "lblStateError";
            this.lblStateError.Size = new System.Drawing.Size(0, 13);
            this.lblStateError.TabIndex = 32;
            // 
            // lblCountryError
            // 
            this.lblCountryError.AutoSize = true;
            this.lblCountryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCountryError.ForeColor = System.Drawing.Color.Red;
            this.lblCountryError.Location = new System.Drawing.Point(479, 314);
            this.lblCountryError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblCountryError.Name = "lblCountryError";
            this.lblCountryError.Size = new System.Drawing.Size(0, 13);
            this.lblCountryError.TabIndex = 33;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(479, 348);
            this.lblPhoneError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneError.TabIndex = 34;
            // 
            // lblZipcodeError
            // 
            this.lblZipcodeError.AutoSize = true;
            this.lblZipcodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblZipcodeError.ForeColor = System.Drawing.Color.Red;
            this.lblZipcodeError.Location = new System.Drawing.Point(479, 382);
            this.lblZipcodeError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblZipcodeError.Name = "lblZipcodeError";
            this.lblZipcodeError.Size = new System.Drawing.Size(0, 13);
            this.lblZipcodeError.TabIndex = 35;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(479, 416);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 36;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(241, 105);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(169, 20);
            this.dtpDateOfBirth.TabIndex = 2;
            this.dtpDateOfBirth.Value = new System.DateTime(2023, 3, 15, 20, 49, 26, 0);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(241, 173);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(169, 21);
            this.cbGender.TabIndex = 4;
            // 
            // EditPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpEditPatient);
            this.Name = "EditPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPatientForm";
            this.Load += new System.EventHandler(this.EditPatient_Load);
            this.tlpEditPatient.ResumeLayout(false);
            this.tlpEditPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpEditPatient;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblStreetNumber;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblZipcode;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbSSN;
        private System.Windows.Forms.TextBox tbStreetNumber;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCountry;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbZipcode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblEditUserControlTitle;
        private System.Windows.Forms.Label lblLastNameError;
        private System.Windows.Forms.Label lblFirstNameError;
        private System.Windows.Forms.Label lblDateOfBirthError;
        private System.Windows.Forms.Label lblSSNError;
        private System.Windows.Forms.Label lblGenderError;
        private System.Windows.Forms.Label lblStreetNumberError;
        private System.Windows.Forms.Label lblCityError;
        private System.Windows.Forms.Label lblStateError;
        private System.Windows.Forms.Label lblCountryError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblZipcodeError;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbGender;
    }
}