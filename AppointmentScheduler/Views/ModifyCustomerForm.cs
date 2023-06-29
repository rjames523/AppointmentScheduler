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
            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text) && x.Name != "address2TextBox"))
            {
                BuildErrorMessage();
            }
            else
            {
                // The selected customer's information is overwritten with data from the textboxes on the form
                selectedCustomer.CustomerName = custNameTxtBox.Text.Trim();
                selectedCustomer.Address.Address1 = streetAddrTxtBox.Text.Trim();
                selectedCustomer.Address.Address2 = address2TextBox.Text.Trim();
                selectedCustomer.Address.PostalCode = postalCodeTxtBox.Text.Trim();
                selectedCustomer.Address.Phone = phoneTxtBox.Text.Trim();
                selectedCustomer.LastUpdate = DateTime.Now.ToUniversalTime();
                selectedCustomer.LastUpdatedBy = DbConn.loggedInUser.UserName;
                selectedCustomer.Active = activeCheckBox.Checked;

                selectedCustomer.Address.City.Country.CountryID = conn.GetAllCountries().Where(x => x.CountryName == countryTextBox.Text).Select(x => x.CountryID).FirstOrDefault();
                selectedCustomer.Address.City.CityID = conn.GetAllCities().Where(x => x.CityName == cityTextBox.Text).Select(x => x.CityID).FirstOrDefault(); ;

                // Call the update methods for country, city, address, and customer to satisfy foreign key contraints
                conn.UpdateCustomerCountry(selectedCustomer.Address.City.Country.CountryID, countryTextBox.Text);
                conn.UpdateCustomerCity(selectedCustomer.Address.City.CityID, selectedCustomer.Address.City.Country.CountryID, cityTextBox.Text);
                conn.UpdateAddress(selectedCustomer);

                conn.UpdateCustomer(selectedCustomer);

                MessageBox.Show("Customer information has been updated successfully.", "The Scheduler - Modify Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
        }

        private void ModifyCustomerForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();

            // Fill countryTextBox and cityTextBoxes
            // Lamda is used to query the list returned from GetAllCountries and find where the countryID is equal to the selectedCustomer's countryID, the country name is selected based of the country ID value.
            countryTextBox.Text = conn.GetAllCountries().Where(x => x.CountryID == selectedCustomer.Address.City.Country.CountryID).Select(x => x.CountryName).FirstOrDefault();

            // Lamda is used to query the list returned from GetAllCities and find where the cityID is equal to the selectedCustomer's cityID, the city name is selected based of the city ID value.
            cityTextBox.Text = conn.GetAllCities().Where(x => x.CityID == selectedCustomer.Address.City.CityID).Select(x => x.CityName).FirstOrDefault();

            // The selected customer's information is loaded into the textboxes on the form
            custNameTxtBox.Text = selectedCustomer.CustomerName;
            streetAddrTxtBox.Text = selectedCustomer.Address.Address1;
            address2TextBox.Text = selectedCustomer.Address.Address2;
            postalCodeTxtBox.Text = selectedCustomer.Address.PostalCode;
            phoneTxtBox.Text = selectedCustomer.Address.Phone;
            activeCheckBox.Checked = selectedCustomer.Active;

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
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                errorBlankInfo.AppendLine("City");
            }
            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
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
