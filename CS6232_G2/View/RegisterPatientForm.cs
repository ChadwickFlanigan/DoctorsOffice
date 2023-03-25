using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CS6232_G2.View
{
    /// <summary>
    /// The form used for registering new patients
    /// </summary>
    public partial class RegisterPatientForm : Form
    {
        private UserController _userController;
        private PatientController _patientController;

        public RegisterPatientForm()
        {
            InitializeComponent();
            _userController = new UserController();
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
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
                    lblSSNError.Text = "Please enter a valid nine diget number";
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
                if (phone == null || phone == "")
                {
                    phoneValid = false;
                    lblCountryError.Text = "Please enter a valid phone number";
                }

                string zip = this.tbZipcode.Text;
                if (zip == null || zip == "")
                {
                    zipcodeValid = false;
                    lblZipcodeError.Text = "Please enter a valid zip code";
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
                    user.DOB = dtpDateOfBirth.Value;
                    user.SSN = ssn;
                    user.Gender = cbGender.SelectedValue.ToString();
                    user.StreetNumber = streetNumber;
                    user.City = city;
                    user.State = state;
                    user.Phone = phone;
                    user.Zipcode = zip;
                    user.Country = country;
                    this._patientController.Add(user);
                    this.lblMessage.ForeColor = Color.Black;
                    this.lblMessage.Text = "The patient has been registered.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The input is invalid." + Environment.NewLine + ex.Message,
                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void RegisterPatientUserControl_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text= string.Empty;
            tbLastName.Text= string.Empty;
            tbSSN.Text= string.Empty;
            tbStreetNumber.Text= string.Empty;
            tbCity.Text = string.Empty;
            tbState.Text = string.Empty;
            tbCountry.Text = string.Empty;
            tbPhone.Text = string.Empty;
            tbZipcode.Text = string.Empty;
        }
    }
}
