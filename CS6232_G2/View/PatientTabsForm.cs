using CS6232_G2.Model;
using CS6232_G2.UserControls;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// Patient tab form will host 3 tabs, 1 for patient appointments, another for test results and third is for visits
    /// </summary>
    public partial class PatientTabsForm : Form
    {
        Patient _patient;

        /// <summary>
        /// Constructor will initialize the tabs with the patient object sent
        /// </summary>
        /// <param name="patient"></param>
        public PatientTabsForm(Patient patient)
        {
            InitializeComponent();
            _patient = patient;
            InititializeUserControls();
        }

        private void InititializeUserControls()
        {
            ucPatientAppointments.SetPatient(_patient);
            ucSearchTest.SetPatient(_patient);
            //ucPatientAppointments appointments = new ucPatientAppointments();
            //appointments.SetPatient(_patient);
            //visitsUserControl.SetPatient(patient);
        }
    }
}
