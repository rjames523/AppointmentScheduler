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

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();
            this.ActiveControl = custNameTxtBox;

        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            // Checks to see if any textbox on the form is null or whitespace
            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text) && x.Name != "address2TextBox"))
            {
                BuildErrorMessage();
            }
            else
            {
                try
                {
                    List<Customer> customers = new List<Customer>();
                    customers = conn.GetAllCustomers();

                    int countryId = conn.GetAllCountries().Count + 1;

                    // Adds customer information to the customer address object using form control values
                    Address custAddress = new Address();
                    custAddress.AddressID = conn.GetAddressCount();
                    custAddress.Address1 = streetAddrTxtBox.Text;
                    custAddress.Address2 = address2TextBox.Text;
                    custAddress.City.CityID = conn.GetAllCities().Count + 1;
                    custAddress.LastUpdate = DateTime.Now;
                    custAddress.PostalCode = postalCodeTxtBox.Text;
                    custAddress.Phone = phoneTxtBox.Text;
                    custAddress.CreateDate = DateTime.Now;
                    custAddress.CreatedBy = DbConn.loggedInUser.UserName;
                    custAddress.LastUpdatedBy = DbConn.loggedInUser.UserName;

                    // Methods for adding country, city, and address are called to satisfy foreign key constraints
                    conn.AddCountry(countryId, countryTextBox.Text);
                    conn.AddCity(custAddress.City.CityID, countryId, cityTextBox.Text);
                    conn.AddCustomerAddress(custAddress, customers);

                    // A new customer is created using remaining control values and the custAddress object
                    Customer cust = new Customer()
                    {
                        CustomerID = Customer.AllCustomers.Count + 1,
                        CustomerName = custNameTxtBox.Text,
                        Active = true,
                        Address = custAddress,
                        CreateDate = DateTime.Now.ToUniversalTime(),
                        CreatedBy = DbConn.loggedInUser.UserName,
                        LastUpdate = DateTime.Now.ToUniversalTime(),
                        LastUpdatedBy = DbConn.loggedInUser.UserName
                    };

                    // The customer is added to the database
                    conn.AddCustomer(cust);

                    MessageBox.Show("Customer has been added successfully.", "The Scheduler - Modify Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
