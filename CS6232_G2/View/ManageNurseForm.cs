using CS6232_G2.Controller;
using CS6232_G2.Helper;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// Add or update a nurse form
    /// </summary>
    public partial class ManageNurseForm : Form
    {
        private NurseController _nurseController;
        private StateController _stateController;
        private Nurse _loadedNurse;
        private bool _isPasswordChanged;

        /// <summary>
        /// Constructor to initialize components and controllers
        /// </summary>
        public ManageNurseForm(int nurseId)
        {
            InitializeComponent();
            _nurseController = new NurseController();
            _stateController = new StateController();

            LoadComboBox();

            lblTitle.Text = "Register Nurse";

            if (nurseId > 0)
            {
                lblTitle.Text = "Update Nurse";

                _loadedNurse = _nurseController.GetNurseById(nurseId);
                LoadFormValue();
            }
        }

        private void LoadComboBox()
        {
            try
            {
                List<Gender> genderList = new List<Gender>();
                Gender male = new Gender();
                Gender female = new Gender();
                male.Name = "Male";
                male.Id = "M";
                female.Name = "Female";
                female.Id = "F";
                genderList.Add(male);
                genderList.Add(female);
                cbGender.DataSource = genderList;
                cbGender.DisplayMember = "Name";
                cbGender.ValueMember = "Id";
                List<State> states = _stateController.GetAllStates();
                cbStates.DataSource = states;
                cbStates.DisplayMember = "StateName";
                cbStates.ValueMember = "StateCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void LoadFormValue()
        {
            tbFirstName.Text = _loadedNurse.FirstName;
            tbLastName.Text = _loadedNurse.LastName;
            dtpDateOfBirth.Value = _loadedNurse.DOB;
            tbSSN.Text = _loadedNurse.SSN;

            if (_loadedNurse.Gender == "M")
            {
                cbGender.SelectedIndex = 0;
            }
            else
            {
                cbGender.SelectedIndex = 1;
            }

            cbStates.SelectedValue = _loadedNurse.State;

            tbStreetNumber.Text = _loadedNurse.StreetNumber;
            tbCity.Text = _loadedNurse.City;
            _loadedNurse.Phone = _loadedNurse.Phone.Replace("-", "").Trim();
            tbPhone.Text = _loadedNurse.Phone.Replace("-", "").Trim();
            tbZipcode.Text = _loadedNurse.Zipcode;
            _loadedNurse.Phone = _loadedNurse.Phone.Replace("-", "").Trim();
            tbPhone.Text = _loadedNurse.Phone.Replace("-", "").Trim();
            txtUsername.Text = _loadedNurse.Username;
            txtPassword.Text = _loadedNurse.Password.Length > 0 ? EncryptionHelper.DecryptString(_loadedNurse.Password) : string.Empty;
            chkActive.Checked = _loadedNurse.Active;
            _isPasswordChanged = false;
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            bool lastNameValid = true;
            bool firstNameValid = true;
            bool dobValid = true;
            bool ssnValid = true;
            bool genderValid = true;
            bool streetNumberValid = true;
            bool cityValid = true;
            bool stateValid = true;
            bool countryValid = true;
            bool phoneValid = true;
            bool zipcodeValid = true;
            bool usernameValid = true;
            bool passwordValid = true;

            string lastName = this.tbLastName.Text;
            if (lastName == null || lastName == "")
            {
                lastNameValid = false;
                lblLastNameError.Text = "Please enter a valid last name";
            }

            string firstName = this.tbFirstName.Text;
            if (firstName == null || firstName == "")
            {
                firstNameValid = false;
                lblFirstNameError.Text = "Please enter a valid first name";
            }

            string ssn = this.tbSSN.Text;
            if (ssn == null || ssn == "" || ssn.Length != 9 || !int.TryParse(this.tbSSN.Text, out int i))
            {
                ssnValid = false;
                lblSSNError.Text = "Please enter a valid nine diget social security number";
            }

            string streetNumber = this.tbStreetNumber.Text;
            if (streetNumber == null || streetNumber == "")
            {
                streetNumberValid = false;
                lblStreetNumberError.Text = "Please enter a valid street number";
            }

            string city = this.tbCity.Text;
            if (city == null || city == "")
            {
                cityValid = false;
                lblCityError.Text = "Please enter a valid city";
            }

            string phone = this.tbPhone.Text;
            if (phone == null || phone == "" || phone.Length != 10 || !long.TryParse(this.tbPhone.Text, out long l))
            {
                phoneValid = false;
                lblPhoneError.Text = "Please enter a valid phone number without dashes";
            }

            string zip = this.tbZipcode.Text;
            if (zip == null || zip == "" || zip.Length != 5 || !int.TryParse(this.tbZipcode.Text, out i))
            {
                zipcodeValid = false;
                lblZipcodeError.Text = "Please enter a valid five digit zip code";
            }

            string username = txtUsername.Text;
            if (string.IsNullOrEmpty(username))
            {
                usernameValid = false;
                lblUsernameError.Text = "Please enter a username";
            }

            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                passwordValid = false;
                lblPassword.Text = "Please enter a password";
            }

            if (!lastNameValid || !firstNameValid || !dobValid || !ssnValid || !genderValid || !streetNumberValid || !cityValid || !stateValid || !countryValid || !phoneValid || !zipcodeValid || !usernameValid || !passwordValid)
            {
                return;
            }

            Nurse nurse = new Nurse();
            nurse.NurseId = _loadedNurse != null ? _loadedNurse.NurseId : 0;
            nurse.UserId = _loadedNurse != null ? _loadedNurse.UserId : 0;
            nurse.FirstName = firstName;
            nurse.LastName = lastName;
            nurse.DOB = dtpDateOfBirth.Value;
            nurse.SSN = ssn;
            nurse.Gender = cbGender.SelectedValue.ToString();
            nurse.StreetNumber = streetNumber;
            nurse.State = cbStates.SelectedValue.ToString();
            nurse.City = city;
            nurse.Phone = phone;
            nurse.Zipcode = zip;
            nurse.Username = username;
            nurse.Password = password;
            nurse.Active = chkActive.Checked;

            if (_loadedNurse != null && nurse.FirstName == _loadedNurse.FirstName && nurse.LastName == _loadedNurse.LastName
                        && nurse.DOB == _loadedNurse.DOB && nurse.SSN == _loadedNurse.SSN
                        && nurse.Gender == _loadedNurse.Gender && nurse.StreetNumber == _loadedNurse.StreetNumber
                        && nurse.City == _loadedNurse.City && nurse.State == _loadedNurse.State
                        && nurse.Phone?.Trim() == _loadedNurse.Phone?.Trim() && nurse.Zipcode == _loadedNurse.Zipcode
                        && nurse.Username?.Trim() == _loadedNurse.Username?.Trim() && nurse.Password?.Trim() == EncryptionHelper.DecryptString(_loadedNurse.Password?.Trim())
                        && nurse.Active == _loadedNurse.Active)
            {
                this.lblMessage.ForeColor = Color.Red;
                this.lblMessage.Text = "No changes have been made.";
                return;
            }

            if (_isPasswordChanged)
            {
                nurse.Password = EncryptionHelper.EncryptString(password);
            }

            try
            {
                this._nurseController.SaveNurse(nurse);
                this.lblMessage.ForeColor = Color.Black;
                Clear();
                this.lblMessage.Text = "The nurse has been saved.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("The input is invalid." + Environment.NewLine + ex.Message,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LastNameTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblLastNameError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void FirstNameTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblFirstNameError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void SSNTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblSSNError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void StreetNumberTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblStreetNumberError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void CityTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblCityError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void StateTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblStateError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void PhoneTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblPhoneError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void ZipcodeTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblZipcodeError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clear()
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            tbSSN.Text = string.Empty;
            tbStreetNumber.Text = string.Empty;
            tbCity.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbZipcode.Text = string.Empty;
            cbStates.SelectedIndex = 0;
            cbGender.SelectedIndex = 0;
            txtUsername.Clear();
            txtPassword.Clear();
            chkActive.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RegisterPatientForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            lblUsernameError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPasswordError.Text = string.Empty;
            lblMessage.Text = string.Empty;
            _isPasswordChanged = true;
        }
    }
}
