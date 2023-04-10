using CS6232_G2.Controller;
using CS6232_G2.Model;
using CS6232_G2.View;
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
    public partial class VisitsUserControl : UserControl
    {
        private PatientVisitController _visitController;
        private Patient _patient;
        private List<PatientVisit> _visitList;
        private List<PatientVisit> _filteredVisitList;

        public VisitsUserControl()
        {
            InitializeComponent();
            this._visitController = new PatientVisitController();
        }

        private void visitSearchButton_Click(object sender, EventArgs e)
        {
            _filteredVisitList = new List<PatientVisit>();
            foreach (PatientVisit visit in this._visitList)
            {
                if (visit.VisitDateAndTime.Date == this.dateTimePicker.Value.Date)
                {
                    this._filteredVisitList.Add(visit);
                }
            }
            if (_filteredVisitList.Count != 0)
            {
                this.patientVisitBindingSource.DataSource = _filteredVisitList;
            } else
            {
                DialogResult message = MessageBox.Show("There are no visits on the given date");
            }

        }
        public void SetPatient(Patient patient)
        {
            _patient = patient;
        }

        private void VisitsUserControl_Load(object sender, EventArgs e)
        {
            this._visitList = this._visitController.GetPatientVisits(this._patient.PatientId);
            this.patientVisitBindingSource.DataSource = _visitList;
        }

        private void viewVisitButton_Click(object sender, EventArgs e)
        {
            if (this.patientVisitBindingSource.DataSource == this._filteredVisitList)
            {
                PatientVisit selectedVisit = this._filteredVisitList[this.patientVisitDataGridView.SelectedRows[0].Index];
                using (RoutineCheckupForm checkupForm = new RoutineCheckupForm(selectedVisit)) {
                    this.Hide();
                    DialogResult result = checkupForm.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
            } else
            {
                PatientVisit selectedVisit = this._visitList[this.patientVisitDataGridView.SelectedRows[0].Index];
                using (RoutineCheckupForm checkupForm = new RoutineCheckupForm(selectedVisit))
                {
                    this.Hide();
                    DialogResult result = checkupForm.ShowDialog();

                    if (result == DialogResult.Cancel)
                    {
                        this.Show();
                    }
                }
            }
            

            
        }
    }
}
