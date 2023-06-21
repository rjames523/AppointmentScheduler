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
        private bool formLoaded;

        Appointment selectedCustAppt;

        private void ViewAppointmentsForm_Load(object sender, EventArgs e)
        {
            formLoaded = false;
            conn = new DbConn();
            conn.GetAllCustomers();
            conn.GetAllCustomerAppointments();
            customersDGV.DataSource = Appointment.AllCustomerAppts;
            customersDGV.ClearSelection();
            formLoaded = true;
        }

        private void customersDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (formLoaded)
            {
                Customer customer = GetSelectedCustomer();

                if (customer != null)
                {
                    selectedCustNameTxtBox.Text = customer.CustomerName;

                    List<Appointment> selectedCustomerAppts = GetCustomerSpecificAppts(customer);

                    if (Appointment.AllCustomerAppts.Count == 0)
                    {
                        custApptsListBox.Items.Add("There are no scheduled appointments.");
                    }
                    else
                    {
                        foreach (Appointment appt in selectedCustomerAppts)
                        {
                            custApptsListBox.Items.Add($"{appt.Type}\t{appt.Start.ToShortTimeString()}\t{appt.End.ToShortTimeString()}");
                        }
                    }
                }
                else
                {

                }

                // Stops this block from running again when selection is changed
                formLoaded = false;
            }

            if (custApptsListBox.SelectedIndex > -1)
            {
                selectedCustAppt = Appointment.AllCustomerAppts.Where(x => x.AppointmentID == custApptsListBox.SelectedIndex + 1).First();
            }
        }

        private List<Appointment> GetCustomerSpecificAppts(Customer customer)
        {
            var custAppts = Appointment.AllCustomerAppts.Where(x => x.CustomerID == customer.CustomerID).ToList();
            return custAppts;
        }

        public Customer GetSelectedCustomer()
        {
            Customer selectedCustomer = new Customer();

            foreach (DataGridViewRow row in customersDGV.SelectedRows)
            {
                foreach (DataGridViewColumn col in customersDGV.Columns)
                {
                    if (col.Name == "CustomerID")
                    {
                        selectedCustomer = (Customer)Customer.AllCustomers.Where(x => x.CustomerID == (int)row.Cells[col.Index].Value).Select(x => x).First();
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
    }
}
