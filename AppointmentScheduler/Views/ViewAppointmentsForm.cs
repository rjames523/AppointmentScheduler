using AppointmentScheduler.Connections;
using AppointmentScheduler.Models;
using AppointmentScheduler.Views;
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

        private DbConn conn;
        private bool initialLoad;
        private bool initialSpecificApptsLoad;
        private List<Appointment> appts;
        private List<Customer> customerList;
        private List<Appointment> upcomingSelectedCustAppts;
        private List<Appointment> pastSelectedCustAppts;
        private Customer selectedCustomer;
        private Appointment selectedCustAppt;

        private void ViewAppointmentsForm_Load(object sender, EventArgs e)
        {
            // Initialize variables
            initialLoad = true;
            editApptButton.Enabled = false;
            selectedCustomer = new Customer();
            appts = new List<Appointment>();
            upcomingSelectedCustAppts = new List<Appointment>();
            pastSelectedCustAppts = new List<Appointment>();
            customerList = new List<Customer>();
            conn = new DbConn();
            customersDGV.DataSource = conn.GetAllCustomers();

            foreach (DataGridViewColumn col in customersDGV.Columns)
            {
                // Hide the column for the Address object
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

                    initialSpecificApptsLoad = true;

                    //GetCustomerSpecificAppts() returns two values by using the out keyword
                    upcomingSelectedCustAppts = GetCustomerSpecificAppts(customer);

                    // Swap between past and current appointment views
                    if (upcomingSelectedCustAppts.Count != 0 || pastSelectedCustAppts.Count != 0)
                    {
                        if (viewPastCurrApptsLabel.Text == "View past appointments")
                        {
                            customerSpecificApptsDGV.DataSource = upcomingSelectedCustAppts;
                            customerSpecificApptsDGV.ClearSelection();

                            foreach (DataGridViewColumn col in customerSpecificApptsDGV.Columns)
                            {
                                // Show only AppointmentID, Type, Start, and End in the customerSpecificApptsDGV
                                if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                                    customerSpecificApptsDGV.Columns[col.Name].Visible = false;
                            }
                        }
                        else
                        {
                            customerSpecificApptsDGV.DataSource = pastSelectedCustAppts;
                            customerSpecificApptsDGV.ClearSelection();

                            foreach (DataGridViewColumn col in customerSpecificApptsDGV.Columns)
                            {
                                // Show only AppointmentID, Type, Start, and End in the customerSpecificApptsDGV
                                if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                                    customerSpecificApptsDGV.Columns[col.Name].Visible = false;
                            }
                        }
                    }
                    else
                    {
                        customerSpecificApptsDGV.DataSource = null;
                        editApptButton.Enabled = false;
                    }

                    initialSpecificApptsLoad = false;
                }
            }
        }

        private List<Appointment> GetCustomerSpecificAppts(Customer customer)
        {
            
            appts = conn.GetAllCustomerAppointments();

            // Lambda is used to query the list and return appointments that are in the future, and also another lambda is used to get past appointments
            var upcomingCustAppts = appts.Where(x => ((x.Start >= DateTime.Now) || (x.Start < DateTime.Now && x.End > DateTime.Now)) && (x.CustomerID == customer.CustomerID)).ToList();
            pastSelectedCustAppts = appts.Where(x => (x.End < DateTime.Now) && (x.CustomerID == customer.CustomerID)).ToList();
            return upcomingCustAppts;
        }

        // Get the selected customer from the data grid view
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
            this.Hide();
            // Send the selected customer to the ModifyApptsForm
            ModifyApptsForm modifyApptForm = new ModifyApptsForm(selectedCustAppt);
            modifyApptForm.ShowDialog();
            this.Show();

            customersDGV_SelectionChanged(sender, e);
        }

        // Get the selected customer from the data grid view on the selection changed event
        private void customerSpecificApptsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (!initialSpecificApptsLoad)
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

                    if (customerSpecificApptsDGV.Rows.Count > 0 && viewPastCurrApptsLabel.Text == "View past appointments")
                    {
                        editApptButton.Enabled = true;
                    }
                    else
                    {
                        editApptButton.Enabled = false;
                    }

                    
                }
            }
        }

        private void cancelApptButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Swap between upcoming appointment and past appointment views
        private void viewPastCurrApptsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Unsubscribe from the customerSpecificApptsDGV_SelectionChanged event
            customerSpecificApptsDGV.SelectionChanged -= customerSpecificApptsDGV_SelectionChanged;

            List<Appointment> pastCustAppts = new List<Appointment>();
            if (viewPastCurrApptsLabel.Text == "View past appointments")
            {
                editApptButton.Enabled = false;
                viewPastCurrApptsLabel.Text = "View current appointments";

                if (upcomingSelectedCustAppts.Count != 0 || pastSelectedCustAppts.Count != 0)
                {
                    customerSpecificApptsDGV.DataSource = null;
                    customerSpecificApptsDGV.DataSource = pastSelectedCustAppts;
                    customerSpecificApptsDGV.ClearSelection();

                    foreach (DataGridViewColumn col in customerSpecificApptsDGV.Columns)
                    {
                        // Show only AppointmentID, Type, Start, and End in the customerSpecificApptsDGV
                        if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                            customerSpecificApptsDGV.Columns[col.Name].Visible = false;
                    }
                }
            }
            else if (viewPastCurrApptsLabel.Text == "View current appointments")
            {
                viewPastCurrApptsLabel.Text = "View past appointments";

                if (upcomingSelectedCustAppts.Count != 0 || pastSelectedCustAppts.Count != 0)
                {
                    customerSpecificApptsDGV.DataSource = null;
                    customerSpecificApptsDGV.DataSource = upcomingSelectedCustAppts;
                    customerSpecificApptsDGV.ClearSelection();

                    foreach (DataGridViewColumn col in customerSpecificApptsDGV.Columns)
                    {
                        // Show only AppointmentID, Type, Start, and End in the customerSpecificApptsDGV
                        if (col.Name != "AppointmentID" && col.Name != "Type" && col.Name != "Start" && col.Name != "End")
                            customerSpecificApptsDGV.Columns[col.Name].Visible = false;
                    }
                }
            }

            // Subscribe to the customerSpecificApptsDGV_SelectionChanged event
            customerSpecificApptsDGV.SelectionChanged += customerSpecificApptsDGV_SelectionChanged;
        }

        private void viewByWeekButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarByWeekOrMonthForm calendarByWeekOrMonthForm = new CalendarByWeekOrMonthForm("week");
            calendarByWeekOrMonthForm.ShowDialog();
            this.Show();
        }

        private void viewByMonthButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalendarByWeekOrMonthForm calendarByWeekOrMonthForm = new CalendarByWeekOrMonthForm("month");
            calendarByWeekOrMonthForm.ShowDialog();
            this.Show();
        }
    }
}
