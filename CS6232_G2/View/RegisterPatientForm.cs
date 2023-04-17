using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// The form used for registering new patients
    /// </summary>
    public partial class RegisterPatientForm : Form
    {
        private PatientController _patientController;
        private StateController _stateController;

        /// <summary>
        /// The constructor for the RegisterPatientForm
        /// </summary>
        public RegisterPatientForm()
        {
            InitializeComponent();
            _patientController = new PatientController();
            _stateController = new StateController();
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

                long l = 0;
                string phone = this.tbPhone.Text;               
                if (phone == null || phone == "" || phone.Length != 10 || !long.TryParse(this.tbPhone.Text, out l))
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
                    user.State = cbStates.SelectedValue.ToString();
                    user.City = city;
                    user.Phone = phone;
                    user.Zipcode = zip;
                    this._patientController.Add(user);
                    this.lblMessage.ForeColor = Color.Black;
                    Clear();
                    this.lblMessage.Text = "The patient has been registered.";               
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

            cbGender.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RegisterPatientForm_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }
    }
}
