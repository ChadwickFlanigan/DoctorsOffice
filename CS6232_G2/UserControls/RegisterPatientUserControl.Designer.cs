namespace CS6232_G2.UserControls
{
    partial class RegisterPatientUserControl
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
            this.tlpRegisterPatient = new System.Windows.Forms.TableLayoutPanel();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegisterUserControlTitle = new System.Windows.Forms.Label();
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
            this.tlpRegisterPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpRegisterPatient
            // 
            this.tlpRegisterPatient.ColumnCount = 3;
            this.tlpRegisterPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRegisterPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRegisterPatient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpRegisterPatient.Controls.Add(this.lblLastName, 0, 1);
            this.tlpRegisterPatient.Controls.Add(this.lblFirstName, 0, 2);
            this.tlpRegisterPatient.Controls.Add(this.lblDateOfBirth, 0, 3);
            this.tlpRegisterPatient.Controls.Add(this.lblSSN, 0, 4);
            this.tlpRegisterPatient.Controls.Add(this.lblGender, 0, 5);
            this.tlpRegisterPatient.Controls.Add(this.lblStreetNumber, 0, 6);
            this.tlpRegisterPatient.Controls.Add(this.lblCity, 0, 7);
            this.tlpRegisterPatient.Controls.Add(this.lblState, 0, 8);
            this.tlpRegisterPatient.Controls.Add(this.lblCountry, 0, 9);
            this.tlpRegisterPatient.Controls.Add(this.lblPhone, 0, 10);
            this.tlpRegisterPatient.Controls.Add(this.lblZipcode, 0, 11);
            this.tlpRegisterPatient.Controls.Add(this.tbLastName, 1, 1);
            this.tlpRegisterPatient.Controls.Add(this.tbFirstName, 1, 2);
            this.tlpRegisterPatient.Controls.Add(this.tbSSN, 1, 4);
            this.tlpRegisterPatient.Controls.Add(this.tbStreetNumber, 1, 6);
            this.tlpRegisterPatient.Controls.Add(this.tbCity, 1, 7);
            this.tlpRegisterPatient.Controls.Add(this.tbState, 1, 8);
            this.tlpRegisterPatient.Controls.Add(this.tbCountry, 1, 9);
            this.tlpRegisterPatient.Controls.Add(this.tbPhone, 1, 10);
            this.tlpRegisterPatient.Controls.Add(this.tbZipcode, 1, 11);
            this.tlpRegisterPatient.Controls.Add(this.btnClear, 0, 12);
            this.tlpRegisterPatient.Controls.Add(this.btnRegister, 1, 12);
            this.tlpRegisterPatient.Controls.Add(this.lblRegisterUserControlTitle, 1, 0);
            this.tlpRegisterPatient.Controls.Add(this.lblLastNameError, 2, 1);
            this.tlpRegisterPatient.Controls.Add(this.lblFirstNameError, 2, 2);
            this.tlpRegisterPatient.Controls.Add(this.lblDateOfBirthError, 2, 3);
            this.tlpRegisterPatient.Controls.Add(this.lblSSNError, 2, 4);
            this.tlpRegisterPatient.Controls.Add(this.lblGenderError, 2, 5);
            this.tlpRegisterPatient.Controls.Add(this.lblStreetNumberError, 2, 6);
            this.tlpRegisterPatient.Controls.Add(this.lblCityError, 2, 7);
            this.tlpRegisterPatient.Controls.Add(this.lblStateError, 2, 8);
            this.tlpRegisterPatient.Controls.Add(this.lblCountryError, 2, 9);
            this.tlpRegisterPatient.Controls.Add(this.lblPhoneError, 2, 10);
            this.tlpRegisterPatient.Controls.Add(this.lblZipcodeError, 2, 11);
            this.tlpRegisterPatient.Controls.Add(this.lblMessage, 2, 12);
            this.tlpRegisterPatient.Controls.Add(this.dtpDateOfBirth, 1, 3);
            this.tlpRegisterPatient.Controls.Add(this.cbGender, 1, 5);
            this.tlpRegisterPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRegisterPatient.Location = new System.Drawing.Point(0, 0);
            this.tlpRegisterPatient.Name = "tlpRegisterPatient";
            this.tlpRegisterPatient.RowCount = 13;
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.689467F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692544F));
            this.tlpRegisterPatient.Size = new System.Drawing.Size(526, 400);
            this.tlpRegisterPatient.TabIndex = 0;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(6, 39);
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
            this.lblFirstName.Location = new System.Drawing.Point(6, 69);
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
            this.lblDateOfBirth.Location = new System.Drawing.Point(6, 99);
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
            this.lblSSN.Location = new System.Drawing.Point(6, 129);
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
            this.lblGender.Location = new System.Drawing.Point(6, 159);
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
            this.lblStreetNumber.Location = new System.Drawing.Point(6, 189);
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
            this.lblCity.Location = new System.Drawing.Point(6, 219);
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
            this.lblState.Location = new System.Drawing.Point(6, 249);
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
            this.lblCountry.Location = new System.Drawing.Point(6, 279);
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
            this.lblPhone.Location = new System.Drawing.Point(6, 309);
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
            this.lblZipcode.Location = new System.Drawing.Point(6, 339);
            this.lblZipcode.Margin = new System.Windows.Forms.Padding(6, 9, 3, 0);
            this.lblZipcode.Name = "lblZipcode";
            this.lblZipcode.Size = new System.Drawing.Size(57, 16);
            this.lblZipcode.TabIndex = 10;
            this.lblZipcode.Text = "Zipcode";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(178, 33);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(169, 20);
            this.tbLastName.TabIndex = 11;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(178, 63);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(169, 20);
            this.tbFirstName.TabIndex = 12;
            // 
            // tbSSN
            // 
            this.tbSSN.Location = new System.Drawing.Point(178, 123);
            this.tbSSN.Name = "tbSSN";
            this.tbSSN.Size = new System.Drawing.Size(169, 20);
            this.tbSSN.TabIndex = 14;
            // 
            // tbStreetNumber
            // 
            this.tbStreetNumber.Location = new System.Drawing.Point(178, 183);
            this.tbStreetNumber.Name = "tbStreetNumber";
            this.tbStreetNumber.Size = new System.Drawing.Size(169, 20);
            this.tbStreetNumber.TabIndex = 16;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(178, 213);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(169, 20);
            this.tbCity.TabIndex = 17;
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(178, 243);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(169, 20);
            this.tbState.TabIndex = 18;
            // 
            // tbCountry
            // 
            this.tbCountry.Location = new System.Drawing.Point(178, 273);
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(169, 20);
            this.tbCountry.TabIndex = 19;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(178, 303);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(169, 20);
            this.tbPhone.TabIndex = 20;
            // 
            // tbZipcode
            // 
            this.tbZipcode.Location = new System.Drawing.Point(178, 333);
            this.tbZipcode.Name = "tbZipcode";
            this.tbZipcode.Size = new System.Drawing.Size(169, 20);
            this.tbZipcode.TabIndex = 21;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(3, 363);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 34);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.Location = new System.Drawing.Point(178, 363);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(169, 34);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegisterUserControlTitle
            // 
            this.lblRegisterUserControlTitle.AutoSize = true;
            this.lblRegisterUserControlTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblRegisterUserControlTitle.Location = new System.Drawing.Point(178, 8);
            this.lblRegisterUserControlTitle.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblRegisterUserControlTitle.Name = "lblRegisterUserControlTitle";
            this.lblRegisterUserControlTitle.Size = new System.Drawing.Size(118, 16);
            this.lblRegisterUserControlTitle.TabIndex = 24;
            this.lblRegisterUserControlTitle.Text = "Register Patient";
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameError.Location = new System.Drawing.Point(353, 38);
            this.lblLastNameError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(0, 17);
            this.lblLastNameError.TabIndex = 25;
            // 
            // lblFirstNameError
            // 
            this.lblFirstNameError.AutoSize = true;
            this.lblFirstNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstNameError.Location = new System.Drawing.Point(353, 68);
            this.lblFirstNameError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblFirstNameError.Name = "lblFirstNameError";
            this.lblFirstNameError.Size = new System.Drawing.Size(0, 17);
            this.lblFirstNameError.TabIndex = 26;
            // 
            // lblDateOfBirthError
            // 
            this.lblDateOfBirthError.AutoSize = true;
            this.lblDateOfBirthError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateOfBirthError.ForeColor = System.Drawing.Color.Red;
            this.lblDateOfBirthError.Location = new System.Drawing.Point(353, 98);
            this.lblDateOfBirthError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblDateOfBirthError.Name = "lblDateOfBirthError";
            this.lblDateOfBirthError.Size = new System.Drawing.Size(0, 17);
            this.lblDateOfBirthError.TabIndex = 27;
            // 
            // lblSSNError
            // 
            this.lblSSNError.AutoSize = true;
            this.lblSSNError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSSNError.ForeColor = System.Drawing.Color.Red;
            this.lblSSNError.Location = new System.Drawing.Point(353, 128);
            this.lblSSNError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblSSNError.Name = "lblSSNError";
            this.lblSSNError.Size = new System.Drawing.Size(0, 17);
            this.lblSSNError.TabIndex = 28;
            // 
            // lblGenderError
            // 
            this.lblGenderError.AutoSize = true;
            this.lblGenderError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblGenderError.ForeColor = System.Drawing.Color.Red;
            this.lblGenderError.Location = new System.Drawing.Point(353, 158);
            this.lblGenderError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblGenderError.Name = "lblGenderError";
            this.lblGenderError.Size = new System.Drawing.Size(0, 17);
            this.lblGenderError.TabIndex = 29;
            // 
            // lblStreetNumberError
            // 
            this.lblStreetNumberError.AutoSize = true;
            this.lblStreetNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStreetNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblStreetNumberError.Location = new System.Drawing.Point(353, 188);
            this.lblStreetNumberError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblStreetNumberError.Name = "lblStreetNumberError";
            this.lblStreetNumberError.Size = new System.Drawing.Size(0, 17);
            this.lblStreetNumberError.TabIndex = 30;
            // 
            // lblCityError
            // 
            this.lblCityError.AutoSize = true;
            this.lblCityError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCityError.ForeColor = System.Drawing.Color.Red;
            this.lblCityError.Location = new System.Drawing.Point(353, 218);
            this.lblCityError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblCityError.Name = "lblCityError";
            this.lblCityError.Size = new System.Drawing.Size(0, 17);
            this.lblCityError.TabIndex = 31;
            // 
            // lblStateError
            // 
            this.lblStateError.AutoSize = true;
            this.lblStateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStateError.ForeColor = System.Drawing.Color.Red;
            this.lblStateError.Location = new System.Drawing.Point(353, 248);
            this.lblStateError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblStateError.Name = "lblStateError";
            this.lblStateError.Size = new System.Drawing.Size(0, 17);
            this.lblStateError.TabIndex = 32;
            // 
            // lblCountryError
            // 
            this.lblCountryError.AutoSize = true;
            this.lblCountryError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountryError.ForeColor = System.Drawing.Color.Red;
            this.lblCountryError.Location = new System.Drawing.Point(353, 278);
            this.lblCountryError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblCountryError.Name = "lblCountryError";
            this.lblCountryError.Size = new System.Drawing.Size(0, 17);
            this.lblCountryError.TabIndex = 33;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(353, 308);
            this.lblPhoneError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(0, 17);
            this.lblPhoneError.TabIndex = 34;
            // 
            // lblZipcodeError
            // 
            this.lblZipcodeError.AutoSize = true;
            this.lblZipcodeError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblZipcodeError.ForeColor = System.Drawing.Color.Red;
            this.lblZipcodeError.Location = new System.Drawing.Point(353, 338);
            this.lblZipcodeError.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblZipcodeError.Name = "lblZipcodeError";
            this.lblZipcodeError.Size = new System.Drawing.Size(0, 17);
            this.lblZipcodeError.TabIndex = 35;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(353, 368);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 36;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(178, 93);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(169, 20);
            this.dtpDateOfBirth.TabIndex = 37;
            this.dtpDateOfBirth.Value = new System.DateTime(2023, 3, 15, 20, 49, 26, 0);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(178, 153);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(169, 21);
            this.cbGender.TabIndex = 39;
            // 
            // RegisterPatientUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpRegisterPatient);
            this.Name = "RegisterPatientUserControl";
            this.Size = new System.Drawing.Size(526, 400);
            this.Load += new System.EventHandler(this.RegisterPatientUserControl_Load);
            this.tlpRegisterPatient.ResumeLayout(false);
            this.tlpRegisterPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpRegisterPatient;
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegisterUserControlTitle;
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
