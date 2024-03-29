﻿using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    /// <summary>
    /// The user control for searching for tests
    /// </summary>
    public partial class ucSearchTest : UserControl
    {
        Patient _patient;
        PatientVisitController _patientVisitController;
        TestController _testController;
        LabTestController _labTestController;

        /// <summary>
        /// The constructor for the ucSearchTest
        /// </summary>
        public ucSearchTest()
        {
            _patient = new Patient();
            _patientVisitController = new PatientVisitController();
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

        private void PopulateComboBoxes()
        {
            try
            {
                List<PatientVisit> patientVisits = _patientVisitController.GetPatientVisits(_patient.PatientId);
                cbVisits.DataSource = patientVisits;
                cbVisits.DisplayMember = "VisitDateAndTime";
                cbVisits.ValueMember = "PatientVisitID";

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

        private void UpdateDataGrid()
        {
            dgvTests.DataSource = _labTestController.GetLabTestByVistIdAndTestCode(int.Parse(cbVisits.SelectedValue.ToString()), int.Parse(cbTests.SelectedValue.ToString()));
            if (dgvTests.SelectedCells.Count > 0 && dgvTests.SelectedCells[3].Value != null)
            {
                lblResult.Text = dgvTests.SelectedCells[3].Value.ToString();
            }
            else
            {
                lblResult.Text = string.Empty;
            }
        }

        private void btnSearchTests_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void ucSearchTest_Load(object sender, EventArgs e)
        {
            PopulateComboBoxes();
        }

        private void dgvTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!string.IsNullOrEmpty(dgvTests.SelectedCells[3].Value.ToString()))
            {
                lblResult.Text = dgvTests.SelectedCells[3].Value.ToString();
            }
        }
    }
}
