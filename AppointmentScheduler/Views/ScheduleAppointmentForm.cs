﻿using AppointmentScheduler.Connections;
using AppointmentScheduler.Models;
using schedulerLoginForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler
{
    public partial class ScheduleAppointmentForm : Form
    {
        public ScheduleAppointmentForm()
        {
            InitializeComponent();
            this.selectedCustomer = new Customer();
            this.directedFromLandingForm = true;
        }

        public ScheduleAppointmentForm(Customer selectedCustomer)
        {
            InitializeComponent();
            this.selectedCustomer = selectedCustomer;
            this.directedFromLandingForm = false;
        }

        private DbConn conn;
        private Customer selectedCustomer;
        private List<Customer> customers;
        private List<Appointment> appointments;
        private bool directedFromLandingForm;

        private void createAppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
        }

        private void customerNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CreateAppointmentForm_Load(object sender, EventArgs e)
        {
            schedApptStartTimePicker.Checked = true;
            schedApptEndTimePicker.Checked = true;

            conn = new DbConn();
            customers = new List<Customer>();
            appointments = new List<Appointment>();
            customers = conn.GetAllCustomers();
            appointments = conn.GetAllCustomerAppointments();

            custNameComboBox.DataSource = customers.Select(x => x.CustomerName).ToList();

            if (!directedFromLandingForm)
            {
                custNameComboBox.SelectedItem = customers.Where(x => x.CustomerID == selectedCustomer.CustomerID).Select(x => (x.CustomerName)).FirstOrDefault();
            }
        }

        private void scheduleAppointmentButton_Click(object sender, EventArgs e)
        {
            schedApptStartTimePicker.Checked = true;
            DateTime selectedDate = DateTime.Parse(schedApptDatePicker.Text);
            DateTime selectedStartTime = DateTime.Parse(schedApptDatePicker.Text + " " + schedApptStartTimePicker.Text);
            DateTime selectedEndTime = DateTime.Parse(schedApptDatePicker.Text + " " + schedApptEndTimePicker.Text);

            if (selectedDate < DateTime.Now.Date)
            {
                MessageBox.Show("You must select a future date.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (selectedStartTime < DateTime.Now || selectedEndTime < DateTime.Now)
            {
                MessageBox.Show("You must select a future timeframe.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (schedApptStartTimePicker.Value > schedApptEndTimePicker.Value)
                {
                    MessageBox.Show("The appointment start time must be before the end time.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    var isTimeAvailable = true;

                    foreach (Appointment appt in appointments)
                    {
                        if (schedApptStartTimePicker.Value >= appt.Start && schedApptEndTimePicker.Value <= appt.End)
                        {
                            isTimeAvailable = false;
                            break;
                        }
                    }

                    if (isTimeAvailable)
                    {
                        VerifyAppointmentInfo();

                    }
                    else
                    {
                        MessageBox.Show("The selected time frame is not available. Please select a different time frame.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void VerifyAppointmentInfo()
        {
            schedApptStartTimePicker.Checked = true;
            //this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text))
            if (!string.IsNullOrWhiteSpace(titleTxtBox.Text)
                    && !string.IsNullOrWhiteSpace(apptDescriptionRTxtBox.Text)
                    && !string.IsNullOrWhiteSpace(contactTxtBox.Text)
                    && !string.IsNullOrWhiteSpace(typeTxtBox.Text)
                    && !string.IsNullOrWhiteSpace(urlTxtBox.Text)
                    && !string.IsNullOrWhiteSpace(schedApptStartTimePicker.Text) 
                    && !string.IsNullOrWhiteSpace(schedApptEndTimePicker.Text) 
                    && !string.IsNullOrWhiteSpace(custNameComboBox.Text))
            {
                BuildErrorMessage();
            }
            else
            {
                try
                {
                    Appointment newAppt = new Appointment();

                    string startDateTimeString = schedApptDatePicker.Text + " " + schedApptStartTimePicker.Text;
                    string endDateTimeString = schedApptDatePicker.Text + " " + schedApptEndTimePicker.Text;

                    if (!DateTime.TryParse(startDateTimeString, out DateTime startTime) || !DateTime.TryParse(endDateTimeString, out DateTime endTime))
                    {
                        MessageBox.Show("The date and/or time you entered was invalid. Please try again.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        newAppt.Start = DateTime.Parse(startDateTimeString);
                        newAppt.End = DateTime.Parse(endDateTimeString);

                        if (newAppt.Start.Hour < 8 || newAppt.Start.Hour > 17)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else if (newAppt.End.Hour < 8 || newAppt.End.Hour > 17)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            newAppt.AppointmentID = conn.GetAppointmentCount();

                            // Lambda expression is used to retrieve the customer ID of the object in the customers list that has a name matching that of the Customer Name Combo Box; the first element is returned if found, if not, a default value is found
                            newAppt.CustomerID = customers.Where(x => x.CustomerName == custNameComboBox.Text).Select(x => x.CustomerID).FirstOrDefault();

                            newAppt.Description = apptDescriptionRTxtBox.Text;
                            newAppt.Title = titleTxtBox.Text;
                            newAppt.Contact = contactTxtBox.Text;
                            newAppt.Location = locationTxtBox.Text;
                            newAppt.Type = typeTxtBox.Text;
                            newAppt.Url = urlTxtBox.Text;

                            conn.AddAppointment(newAppt, custNameComboBox.Text);

                            MessageBox.Show($"The appointment for {custNameComboBox.Text} was scheduled successfully.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred when scheduling the appointment.\n{ex}", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BuildErrorMessage()
        {
            // Creates a StringBuilder object for the error message
            StringBuilder errorBlankInfo = new StringBuilder();

            errorBlankInfo.Append("The following fields are required to schedule an appointment:\n\n");

            if (string.IsNullOrWhiteSpace(custNameComboBox.Text))
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
            if (string.IsNullOrWhiteSpace(schedApptStartTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appt. Start Time");
            }
            if (string.IsNullOrWhiteSpace(schedApptEndTimePicker.Text))
            {
                errorBlankInfo.AppendLine("Appt. End Time");
            }

            MessageBox.Show(errorBlankInfo.ToString(), "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void schedApptStartTimePicker_ValueChanged(object sender, EventArgs e)
        {
            schedApptStartTimePicker.Checked = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
