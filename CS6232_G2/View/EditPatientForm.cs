using CS6232_G2.Controller;
using CS6232_G2.Model;
using System.Collections.Generic;
using System.Drawing;
using System;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    public partial class EditPatientForm : Form
    {
        private User _loadedUser;
        private PatientController _patientController;
        private UserController _userController;
        private int _userId;

        /// <summary>
        /// The contructor for the EditPatientUserControl
        /// </summary>
        public EditPatientForm(int userId)
        {
            _loadedUser = new User();
            _patientController = new PatientController();
            _userController = new UserController();
            _userId = userId;
            InitializeComponent();
        }

        private void LoadPatientDetails()
        {
            _loadedUser = _userController.GetUserById(_userId);
            tbLastName.Text = _loadedUser.LastName;
            tbFirstName.Text = _loadedUser.FirstName;
            dtpDateOfBirth.Value = _loadedUser.DOB;
            tbSSN.Text = _loadedUser.SSN;

            if (_loadedUser.Gender == "M")
            {
                cbGender.SelectedIndex = 0;
            }
            else
            {
                cbGender.SelectedIndex = 1;
            }

            tbStreetNumber.Text = _loadedUser.StreetNumber;
            tbCity.Text = _loadedUser.City;
            tbState.Text = _loadedUser.State;
            tbCountry.Text = _loadedUser.Country;
            tbPhone.Text = _loadedUser.Phone;
            tbZipcode.Text = _loadedUser.Zipcode;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadPatientDetails();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
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

                int i = 0;
                string ssn = this.tbSSN.Text;
                if (ssn == null || ssn == "" || ssn.Length != 9 || !int.TryParse(this.tbSSN.Text, out i))
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

                string state = this.tbState.Text;
                if (state == null || state == "")
                {
                    stateValid = false;
                    lblStateError.Text = "Please enter a valid state";
                }

                string country = this.tbCountry.Text;
                if (country == null || country == "")
                {
                    countryValid = false;
                    lblCountryError.Text = "Please enter a valid country";
                }

                string phone = this.tbPhone.Text;
                if (phone == null || phone == "" || phone.Length < 10 || phone.Length > 13)
                {
                    phoneValid = false;
                    lblPhoneError.Text = "Please enter a valid phone number";
                }

                string zip = this.tbZipcode.Text;
                if (zip == null || zip == "" || zip.Length != 5 || !int.TryParse(this.tbZipcode.Text, out i))
                {
                    zipcodeValid = false;
                    lblZipcodeError.Text = "Please enter a valid five digit zip code";
                }

                if (!lastNameValid || !firstNameValid || !dobValid || !ssnValid || !genderValid || !streetNumberValid || !cityValid || !stateValid || !countryValid || !phoneValid || !zipcodeValid)
                {
                    return;
                }
                else
                {
                    User user = new User();
                    user.FirstName = firstName;
                    user.LastName = lastName;
                    user.DOB = (DateTime)dtpDateOfBirth.Value;
                    user.SSN = ssn;
                    user.Gender = cbGender.SelectedValue.ToString();
                    user.StreetNumber = streetNumber;
                    user.City = city;
                    user.State = state;
                    user.Phone = phone;
                    user.Zipcode = zip;
                    user.Country = country;
                    if (user.FirstName == _loadedUser.FirstName && user.LastName == _loadedUser.LastName
                        && user.DOB == _loadedUser.DOB && user.SSN == _loadedUser.SSN
                        && user.Gender == _loadedUser.Gender && user.StreetNumber == _loadedUser.StreetNumber
                        && user.City == _loadedUser.City && user.State == _loadedUser.State
                        && user.Phone == _loadedUser.Phone && user.Zipcode == _loadedUser.Zipcode)
                    {
                        this.lblMessage.ForeColor = Color.Red;
                        this.lblMessage.Text = "No changes have been made.";
                        return;
                    }
                    if (!this._patientController.UpdatePatient(user, _loadedUser))
                    {
                        this.lblMessage.ForeColor = Color.Red;
                        this.lblMessage.Text = "The patient's information has changed, please reload.";
                        return;
                    }
                    this.lblMessage.ForeColor = Color.Black;
                    this.lblMessage.Text = "The patient has been updated.";
                }
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

        private void CountryTextBox_TextBoxChanged(object sender, EventArgs e)
        {
            lblCountryError.Text = string.Empty;
            lblMessage.Text = string.Empty;
        }
    }
}
