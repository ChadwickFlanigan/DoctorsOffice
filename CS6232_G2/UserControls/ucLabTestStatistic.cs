using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    /// <summary>
    /// class creating the LabTestStatistic user control
    /// </summary>
    public partial class ucLabTestStatistic : UserControl
    {
        private LabTestController _labTestController;
        private List<LabTestStatistic> _testStatisticList;

        /// <summary>
        /// constructor for the user control
        /// </summary>
        public ucLabTestStatistic()
        {
            InitializeComponent();
            this._labTestController = new LabTestController();
            this._testStatisticList = new List<LabTestStatistic>();
        }

        private void getStatsButton_Click(object sender, EventArgs e)
        {
            this.errorLabel.Text = string.Empty;
            
            this._testStatisticList = this._labTestController.GetLabTestStatistics(this.startDateTimePicker.Value, this.endDateTimePicker.Value);
            this.labTestStatisticBindingSource.DataSource = this._testStatisticList;
            
        }
    }
}
