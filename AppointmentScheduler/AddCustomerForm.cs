using AppointmentScheduler.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        DbConn conn;

        private void addCustomerButton_Click(object sender, EventArgs e)
        {

            foreach (TextBox control in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(control.Text) || string.IsNullOrWhiteSpace(control.Text))
                {
                    BuildErrorMessage();
                    break;
                }
            }


        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();
            countryComboBox.DataSource = conn.GetAllCountries().Select(x => x.CountryName).ToList();
            this.ActiveControl = firstNameTxtBox;
        }

        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to add customer:\n\n");

            if (firstNameTxtBox.Text == String.Empty)
            {
                errorBlankInfo.AppendLine("First Name");
            }
            if (lastNameTxtBox.Text == String.Empty)
            {
                errorBlankInfo.AppendLine("Last Name");
            }
            if (streetAddrTxtBox.Text == String.Empty)
            {
                errorBlankInfo.AppendLine("Street Address");
            }
            if (cityTxtBox.Text == String.Empty)
            {
                errorBlankInfo.AppendLine("City");
            }
            if (countryComboBox.Text == String.Empty)
            {
                errorBlankInfo.AppendLine("Country");
            }
            if (postalCodeTxtBox.Text == String.Empty)
            {
                errorBlankInfo.AppendLine("Postal Code");
            }
            if (phoneTxtBox.Text == String.Empty)
            {
                errorBlankInfo.AppendLine("Phone");
            }

            MessageBox.Show(errorBlankInfo.ToString(), "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
