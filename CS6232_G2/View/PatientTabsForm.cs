using CS6232_G2.Controller;
using System;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    public partial class PatientTabsForm : Form
    {
        UserController _userController;
        int _patientId;

        public PatientTabsForm(int userId)
        {
            _patientId = userId;
            _userController = new UserController();
            InitializeComponent();
        }

        private void PatientTabsForm_Load(object sender, EventArgs e)
        {
            ucSearchTest.SetPatient(_userController.GetUserFullNameById(_patientId));
        }
    }
}
