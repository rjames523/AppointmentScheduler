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

        DbConn conn;
        Appointment selectedAppointment;
        DateTime selectedApptTime;
        bool isDaylightSaving;

        private void ModifyApptsForm_Load(object sender, EventArgs e)
        {

            apptStartTimeTxtBox.Enabled = false;
            apptEndTimeTxtBox.Enabled = false;
            Customer cust = new Customer();
            custNameTxtBox.Text = Customer.AllCustomers.Where(x => x.CustomerID == selectedAppointment.CustomerID).Select(x => x.CustomerName).First().ToString();
            titleTxtBox.Text = selectedAppointment.Title;
            contactTxtBox.Text = selectedAppointment.Contact;
            typeTxtBox.Text = selectedAppointment.Type;
            locationTxtBox.Text = selectedAppointment.Location;
            urlTxtBox.Text = selectedAppointment.Url;
            apptDescriptionRTxtBox.Text = selectedAppointment.Description;
            apptDateTxtBox.Text = selectedAppointment.Start.ToShortDateString();
            apptStartTimeTxtBox.Text = selectedAppointment.Start.ToShortTimeString();
            apptEndTimeTxtBox.Text = selectedAppointment.End.ToShortTimeString();

            //Test this
            isDaylightSaving = TimeZoneInfo.Local.IsDaylightSavingTime(DateTime.Now.ToLocalTime());
        }

        private void createAppointmentCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            
        }

        private void createAppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void apptDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            selectedApptTime = apptDateTimePicker.Value;
            if (apptDateTimePicker.Value != null)
            {
                selectedApptTime = apptDateTimePicker.Value;
            }
        }
    }
}
