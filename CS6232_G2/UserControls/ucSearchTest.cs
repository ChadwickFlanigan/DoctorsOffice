using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    public partial class ucSearchTest : UserControl
    {
        Patient _patient;
        AppointmentController _appointmentController;
        public ucSearchTest()
        {
            _patient = new Patient();
            _appointmentController = new AppointmentController();
            InitializeComponent();
        }

        private void ucSearchTest_Load(object sender, EventArgs e)
        {

        }

        private void PopulateComboBoxes()
        {
            try
            {
                List<Appointment> appointments = _appointmentController.GetPatientAppointments(_patient.PatientId);
                cbAppointments.DataSource = appointments;
                cbAppointments.DisplayMember = "AppointmentTime";
                cbAppointments.ValueMember = "AppointmentId";

                //List<Tests> tests = _appointmentController.GetPatientAppointments(_patient.PatientId);
                cbAppointments.DataSource = appointments;
                cbAppointments.DisplayMember = "AppointmentTime";
                cbAppointments.ValueMember = "AppointmentId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
