using CS6232_G2.Controller;
using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CS6232_G2.View
{
    /// <summary>
    /// Represents a form for conducting routine checkups.
    /// </summary>
    public partial class RoutineCheckupForm : Form
    {
        private TestController _testController;
        private PatientVisitController _patientVisitController;
        private List<Test> _tests;
        private List<LabTest> _orderedTests;
        private Nurse _nurse;
        private NurseController _nurseController;
        private LabTestController _labTestController;
        private Appointment _appointment;
        private PatientVisit _selectedVisit;

        /// <summary>
        /// Constructor to initialize the control
        /// </summary>
        public RoutineCheckupForm(Appointment appointment)
        {
            InitializeComponent();
            InitializeControllers();
            _appointment = appointment;

            try
            {
                _nurse = _nurseController.GetNurseByLogin(LoginDAL.GetCurrentLogin());
                _selectedVisit = _patientVisitController.GetPatientVisitAppointmentId(appointment.AppointmentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            InitializeForData();
        }

        public RoutineCheckupForm(PatientVisit selectedVisit)
        {
            InitializeComponent();
            InitializeControllers();

            this._selectedVisit = selectedVisit;
            InitializeForData();
        }

        private void InitializeControllers()
        {
            _patientVisitController = new PatientVisitController();
            _testController = new TestController();
            _nurseController = new NurseController();
            _labTestController = new LabTestController();
        }

        private void InitializeForData()
        {
            if (_selectedVisit == null || _selectedVisit.PatientVisitID == 0)
            {
                _orderedTests = new List<LabTest>();
                labTestBindingSource.DataSource = _orderedTests;
                submitLabOrderButton.Enabled = false;
                lblSaveFirst.Visible = true;
                return;
            }

            heightTextBox.Text = _selectedVisit.Height.ToString();
            weightTextBox.Text = _selectedVisit.Weight.ToString();
            sysTextBox.Text = _selectedVisit.Systolic.ToString();
            diaTextBox.Text = _selectedVisit.Diastolic.ToString();
            tempTextBox.Text = _selectedVisit.Temperature.ToString();
            pulseTextBox.Text = _selectedVisit.Pulse.ToString();
            symptomsTextBox.Text = _selectedVisit.Symptoms;
            iDiagnosisTextBox.Text = _selectedVisit.InitialDiagnosis;
            fDiagnosesTextBox.Text = _selectedVisit.FinalDiagnosis;

            try
            {
                _orderedTests = _labTestController.GetLabTestByVistId(_selectedVisit.PatientVisitID);
                labTestBindingSource.DataSource = _orderedTests;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void RoutineCheckup_Load(object sender, EventArgs e)
        {
            try
            {
                _tests = this._testController.GetAllTests();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            selectLabTestComboBox.DataSource = this._tests;
            selectLabTestComboBox.DisplayMember = "TestName";
            selectLabTestComboBox.SelectedIndex = 0;
            labTestBindingSource.DataSource = this._orderedTests;
            this.setTestNames();
            this.testDataGridView.AutoGenerateColumns = true;

            CheckIfPastVisit();
        }

        private void CheckIfPastVisit()
        {
            if (_selectedVisit.PatientVisitID > 0 && !string.IsNullOrEmpty(_selectedVisit.FinalDiagnosis))
            {
                DisableForm();
            } else
            {
                this.updateTestButton.Enabled = true;
            }
        }

        private void DisableForm()
        {
            heightTextBox.Enabled = false;
            weightTextBox.Enabled = false;
            sysTextBox.Enabled = false;
            diaTextBox.Enabled = false;
            tempTextBox.Enabled = false;
            pulseTextBox.Enabled = false;
            symptomsTextBox.Enabled = false;
            iDiagnosisTextBox.Enabled = false;
            fDiagnosesTextBox.Enabled = false;
            saveVisitButton.Enabled = false;
            addTestButton.Enabled = false;
            removeTestButton.Enabled = false;
            submitLabOrderButton.Enabled = false;
            testDataGridView.Enabled = false;
            this.updateTestButton.Enabled = false;
        }

        private decimal GetDecimal2(string number, string source)
        {
            try
            {
                decimal value = Decimal.Parse(number);
                if (value < 0)
                {
                    throw new FormatException();
                }
                return Decimal.Round(value, 2);
            }
            catch (Exception)
            {
                throw new FormatException("Please enter a valid " + source);
            }
        }

        private decimal GetDecimal1(string number, string source)
        {
            try
            {
                decimal value = Decimal.Parse(number);
                if (value < 0)
                {
                    throw new FormatException();
                }
                return Decimal.Round(value, 1);
            }
            catch (Exception)
            {
                throw new FormatException("Please enter a valid " + source);
            }
        }
        private int GetInt(string number, string source)
        {
            try
            {
                int id = -1;
                id = Int32.Parse(number);
                if (id < 0)
                {
                    throw new FormatException();
                }
                return id;
            }
            catch (Exception)
            {
                throw new FormatException("Please enter a valid " + source);
            }
        }
        private PatientVisit PatientVisit()
        {
            PatientVisit newVisit = new PatientVisit
            {
                VisitDateAndTime = DateTime.Now,
                Height = GetDecimal2(heightTextBox.Text, "height"),
                Weight = GetDecimal2(weightTextBox.Text, "weight"),
                Systolic = GetInt(sysTextBox.Text, "systolic number"),
                Diastolic = GetInt(diaTextBox.Text, "diastolic number"),
                Temperature = GetDecimal1(tempTextBox.Text, "temperature"),
                Pulse = GetInt(pulseTextBox.Text, "pulse"),
                NurseID = _nurse.NurseId,
                AppointmentID = _appointment != null ? _appointment.AppointmentId : _selectedVisit.AppointmentID,
                AppointmentTime = _appointment.AppointmentTime.HasValue ? _appointment.AppointmentTime.Value : _selectedVisit.AppointmentTime,
                PatientVisitID = _selectedVisit.PatientVisitID
            };

            if (symptomsTextBox.Text.Length > 150)
            {
                DialogResult dialogResult = MessageBox.Show("only 245 letters are allowed for symptoms. Would you like to trim to 245?",
                    "The symptoms description is too big!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.Symptoms = symptomsTextBox.Text.Substring(0, 244);
                    symptomsTextBox.Text = symptomsTextBox.Text.Substring(0, 244);
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (String.IsNullOrEmpty(symptomsTextBox.Text))
            {
                throw new Exception("Please fill out symptoms");
            }
            else
            {
                newVisit.Symptoms = symptomsTextBox.Text;
            }

            if (iDiagnosisTextBox.Text.Length > 245)
            {
                DialogResult dialogResult = MessageBox.Show("only 245 letters are allowed for initial diagnosis. Would you like to trim to 245?",
                    "The description is too long!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.InitialDiagnosis = iDiagnosisTextBox.Text.Substring(0, 244);
                    iDiagnosisTextBox.Text = iDiagnosisTextBox.Text.Substring(0, 244);
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (String.IsNullOrEmpty(iDiagnosisTextBox.Text))
            {
                throw new Exception("Please fill out an initial diagnosis");
            }
            else
            {
                newVisit.InitialDiagnosis = iDiagnosisTextBox.Text;
            }

            if (fDiagnosesTextBox.Text.Length > 45)
            {
                DialogResult dialogResult = MessageBox.Show("only 244 letters are allowed for final diagnosis. Would you like to trim to 245?",
                    "The description is too long!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.FinalDiagnosis = fDiagnosesTextBox.Text.Substring(0, 244);
                    fDiagnosesTextBox.Text = fDiagnosesTextBox.Text.Substring(0, 244);
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (String.IsNullOrEmpty(fDiagnosesTextBox.Text))
            {
                newVisit.FinalDiagnosis = "";
            }
            else
            {
                newVisit.FinalDiagnosis = fDiagnosesTextBox.Text;
            }

            return newVisit;
        }

        private void saveVisitButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmSave = DialogResult.None;

            if (fDiagnosesTextBox.Text.Length > 0)
            {
                foreach (LabTest test in _orderedTests)
                {
                    if (string.IsNullOrEmpty(test.Result))
                    {
                        errorLabel.Text = "All lab results must be entered before adding your final result";
                        return;
                    }
                }

                confirmSave = MessageBox.Show("Once a final diagnosis is entered you cannot make any further changes, would you still like to save",
                    "Are you sure?", MessageBoxButtons.YesNo);
            }

            if (fDiagnosesTextBox.Text.Length == 0 || (fDiagnosesTextBox.Text.Length > 0 && confirmSave.ToString().Equals("Yes", StringComparison.InvariantCultureIgnoreCase)))
            {
                try
                {
                    PatientVisit routineVisit = PatientVisit();

                    if (_patientVisitController.RoutineVisit(routineVisit))
                    {
                        _selectedVisit = _patientVisitController.GetPatientVisitAppointmentId(_appointment.AppointmentId);
                        submitLabOrderButton.Enabled = true;
                        lblSaveFirst.Visible = false;

                        foreach (LabTest test in _orderedTests)
                        {
                            test.PatientVisitId = _selectedVisit.PatientVisitID;
                        }

                        errorLabel.Text = "The checkup has been successfully entered";
                    }
                    else
                    {
                        errorLabel.Text = "The checkup wasn't entered properly. There was an error.";
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }

        private void HandleDecimalInput(TextBox textBox, KeyPressEventArgs e, int maxIntegerDigits, int maxDecimalDigits)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.");
            }
            else
            {
                string text = textBox.Text;

                if (e.KeyChar == '.' && text.Contains('.'))
                {
                    e.Handled = true;
                    MessageBox.Show("Please enter only one decimal point.");
                }
                else if (text.IndexOf('.') != -1 && text.Substring(text.IndexOf('.')).Length > maxDecimalDigits && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show($"Please enter a maximum of {maxDecimalDigits} decimal places.");
                }
                else if (text.IndexOf('.') == -1 && text.Length >= maxIntegerDigits && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show($"Please enter a maximum of {maxIntegerDigits} digits before the decimal point.");
                }
                else if (text.IndexOf('.') != -1 && text.IndexOf('.') > maxIntegerDigits && e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                    MessageBox.Show($"Please enter a maximum of {maxIntegerDigits} digits before the decimal point.");
                }
            }
        }

        private void heightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDecimalInput(heightTextBox, e, 1, 2);
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDecimalInput(weightTextBox, e, 3, 2);
        }

        private void sysTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void diaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void tempTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            HandleDecimalInput(tempTextBox, e, 3, 1);
        }

        private void pulseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void clear()
        {
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            sysTextBox.Text = "";
            diaTextBox.Text = "";
            tempTextBox.Text = "";
            pulseTextBox.Text = "";
            symptomsTextBox.Text = "";
            iDiagnosisTextBox.Text = "";
            fDiagnosesTextBox.Text = "";
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.Text = "";
            LabTest newTest = new LabTest();

            if (this.labTestBindingSource.List.Count == 0)
            {
                newTest.TestCode = this._tests[this.selectLabTestComboBox.SelectedIndex].TestCode;
                newTest.PatientVisitId = this._selectedVisit.PatientVisitID;
                this.labTestBindingSource.Add(newTest);
                return;
            }

            for (int i = 0; i < this.labTestBindingSource.List.Count; i++)
            {
                if (this._orderedTests[i].TestCode == this._tests[this.selectLabTestComboBox.SelectedIndex].TestCode)
                {
                    this.errorLabel.Text = "You may not order duplicate tests.";
                    return;
                }
            }

            newTest.TestCode = this._tests[this.selectLabTestComboBox.SelectedIndex].TestCode;
            newTest.PatientVisitId = this._selectedVisit.PatientVisitID;
            this.labTestBindingSource.Add(newTest);
            this.setTestNames();

        }

        private void removeTestButton_Click(object sender, EventArgs e)
        {
            if (this.labTestBindingSource.List.Count > 0)
            {
                this.labTestBindingSource.RemoveCurrent();
            }
        }

        private void testDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            this.errorLabel.Text = "Please enter a valid Datetime in YYYY-MM-DD format.";
        }

        private void submitLabOrderButton_Click(object sender, EventArgs e)
        {
            string labOrder = "";
            foreach (LabTest labTest in this._orderedTests)
            {
                foreach (Test test in this._tests)
                {
                    if (labTest.TestCode == test.TestCode)
                    {
                        labOrder += test.TestName + "\n";
                    }
                }
            }

            DialogResult result = MessageBox.Show("Are you sure you want to order these tests: \n" + labOrder,
                "Order", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                this.addTestButton.Enabled = false;
                this.removeTestButton.Enabled = false;
                this.selectLabTestComboBox.Enabled = false;
                this.updateTestButton.Enabled = true;
                try
                {
                    _labTestController.OrderLabTest(this._orderedTests);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /*private void testDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.RowIndex > -1)
            {
                testDataGridView.EndEdit();

                LabTest test = this._orderedTests[e.RowIndex];
                test.Normal = test.Normal ?? false;
                if (!string.IsNullOrEmpty(test.Result) && test.Normal != null)
                {
                    test.TestDateTime = DateTime.Now;

                    try
                    {
                        this._labTestController.UpdateLabTestResults(test);
                        errorLabel.Text = "Row Updated";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }*/

        private void testDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            errorLabel.Text = string.Empty;
        }

        private void setTestNames()
        {
            foreach (LabTest labTest in this._orderedTests)
            {
                foreach (Test test in this._tests)
                {
                    if (labTest.TestCode == test.TestCode)
                    {
                        labTest.TestName = test.TestName;
                    }
                }
            }
        }

        private void updateTestButton_Click(object sender, EventArgs e)
        {
            List <LabTest> testsToBeUpdated = new List <LabTest>();
            foreach (LabTest test in this._orderedTests)
            {
                if (test.TestDateTime == null || string.IsNullOrEmpty(test.Result) || test.Normal == null)
                {
                    this.errorLabel.Text = "All test fields must be entered before submitting their results.";
                    return;
                } else if (test.TestDateTime.TimeOfDay == TimeSpan.Zero) 
                {
                    this.errorLabel.Text = "The time must be entered for a test.";
                    return;
                } else 
                {
                    testsToBeUpdated.Add(test);
                }
            }

            try
            {
                foreach (LabTest test in testsToBeUpdated)
                {
                    this._labTestController.UpdateLabTestResults(test);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}

