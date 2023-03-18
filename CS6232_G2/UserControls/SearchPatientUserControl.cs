using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    public partial class SearchPatientUserControl : UserControl
    {
       private readonly SearchController _searchController;
        private readonly AppointmentController _appointmentController;
        private Appointment _appointment;
        private List<Appointment> patients;
        public SearchPatientUserControl()
        {
            InitializeComponent();
            _searchController = new SearchController();
            patients = new List<Appointment>();
        }

        private void firstLastNameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            firstNameTextBox.Enabled = true;
            lastNameTextBox.Enabled = true;
            dateTimePicker.Enabled = false;
        }

        private void dobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = true;
            firstNameTextBox.Enabled = false;
            lastNameTextBox.Enabled = false;

        }

        private void dobLastnameradioButton_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker.Enabled = true;
            lastNameTextBox.Enabled = true;
            firstNameTextBox.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {

            firstNameTextBox.Text ="";
            lastNameTextBox.Text="";
            dateTimePicker.Value= DateTime.Now;
            

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string fname = firstNameTextBox.Text;
            string lname = lastNameTextBox.Text;

            if (firstNameTextBox.Enabled && lastNameTextBox.Enabled)
            {
                if(string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname))
                {
                    MessageBox.Show("Please enter  patient first and last name", "Patient name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                patients = _searchController.GetPatientByFirstAndLastName(fname,lname);
                if (patients.Count == 0)
                {
                    MessageBox.Show("No patient found with the name");
                }
                
              appointmentDataGridView.DataSource = patients;
            }
            if (dateTimePicker.Enabled)
            {
               /// patients = _searchController.GetPatientByDateOfBirth();
            }
            if(dateTimePicker.Enabled && lastNameTextBox.Enabled)
            {

            }
            patientname();
        }
        private void patientname()
        {
            appointmentDataGridView.DataSource = patients;
            if(appointmentDataGridView.SelectedRows.Count > 0)
            {
                _appointment = _appointmentController.GetAppointmentByName(_appointment.AppointmentId);
                ///patientLinkLabel , patient name to be visible to edit
            }
        }
        private void patientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
