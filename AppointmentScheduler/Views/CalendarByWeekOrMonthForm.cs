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

namespace AppointmentScheduler.Views
{
    public partial class CalendarByWeekOrMonthForm : Form
    {
        public CalendarByWeekOrMonthForm()
        {
            InitializeComponent();
        }
        public CalendarByWeekOrMonthForm(string viewType)
        {
            InitializeComponent();

            if (viewType == "week")
            {
                this.Text = "The Scheduler - Calendar by Week";
                weekOrMonthOfLabel.Text = "Current Week";
            }
            else if (viewType == "month")
            {
                this.Text = "The Scheduler - Calendar by Month";
                weekOrMonthOfLabel.Text = "Month of: ";
            }
        }


        DbConn conn;
        private List<Appointment> appointments;
        private string currentMonth;

        private void CalendarByWeekOrMonthForm_Load(object sender, EventArgs e)
        {
            // Initialize variables
            conn = new DbConn();
            appointments = new List<Appointment>();

            // Get the current month name
            currentMonth = DateTime.UtcNow.ToString("MMMM");

            appointments = conn.GetAllCustomerAppointments();

            // Check if form loaded with either Month or Week inside the weekOrMonthOfLabel
            if (weekOrMonthOfLabel.Text.Contains("Month"))
            {
                // Lambda is used to query the appointments list to find all appointments that have a start month name that matches the currentMonth name
                calendarDGV.DataSource = appointments.Where(x => x.Start.ToString("MMMM") == currentMonth).ToList();
                weekOrMonthOfLabel.Text = "Month of:  " + currentMonth;
            }
            else if (weekOrMonthOfLabel.Text.Contains("Week"))
            {
                // Lambda is used to query the appointments list to find all appointments that have a start date/time greater than the current time, but the start date/time is less than 7 days from now (week ahead)
                DateTime thisWeek = DateTime.UtcNow.AddDays(7);
                calendarDGV.DataSource = appointments.Where(x => (x.Start > DateTime.Now) && (x.Start < thisWeek.ToLocalTime())).Select(x => x).ToList();
                weekOrMonthOfLabel.Text = "Current Week";
            }
        }
    }
}
