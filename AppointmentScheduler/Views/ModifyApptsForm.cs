using AppointmentScheduler.Connections;
using AppointmentScheduler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler
{
    public partial class ModifyApptsForm : Form
    {
        public ModifyApptsForm()
        {
            InitializeComponent();
        }

        public ModifyApptsForm(Appointment selectedCustAppt)
        {
            InitializeComponent();
            selectedAppointment = selectedCustAppt;
        }

        private DbConn conn;
        private Appointment selectedAppointment;
        private List<Customer> customers;
        private List<Appointment> appointments;
        DateTime selectedApptTime;

        private void ModifyApptsForm_Load(object sender, EventArgs e)
        {
            // Initialize variables
            conn = new DbConn();
            customers = new List<Customer>();
            appointments = new List<Appointment>();
            apptDateTxtBox.Enabled = false;
            apptStartTimeTxtBox.Enabled = false;
            apptEndTimeTxtBox.Enabled = false;
            Customer cust = new Customer();
            customers = conn.GetAllCustomers();
            appointments = conn.GetAllCustomerAppointments();

            // Load controls on form using the selected appointment from the previous form
            // A lambda is used to load the correct customer name by searching querying the customers list and comparing the customerIDs of each item and the selected appointment
            custNameTxtBox.Text = customers.Where(x => x.CustomerID == selectedAppointment.CustomerID).Select(x => x.CustomerName).FirstOrDefault().ToString();
            titleTxtBox.Text = selectedAppointment.Title;
            contactTxtBox.Text = selectedAppointment.Contact;
            typeTxtBox.Text = selectedAppointment.Type;
            locationTxtBox.Text = selectedAppointment.Location;
            urlTxtBox.Text = selectedAppointment.Url;
            apptDescriptionRTxtBox.Text = selectedAppointment.Description;
            apptDateTxtBox.Text = selectedAppointment.Start.ToShortDateString();
            apptStartTimeTxtBox.Text = selectedAppointment.Start.ToLocalTime().ToShortTimeString();
            apptEndTimeTxtBox.Text = selectedAppointment.End.ToLocalTime().ToShortTimeString();
        }

        private void createAppointmentCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {}

        private void createAppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {}

        private void apptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Assign the selected date to the selectedApptTime variable
            selectedApptTime = apptDatePicker.Value;
            if (apptDatePicker.Value != null)
            {
                selectedApptTime = apptDatePicker.Value;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateApptButton_Click(object sender, EventArgs e)
        {
            // Check if the selected date and time is correct
            schedApptStartTimePicker.Checked = true;
            DateTime selectedDate = DateTime.Parse(apptDatePicker.Text);
            DateTime selectedStartTime = DateTime.Parse(apptDatePicker.Text + " " + schedApptStartTimePicker.Text);
            DateTime selectedEndTime = DateTime.Parse(apptDatePicker.Text + " " + schedApptEndTimePicker.Text);
            DateTime currentTime = DateTime.Parse(DateTime.Now.ToShortTimeString());


            // Check to see if the selected date is in the past, or if the time is earlier in the day; else, verify appointment information and schedule the appointment
            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("The selected date is invalid.\nPlease select a future date.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (selectedStartTime < currentTime || selectedEndTime < currentTime)
            {
                MessageBox.Show("The selected start and/or end time is invalid.\nPlease select a future timeframe.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (schedApptStartTimePicker.Value > schedApptEndTimePicker.Value)
                {
                    MessageBox.Show("The appointment start time must be before the end time.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    VerifyAppointmentInfo();
                }
            }
        }

        // Verifies all controls are filled, checks if times are available for sheduling, and schedules the appointment
        private void VerifyAppointmentInfo()
        {
            schedApptStartTimePicker.Checked = true;

            if (string.IsNullOrEmpty(titleTxtBox.Text)
                    || string.IsNullOrEmpty(apptDescriptionRTxtBox.Text)
                    || string.IsNullOrEmpty(contactTxtBox.Text)
                    || string.IsNullOrEmpty(typeTxtBox.Text)
                    || string.IsNullOrEmpty(locationTxtBox.Text)
                    || string.IsNullOrEmpty(urlTxtBox.Text))
            {
                BuildErrorMessage();
            }
            else
            {
                try
                {
                    Appointment modifiedAppt = new Appointment();

                    string startDateTimeString = apptDatePicker.Text + " " + schedApptStartTimePicker.Text;
                    string endDateTimeString = apptDatePicker.Text + " " + schedApptEndTimePicker.Text;

                    if (!DateTime.TryParse(startDateTimeString, out DateTime startTime) || !DateTime.TryParse(endDateTimeString, out DateTime endTime))
                    {
                        MessageBox.Show("The date and/or time you entered was invalid. Please try again.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        modifiedAppt.Start = DateTime.Parse(startDateTimeString);
                        modifiedAppt.End = DateTime.Parse(endDateTimeString);

                        if (modifiedAppt.Start.Hour < 8)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (modifiedAppt.Start.Hour >= 17 && modifiedAppt.Start.Minute > 0)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (modifiedAppt.End.Hour < 8)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (modifiedAppt.End.Hour >= 17 && modifiedAppt.End.Minute > 0)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (modifiedAppt.Start.DayOfWeek == DayOfWeek.Sunday || modifiedAppt.Start.DayOfWeek == DayOfWeek.Saturday)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            var overlappingAppts = conn.GetAllCustomerAppointments().Where(x => (modifiedAppt.Start >= x.Start) && (modifiedAppt.Start <= x.End)).ToList();

                            if (overlappingAppts.Count > 0)
                            {
                                MessageBox.Show("The chosen time has already been taken.\nPlease select a different time.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                            else
                            {
                                modifiedAppt.AppointmentID = selectedAppointment.AppointmentID;

                                // Lambda expression is used to retrieve the customer ID of the object in the customers list that has a name matching that of the Customer Name Combo Box; the first element is returned if found, if not, a default value is found
                                modifiedAppt.CustomerID = customers.Where(x => x.CustomerName == custNameTxtBox.Text).Select(x => x.CustomerID).FirstOrDefault();

                                modifiedAppt.Description = apptDescriptionRTxtBox.Text;
                                modifiedAppt.Title = titleTxtBox.Text;
                                modifiedAppt.Contact = contactTxtBox.Text;
                                modifiedAppt.Location = locationTxtBox.Text;
                                modifiedAppt.Type = typeTxtBox.Text;
                                modifiedAppt.Url = urlTxtBox.Text;

                                conn.UpdateUser(DbConn.loggedInUser);
                                conn.UpdateCustomer(modifiedAppt.CustomerID, customers);
                                conn.UpdateAppointment(modifiedAppt, custNameTxtBox.Text);

                                MessageBox.Show($"The appointment information for {custNameTxtBox.Text} was updated successfully.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred when updating the appointment information.\n{ex}", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Builds an error message based on which controls have no text
        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to schedule an appointment:\n\n");

            if (string.IsNullOrWhiteSpace(custNameTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Customer Name");
            }
            if (string.IsNullOrWhiteSpace(titleTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Title");
            }
            if (string.IsNullOrWhiteSpace(apptDescriptionRTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Description");
            }
            if (string.IsNullOrWhiteSpace(contactTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Contact");
            }
            if (string.IsNullOrWhiteSpace(locationTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Location");
            }
            if (string.IsNullOrWhiteSpace(typeTxtBox.Text))
            {
                errorBlankInfo.AppendLine("Type");
            }
            if (string.IsNullOrWhiteSpace(urlTxtBox.Text))
            {
                errorBlankInfo.AppendLine("URL");
            }
            if (string.IsNullOrWhiteSpace(apptDatePicker.Text))
            {
                errorBlankInfo.AppendLine("Appt. Date");
            }
            if (string.IsNullOrWhiteSpace(schedApptStartTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appt. Start Time");
            }
            if (string.IsNullOrWhiteSpace(schedApptEndTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appt. End Time");
            }

            MessageBox.Show(errorBlankInfo.ToString(), "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void apptDatePicker_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
