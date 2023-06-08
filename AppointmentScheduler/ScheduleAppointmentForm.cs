﻿using schedulerLoginForm;
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
            if (availableTimesRTextBox.SelectedText == string.Empty)
            {
                MessageBox.Show("You must select an appointment time to continue", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void customerNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate textboxes with customer information; retrieve information using customer selected from combo box
        }

        private void CreateAppointmentForm_Load(object sender, EventArgs e)
        {
            rm = new ResourceManager("AppointmentScheduler.Resources.Res", typeof(ScheduleAppointmentForm).Assembly);
            culture = CultureInfo.CurrentUICulture;
            nameLabel.Text = rm.GetString("nameLabel", culture);
            addressLabel.Text = rm.GetString("addressLabel", culture);
            cityLabel.Text = rm.GetString("cityLabel", culture);
            countryLabel.Text = rm.GetString("countryLabel", culture);
            calendarLabel.Text = rm.GetString("calendarLabel", culture);
            availableApptLabel.Text = rm.GetString("availableApptLabel", culture);

            // Calendar culture?
            // Be sure to use customer's Country to change calendar culture/time zone
        }
    }
}
