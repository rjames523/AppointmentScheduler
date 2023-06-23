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
        }

        ResourceManager rm;
        CultureInfo culture;

        private void createAppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void createAppointmentButton_Click(object sender, EventArgs e)
        {
            //if (availableTimesRTextBox.SelectedText == string.Empty)
            //{
            //    MessageBox.Show("You must select an appointment time to continue", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }

        private void customerNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate textboxes with customer information; retrieve information using customer selected from combo box
        }

        private void CreateAppointmentForm_Load(object sender, EventArgs e)
        {


            // Calendar culture?
            // Be sure to use customer's Country to change calendar culture/time zone
        }

        private void scheduleAppointmentCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (!string.IsNullOrEmpty(scheduleAppointmentCalendar.SelectionRange.ToString()))
            {
                string appointmentDate = scheduleAppointmentCalendar.SelectionRange.ToString();
            }
        }

        private void scheduleAppointmentButton_Click(object sender, EventArgs e)
        {

        }
    
        }
    }
