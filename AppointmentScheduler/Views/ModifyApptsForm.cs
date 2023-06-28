﻿using AppointmentScheduler.Connections;
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
            conn = new DbConn();
            customers = new List<Customer>();
            appointments = new List<Appointment>();
            apptStartTimeTxtBox.Enabled = false;
            apptEndTimeTxtBox.Enabled = false;
            Customer cust = new Customer();
            customers = conn.GetAllCustomers();
            appointments = conn.GetAllCustomerAppointments();
            custNameTxtBox.Text = customers.Where(x => x.CustomerID == selectedAppointment.CustomerID).Select(x => x.CustomerName).FirstOrDefault().ToString();
            titleTxtBox.Text = selectedAppointment.Title;
            contactTxtBox.Text = selectedAppointment.Contact;
            typeTxtBox.Text = selectedAppointment.Type;
            locationTxtBox.Text = selectedAppointment.Location;
            urlTxtBox.Text = selectedAppointment.Url;
            apptDescriptionRTxtBox.Text = selectedAppointment.Description;
            apptDateTxtBox.Text = selectedAppointment.Start.ToShortDateString();
            apptStartTimeTxtBox.Text = selectedAppointment.Start.ToShortTimeString();
            apptEndTimeTxtBox.Text = selectedAppointment.End.ToShortTimeString();
        }

        private void createAppointmentCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void createAppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void apptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
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
            schedApptStartTimePicker.Checked = true;
            DateTime selectedDate = DateTime.Parse(apptDatePicker.Text);

            if (selectedDate < DateTime.UtcNow.Date)
            {
                MessageBox.Show("You must select a future date.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            if (this.Controls.OfType<TextBox>().Any(x => string.IsNullOrWhiteSpace(x.Text)) && !string.IsNullOrWhiteSpace(schedApptStartTimePicker.Text) && !string.IsNullOrWhiteSpace(schedApptEndTimePicker.Text) && !string.IsNullOrWhiteSpace(custNameTxtBox.Text))
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

                        if (modifiedAppt.Start.Hour < 8 || modifiedAppt.End.Hour > 17)
                        {
                            MessageBox.Show("The chosen time is outside of regular business hours.\nPlease select a different timeframe.", "The Scheduler - Schedule Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                            conn.UpdateAppointment(modifiedAppt, custNameTxtBox.Text);

                            MessageBox.Show($"The appointment information for {custNameTxtBox.Text} was updated successfully.", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred when updating the appointment information.\n{ex}", "The Scheduler - Modify Appointment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

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
    }
}
