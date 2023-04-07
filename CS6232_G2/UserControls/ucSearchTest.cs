using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    public partial class ucSearchTest : UserControl
    {
        Patient _patient;
        AppointmentController _appointmentController;
        TestController _testController;
        LabTestController _labTestController;
        public ucSearchTest()
        {
            _patient = new Patient();
            _appointmentController = new AppointmentController();
            _testController = new TestController();
            _labTestController = new LabTestController();
            InitializeComponent();
        }

        /// <summary>
        /// Sets the patient object
        /// </summary>
        /// <param name="patient"></param>
        public void SetPatient(Patient patient)
        {
            _patient = patient;
        }

        private void ucSearchTest_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            try
            {
                List<Appointment> appointments = _appointmentController.GetPatientAppointments(_patient.PatientId);
                cbVisits.DataSource = appointments;
                cbVisits.DisplayMember = "AppointmentTime";
                cbVisits.ValueMember = "AppointmentId";

                List<Test> tests = _testController.GetAllTests();
                cbTests.DataSource = tests;
                cbTests.DisplayMember = "TestName";
                cbTests.ValueMember = "TestCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void cbTests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateDataGrid()
        {
            dgvTests.DataSource = _labTestController.GetLabTestByVistIdAndTestCode(int.Parse(cbVisits.SelectedValue.ToString()), int.Parse(cbTests.SelectedValue.ToString()));
        }
    }
}
