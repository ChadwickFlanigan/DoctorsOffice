﻿using CS6232_G2.Controller;
using CS6232_G2.Model;
using System.Collections.Generic;
using System;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// Search patient appoinment by first name,last name and dob
    /// </summary>
    public partial class SearchPatientForm : Form
    {
        private readonly PatientController _patientController;
        private readonly AppointmentController _appointmentController;
        private List<Patient> _patients;
        private bool loggedOut;
        private readonly LoginForm _loginForm;
        /// <summary>
        /// The constructor for the SearchPatientForm, which initializes and sets up the components of the form
        /// </summary>
        public SearchPatientForm(LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            _patientController = new PatientController();
            _appointmentController = new AppointmentController();
            _patients = new List<Patient>();
            appointmentDataGridView.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Sets the username and personal name of the user logged in
        /// </summary>
        /// <param name="login"></param>
        /// <param name="user"></param>
        public void SetUsername(Login login, User user)
        {
            lblUsername.Text = login.Username;
            lblName.Text = CapitalizeFirstLetter(user.FirstName) + " " + CapitalizeFirstLetter(user.LastName);
        }

        private string CapitalizeFirstLetter(string str)
        {
            string firstLetter = str.Remove(1, str.Length - 1);
            string newString = firstLetter.ToUpper() + str.Remove(0, 1);
            return newString;
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loggedOut = true;
            _loginForm.Logout();
            Close();
        }

        private void SearchPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!loggedOut)
            {
                Application.Exit();
            }
        }

        private void firstLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            dateTimePicker.Enabled = false;
            searchButton.Enabled = true;
            clearButton.Enabled = true;
            appointmentDataGridView.DataSource = null;
            clear();
        }

        private void dobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = true;
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;
            searchButton.Enabled = true;
            clearButton.Enabled = true;
            appointmentDataGridView.DataSource = null;
            clear();
        }

        private void dobLastnameradioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = true;
            lastNameTextBox.Enabled = true;
            firstNameTextBox.Enabled = false;
            searchButton.Enabled = true;
            clearButton.Enabled = true;
            appointmentDataGridView.DataSource = null;
            clear();
        }
        private void clear()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string fname = firstNameTextBox.Text;
            string lname = lastNameTextBox.Text;

            try
            {
                if (firstLastNameRadioButton.Checked)
                {
                    if (string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname))
                    {
                        MessageBox.Show("Please enter  patient first and last name", "Patient name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    _patients = _patientController.GetPatientByFirstAndLastName(fname, lname);
                    if (_patients.Count == 0)
                    {
                        MessageBox.Show("No patient found with the name");
                    }

                    appointmentDataGridView.DataSource = _patients;
                }
                else if (dobLastnameradioButton.Checked)
                {
                    if (string.IsNullOrEmpty(lname))
                    {
                        MessageBox.Show("Please enter  patient last name", "Patient name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    DateTime dob = Convert.ToDateTime(dateTimePicker.Value).Date;
                    _patients = _patientController.GetPatientsByDOBAndLastName(dob, lname);

                    if (_patients.Count == 0)
                    {
                        MessageBox.Show("No patient found with the date");
                    }
                    appointmentDataGridView.DataSource = _patients;
                }
                else if (dobRadioButton.Checked)
                {
                    DateTime dob = Convert.ToDateTime(dateTimePicker.Value).Date;
                    _patients = _patientController.GetPatientsByDOB(dob);

                    if (_patients.Count == 0)
                    {
                        MessageBox.Show("No patient found with the date");
                    }
                    appointmentDataGridView.DataSource = _patients;
                }

                patientname();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void patientname()
        {
            appointmentDataGridView.DataSource = _patients;

            if (appointmentDataGridView.Rows.Count > 0)
            {
                appointmentDataGridView.Rows[0].Selected = true;
            }
        }

        private void appointmentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                appointmentDataGridView.Rows[e.RowIndex].Selected = true;
            }
        }

        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            if (appointmentDataGridView.SelectedRows.Count == 1)
            {
                var selectedPatient = (Patient)appointmentDataGridView.SelectedRows[0].DataBoundItem;

                using (PatientTabsForm patientAppointments = new PatientTabsForm(selectedPatient))
                {
                    patientAppointments.ShowDialog();
                }

                appointmentDataGridView.DataSource = null;
                clear();
            }
            else
            {
                MessageBox.Show("Please select only 1 row");
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            using (RegisterPatientForm patientRegistration = new RegisterPatientForm())
            {
                patientRegistration.ShowDialog();
            }
        }

        private bool ShouldDelete()
        {
            DialogResult close = MessageBox.Show("Are you sure you want to delete this patient?", "" +
                "", MessageBoxButtons.YesNo);
            return DialogResult.Yes == close;
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            if (appointmentDataGridView.SelectedRows.Count == 1)
            {
                var selectedPatient = (Patient)appointmentDataGridView.SelectedRows[0].DataBoundItem;

                if (!ShouldDelete())
                {
                    return;
                }

                if (_appointmentController.GetPatientAppointments(selectedPatient.PatientId).Count == 0)
                {
                    _patientController.Delete(selectedPatient.UserId);
                    appointmentDataGridView.DataSource = null;
                    clear();
                } else
                {
                    MessageBox.Show("Cannot delete a patient with scheduled appointments");
                }
            }
            else
            {
                MessageBox.Show("Please select only 1 row");
            }
        }
    }
}
