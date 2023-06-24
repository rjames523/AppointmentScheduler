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
    public partial class ViewCustomersForm : Form
    {
        public ViewCustomersForm()
        {
            InitializeComponent();
        }

        Customer customer;
        List<Customer> customers;

        DbConn conn;

        private void ViewCustomersForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();       
            customer = new Customer();
            customers = conn.GetAllCustomers();
            customersDGV.DataSource = customers;
            foreach (DataGridViewColumn col in customersDGV.Columns)
            {
                // Hides column for Address object from view
                if (col.Name == "Address")
                    customersDGV.Columns[col.Name].Visible = false;
            }
            customersDGV.ClearSelection();
            editCustomerButton.Enabled = false;

            if (customersDGV.SelectedRows.Count > 0)
            {
                editCustomerButton.Enabled = true;
            }
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = new Customer();

            foreach (DataGridViewRow row in customersDGV.SelectedRows)
            {
                foreach (DataGridViewColumn col in customersDGV.Columns)
                {
                    if(col.Name == "CustomerID")
                    {
                        selectedCustomer = (Customer)customers.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                    }
                }
                //selectedCustomer = row.DataBoundItem as Customer;
                
                ModifyCustomerForm modifyCustForm = new ModifyCustomerForm(selectedCustomer);
                Hide();
                modifyCustForm.ShowDialog();
                customersDGV.ClearSelection();
                this.Show();
            }
        }

        private void scheduleAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleAppointmentForm scheduleApptForm = new ScheduleAppointmentForm();
            scheduleApptForm.ShowDialog();
            this.Show();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Are you sure you want to delete this customer?","The Scheduler - View Customers",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                // delete selected row (cast as Customer object)
                Customer selectedCustomer = new Customer();

                foreach (DataGridViewRow row in customersDGV.SelectedRows)
                {
                    foreach (DataGridViewColumn col in customersDGV.Columns)
                    {
                        if (col.Name == "CustomerID")
                        {
                            selectedCustomer = (Customer)customers.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                        }
                    }
                    //selectedCustomer = row.DataBoundItem as Customer;

                    conn.DeleteCustomerData(selectedCustomer);

                    MessageBox.Show("The customer has been deleted successfully.", "The Scheduler - View Customers", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }

                // Clears/refreshes the data grid view to show new customers
                customersDGV.DataSource = null;
                customersDGV.Rows.Clear();
                conn.GetAllCustomers();
                customersDGV.Update();
                customersDGV.DataSource = Customer.AllCustomers;
            }
        }

        private void customersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (customersDGV.SelectedRows.Count > 0)
            {
                editCustomerButton.Enabled = true;
            }
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();

            // Clears/refreshes the data grid view to show new customers

            customer.NotifyPropertyChanged();
            
            customersDGV.DataSource = null;
            customersDGV.Rows.Clear();
            customers = conn.GetAllCustomers();
            customersDGV.Update();
            customersDGV.DataSource = customers;

            foreach (DataGridViewColumn col in customersDGV.Columns)
            {
                // Hides column for Address object from view
                if (col.Name == "Address")
                    customersDGV.Columns[col.Name].Visible = false;
            }

            this.Show();

        }
    }
}
