using CS6232_G2.Controller;
using CS6232_G2.DAL;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace CS6232_G2.View
{
    public partial class RoutineCheckupForm : Form
    {
        private readonly RoutineCheckController _routineCheckController;
        private PatientVisit visit;
        private TestController _testController;
        private List<Test> _tests;
        private List<LabTest> _orderedTests;
        private Nurse _nurse;
        private NurseController _nurseController;
        private LabTestController _labTestController;

        public RoutineCheckupForm()
        {
            InitializeComponent();
            _routineCheckController = new RoutineCheckController();
            visit = new PatientVisit();
            _testController = new TestController();
            _orderedTests = new List<LabTest>();
            _nurseController = new NurseController();
            _nurse = _nurseController.GetNurseByLogin(LoginDAL.GetCurrentLogin());
            _labTestController = new LabTestController();
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
                /*  VisitDateAndTime = DateTime.Now,
                  Height = 25,
                  Weight = 23,
                  Systolic = 12,  
                  Diastolic = 25,
                  Temperature = 123,
                  Pulse = 89,*/
                NurseID = _nurse.NurseId,
                AppointmentID = 1,
                AppointmentTime = new DateTime(2023, 3, 15, 10, 0, 0)
            };

            if (symptomsTextBox.Text.Length > 150)
            {
                DialogResult dialogResult = MessageBox.Show("only 150 letters are allowed for symptoms. Would you like to trim to 150?",
                    "The symptoms description is too big!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.Symptoms = symptomsTextBox.Text.Substring(0, 149);
                    symptomsTextBox.Text = symptomsTextBox.Text.Substring(0, 149);
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

            if (iDiagnosisTextBox.Text.Length > 45)
            {
                DialogResult dialogResult = MessageBox.Show("only 45 letters are allowed for initial diagnosis. Would you like to trim to 45?",
                    "The description is too long!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.InitialDiagnosis = iDiagnosisTextBox.Text.Substring(0, 44);
                    iDiagnosisTextBox.Text = iDiagnosisTextBox.Text.Substring(0, 44);
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
                DialogResult dialogResult = MessageBox.Show("only 44 letters are allowed for final diagnosis. Would you like to trim to 45?",
                    "The description is too long!", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    newVisit.FinalDiagnosis = fDiagnosesTextBox.Text.Substring(0, 44);
                    fDiagnosesTextBox.Text = fDiagnosesTextBox.Text.Substring(0, 44);
                }
                else
                {
                    throw new Exception();
                }
            }
            else if (String.IsNullOrEmpty(fDiagnosesTextBox.Text))
            {
                newVisit.FinalDiagnosis = "Empty!";
            }
            else
            {
                newVisit.FinalDiagnosis = fDiagnosesTextBox.Text;
            }

            return newVisit;
        }

        private void saveVisitButton_Click(object sender, EventArgs e)
        {
            try
            {
                PatientVisit routineVisit = PatientVisit();

                if (_routineCheckController.RoutineVisit(routineVisit))
                {
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

        private void HandleDecimalInput(System.Windows.Forms.TextBox textBox, KeyPressEventArgs e, int maxIntegerDigits, int maxDecimalDigits)
        {
            // Check if the key is a valid numeric key (0-9), decimal point symbol ('.'), or Backspace key
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
            HandleDecimalInput(heightTextBox, e, 3, 2);
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
        private void HandleTextInput(System.Windows.Forms.TextBox textBox, KeyPressEventArgs e, int maxChars)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Only letters, digits, '-', and '/' are allowed.");
            }
            else if (textBox.Text.Length >= maxChars && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show($"Please enter no more than {maxChars} characters.");
            }
        }

        private void pulseTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Please enter only numbers.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
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

        private void RoutineCheckup_Load(object sender, EventArgs e)
        {
            _tests = this._testController.GetAllTests();
            selectLabTestComboBox.DataSource = this._tests;
            selectLabTestComboBox.DisplayMember = "TestName";
            selectLabTestComboBox.SelectedIndex = 0;
            labTestBindingSource.DataSource = this._orderedTests;
            this.testDataGridView.AutoGenerateColumns = true;
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.Text = "";
            LabTest newTest = new LabTest();

            if (this.labTestBindingSource.List.Count == 0)
            {
                newTest.TestCode = this._tests[this.selectLabTestComboBox.SelectedIndex].TestCode;
                newTest.PatientVisitId = this.visit.PatientVisitID;
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
            newTest.PatientVisitId = this.visit.PatientVisitID;
            this.labTestBindingSource.Add(newTest);
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
            foreach (LabTest labTest in this._orderedTests) {
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
                foreach (LabTest test in this._orderedTests)
                {
                    _labTestController.OrderLabTest(test);
                }
            }
            if (result == DialogResult.Cancel)
            {

            }
        }
    }
}

