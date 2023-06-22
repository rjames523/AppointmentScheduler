using AppointmentScheduler.Connections;
using AppointmentScheduler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler
{
    public partial class ViewAppointmentsForm : Form
    {
        public ViewAppointmentsForm()
        {
            InitializeComponent();
        }

        DbConn conn;
        private bool initialLoad;
        List<Appointment> appts;
        List<Customer> customerList;
        Customer selectedCustomer;
        Appointment selectedCustAppt;

        private void ViewAppointmentsForm_Load(object sender, EventArgs e)
        {
            initialLoad = true;
            editApptButton.Enabled = false;
            selectedCustomer = new Customer();
            appts = new List<Appointment>();
            customerList = new List<Customer>();
            conn = new DbConn();
            customersDGV.DataSource = conn.GetAllCustomers();

            foreach (DataGridViewColumn col in customersDGV.Columns)
            {
                if (col.Name == "Address")
                   customersDGV.Columns[col.Name].Visible = false;
            }

            customersDGV.ClearSelection();
            initialLoad = false;
        }

        private void customersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (!initialLoad)
            {
                Customer customer = GetSelectedCustomer();

                if (customer != null)
                {
                    selectedCustNameTxtBox.Text = customer.CustomerName;

                    //customerSpecificApptsDGV.DataSource = null;

                    List<Appointment> selectedCustomerAppts = GetCustomerSpecificAppts(customer);

                    if (selectedCustomerAppts.Count != 0)
                    {

                        customerSpecificApptsDGV.DataSource = selectedCustomerAppts;
                        customerSpecificApptsDGV.ClearSelection();

                        foreach (DataGridViewColumn col in customerSpecificApptsDGV.Columns)
                        {
                            
                            if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                                customerSpecificApptsDGV.Columns[col.Name].Visible = false;
                        }
                        editApptButton.Enabled = true;
                    }
                    else
                    {
                        editApptButton.Enabled = false;
                    }
                }
                else
                {

                }

                // Stops this block from running again when selection is changed
                //initialLoad = true;
            }

            
            
        }

        private List<Appointment> GetCustomerSpecificAppts(Customer customer)
        {
            
            appts = conn.GetAllCustomerAppointments();
            var custAppts = appts.Where(x => x.CustomerID == customer.CustomerID).ToList();
            return custAppts;
        }

        public Customer GetSelectedCustomer()
        {
            
            customerList = new List<Customer>();
            customerList = conn.GetAllCustomers();

            foreach (DataGridViewRow row in customersDGV.SelectedRows)
            {
                foreach (DataGridViewColumn col in customersDGV.Columns)
                {
                    if (col.Name == "CustomerID")
                    {
                        selectedCustomer = customerList.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                    }
                }
            }

            return selectedCustomer;
        }

        private void editApptButton_Click(object sender, EventArgs e)
        {
            ModifyApptsForm modifyApptForm = new ModifyApptsForm(selectedCustAppt);
            Hide();
            modifyApptForm.ShowDialog();
            this.Show();
        }

        private void custApptsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (custApptsListBox.SelectedIndex > -1)
            //{
            //    selectedCustAppt = appts.Where(x => x.AppointmentID == (custApptsListBox.SelectedIndex + 1) && x.CustomerID == selectedCustomer.CustomerID).First();
            //}
        }

        private void customerSpecificApptsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (customerSpecificApptsDGV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in customerSpecificApptsDGV.SelectedRows)
                {
                    foreach (DataGridViewColumn col in customerSpecificApptsDGV.Columns)
                    {
                        if (col.Name == "AppointmentID")
                        {
                            selectedCustAppt = appts.Where(x => x.AppointmentID == (int)row.Cells[col.Index].Value).Select(x => x).First();
                        }
                    }
                }
            }
        }

        private void cancelApptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
