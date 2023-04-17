using CS6232_G2.Controller;
using CS6232_G2.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CS6232_G2.UserControls
{
    /// <summary>
    /// Nurse user control will allow admin users to search and perform CRUD on nurses table
    /// </summary>
    public partial class ucSearchNurse : UserControl
    {
        private NurseController _nurseUserController;

        /// <summary>
        /// Initializes the component
        /// </summary>
        public ucSearchNurse()
        {
            InitializeComponent();
            _nurseUserController = new NurseController();
            dgNurses.AutoGenerateColumns = false;
        }

        private void radFullName_CheckedChanged(object sender, EventArgs e)
        {
            txtFirstName.Enabled = true;
            txtLastName.Enabled = true;
            dtDOB.Enabled = false;
            txtFirstName.Focus();
            ClearForm();
        }

        private void radDOB_CheckedChanged(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = false;
            dtDOB.Enabled = true;
            dtDOB.Focus();
            ClearForm();
        }

        private void radDOBAndLastName_CheckedChanged(object sender, EventArgs e)
        {
            txtFirstName.Enabled = false;
            txtLastName.Enabled = true;
            dtDOB.Enabled = true;
            txtLastName.Focus();
            ClearForm();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void dtDOB_ValueChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            dtDOB.Value = DateTime.Now;
            dgNurses.DataSource = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime? dob = null;

            if (!radFullName.Checked)
            {
                dob = dtDOB.Value;
            }

            if (IsFormValid())
            {
                try
                {
                    List<Nurse> nurses = _nurseUserController.GetNurseByCriteria(txtFirstName.Text.Trim(), txtLastName.Text.Trim(), dob);
                    dgNurses.DataSource = nurses;

                    if (nurses == null || nurses.Count == 0)
                    {
                        MessageBox.Show("No nurses found with the criteria entered", "No Result");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private bool IsFormValid()
        {
            if (radFullName.Checked)
            {
                if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
                {
                    ShowError("Please enter a first name");
                    txtFirstName.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
                {
                    ShowError("Please enter a last name");
                    txtLastName.Focus();
                    return false;
                }
            }
            else if (radDOB.Checked)
            {
                if (dtDOB.Value > DateTime.Now)
                {
                    ShowError("Invalid Date of birth");
                    dtDOB.Focus();
                    return false;
                }
            }
            else if (radDOBAndLastName.Checked)
            {
                if (dtDOB.Value > DateTime.Now)
                {
                    ShowError("Invalid Date of birth");
                    dtDOB.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
                {
                    ShowError("Please enter a last name");
                    txtLastName.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ShowError(string message)
        {
            lblError.Text = message;
        }
    }
}
