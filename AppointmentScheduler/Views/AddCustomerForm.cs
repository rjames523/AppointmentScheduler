using AppointmentScheduler.Connections;
using AppointmentScheduler.Models;
using schedulerLoginForm;
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
            // Checks to see if any textbox on the form is null or whitespace
            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text) && x.Name != "address2TextBox") && !string.IsNullOrWhiteSpace(countryComboBox.Text) && !string.IsNullOrWhiteSpace(cityComboBox.Text))
            {
                BuildErrorMessage();
            }
            else
            {
                Address custAddress = new Address();
                custAddress.Address1 =streetAddrTxtBox.Text;
                custAddress.Address2 = address2TextBox.Text;
                custAddress.City.CityID = cityComboBox.SelectedIndex;
                custAddress.LastUpdate = DateTime.Now;
                custAddress.PostalCode = postalCodeTxtBox.Text;
                custAddress.Phone  = phoneTxtBox.Text;
                custAddress.CreateDate = DateTime.Now;
                custAddress.CreatedBy = DbConn.loggedInUser.UserName;
                custAddress.LastUpdatedBy = DbConn.loggedInUser.UserName;

                int countryID = conn.AddCountry(countryComboBox.SelectedItem.ToString());
                int cityID = conn.AddCity(cityComboBox.Text);
                int addressID = conn.AddCustomerAddress(custAddress);

                Customer cust = new Customer();
                cust.CustomerName = firstNameTxtBox.Text.Trim() + " " + lastNameTxtBox.Text.Trim();

                
                Address address = new Address();
                address.Address1 = streetAddrTxtBox.Text;

            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();
            countryComboBox.DataSource = conn.GetAllCountries().Select(x => x.CountryName).ToList();
            cityComboBox.DataSource = conn.GetAllCities().Select(y => y.CityName).ToList();
            this.ActiveControl = firstNameTxtBox;
        }

        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to add customer:\n\n");

            if (string.IsNullOrWhiteSpace(firstNameTxtBox.Text))
            {
                errorBlankInfo.AppendLine("First Name");
            }
            if (string.IsNullOrWhiteSpace(lastNameTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Last Name");
            }
            if (string.IsNullOrWhiteSpace(streetAddrTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Street Address");
            }
            if (string.IsNullOrWhiteSpace(cityComboBox.Text))
            {
                errorBlankInfo.AppendLine("City");
            }
            if (string.IsNullOrWhiteSpace(countryComboBox.Text))
            {
                errorBlankInfo.AppendLine("Country");
            }
            if (string.IsNullOrWhiteSpace(postalCodeTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Postal Code");
            }
            if (string.IsNullOrWhiteSpace(phoneTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Phone");
            }

            MessageBox.Show(errorBlankInfo.ToString(), "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
