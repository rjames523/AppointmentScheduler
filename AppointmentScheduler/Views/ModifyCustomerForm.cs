using AppointmentScheduler.Connections;
using AppointmentScheduler.Models;
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
    public partial class ModifyCustomerForm : Form
    {
        public Customer selectedCustomer;
        private DbConn conn;

        public ModifyCustomerForm()
        {
            InitializeComponent();
        }

        public ModifyCustomerForm(Customer selectedCustomer)
        {
            this.selectedCustomer = selectedCustomer;
            InitializeComponent();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            // Checks to see if any textbox on the form is null or whitespace
            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text) && x.Name != "address2TextBox") && !string.IsNullOrWhiteSpace(countryComboBox.Text) && !string.IsNullOrWhiteSpace(cityComboBox.Text))
            {
                BuildErrorMessage();
            }
            else
            {
                selectedCustomer.CustomerName = custNameTxtBox.Text.Trim();
                selectedCustomer.Address.Address1 = streetAddrTxtBox.Text.Trim();
                selectedCustomer.Address.Address2 = address2TextBox.Text.Trim();
                selectedCustomer.Address.PostalCode = postalCodeTxtBox.Text.Trim();
                selectedCustomer.Address.Phone = phoneTxtBox.Text.Trim();
                selectedCustomer.LastUpdate = DateTime.Now.ToUniversalTime();
                selectedCustomer.LastUpdatedBy = DbConn.loggedInUser.UserName;
                selectedCustomer.Active = activeCheckBox.Checked;

                selectedCustomer.Address.City.Country.CountryID = countryComboBox.SelectedIndex + 1;
                selectedCustomer.Address.City.CityID = cityComboBox.SelectedIndex + 1;


                conn.UpdateCustomerCountry(selectedCustomer.Address.City.Country.CountryID, countryComboBox.SelectedItem.ToString());
                conn.UpdateCustomerCity(selectedCustomer.Address.City.CityID, selectedCustomer.Address.City.Country.CountryID, cityComboBox.Text);
                conn.UpdateAddress(selectedCustomer);

                conn.UpdateCustomer(selectedCustomer);

                MessageBox.Show("Customer information has been updated successfully.", "The Scheduler - Modify Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void ModifyCustomerForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();
            countryComboBox.DataSource = conn.GetAllCountries().Select(x => x.CountryName).ToList();
            cityComboBox.DataSource = conn.GetAllCities().Select(x => x.CityName).ToList();

            custNameTxtBox.Text = selectedCustomer.CustomerName;
            streetAddrTxtBox.Text = selectedCustomer.Address.Address1;
            address2TextBox.Text = selectedCustomer.Address.Address2;
            postalCodeTxtBox.Text = selectedCustomer.Address.PostalCode;
            phoneTxtBox.Text = selectedCustomer.Address.Phone;
            activeCheckBox.Checked = selectedCustomer.Active;

            // Set the selected item in the city and country combo boxes based on the customer's current city and country
            countryComboBox.SelectedIndex = conn.GetAllCountries().Where(y => selectedCustomer.Address.City.Country.CountryID == y.CountryID).Select(y => y.CountryID - 1).First();
            cityComboBox.SelectedIndex = conn.GetAllCities().Where(y => selectedCustomer.Address.City.CityID == y.CityID).Select(y => y.CityID - 1).First();

            this.ActiveControl = custNameTxtBox;
        }

        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to add customer:\n\n");

            if (string.IsNullOrWhiteSpace(custNameTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Customer Name");
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
