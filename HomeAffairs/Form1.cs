using System;
using System.Windows.Forms;

namespace HomeAffairsDigitalIdentityProcessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbCitizenship.Items.AddRange(new string[]
            {
                "South African",
                "Permanent Resident",
                "Visitor"
            });
            cmbCitizenship.SelectedIndex = 0;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string idNumber = txtID.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem != null
                ? cmbCitizenship.SelectedItem.ToString()
                : "South African";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Please enter both name and ID number.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenship);
            lblValidationResult.Text = profile.ValidateID();
        }

        private void btnGenerateProfile_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string idNumber = txtID.Text.Trim();
            string citizenship = cmbCitizenship.SelectedItem != null
                ? cmbCitizenship.SelectedItem.ToString()
                : "South African";

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Please enter both name and ID number.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenship);
            string validationResult = profile.ValidateID();
            string timestamp = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            // UPDATED in v2.0: includes Gender field and aligned labels
            txtOutput.Text =
                "==== DIGITAL CITIZEN SUMMARY v2.0 ====" + Environment.NewLine +
                "Name          : " + profile.FullName + Environment.NewLine +
                "ID Number     : " + profile.IDNumber + Environment.NewLine +
                "Age           : " + profile.Age + Environment.NewLine +
                "Gender        : " + profile.Gender + Environment.NewLine +   // NEW in v2.0
                "Citizenship   : " + profile.CitizenshipStatus + Environment.NewLine +
                "Validation    : " + validationResult + Environment.NewLine +
                "Processed at  : Home Affairs Digital Desk" + Environment.NewLine +
                "Timestamp     : " + timestamp;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}