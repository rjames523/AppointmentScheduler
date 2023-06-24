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
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler
{
    public partial class LandingForm : Form
    {
        public LandingForm()
        {
            InitializeComponent();
        }

        ResourceManager rm;
        CultureInfo culture;
        DbConn conn;

        private void viewCustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewCustomersForm customersForm = new ViewCustomersForm();
            customersForm.ShowDialog();
            this.Show();
        }

        private void viewApptsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewAppointmentsForm appointmentsForm = new ViewAppointmentsForm();
            appointmentsForm.ShowDialog();
            this.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Hide();
            SchedulerLoginForm loginForm = new SchedulerLoginForm();
            loginForm.ShowDialog();
            this.Close();

        }

        private void LandingForm_Load(object sender, EventArgs e)
        {

            conn = new DbConn();

            DateTime currentTime = DateTime.Now;
            TimeSpan ts;
            
            List<Customer> customerList = conn.GetAllCustomers();
            List<Appointment> appointments = conn.GetAllCustomerAppointments();
            
            foreach (Appointment appt in appointments)
            {
                if (currentTime.Date == appt.Start.Date)
                {
                    if ((appt.Start.Hour == currentTime.Hour) && (appt.Start.Minute - currentTime.Minute <= 15))
                    {
                        if ((appt.Start.Minute - currentTime.Minute >= 1))
                        {
                            int minutesUntilAppt = appt.Start.Minute - currentTime.Minute;
                            var notifyCustNameForAppt = customerList.Where(x => x.CustomerID == appt.CustomerID).Select(x => x.CustomerName).First();
                            MessageBox.Show($"Upcoming Appointment for {notifyCustNameForAppt}\nin {minutesUntilAppt} minutes", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if ((appt.Start.Hour - currentTime.Hour == 1) && ((appt.Start.Minute - currentTime.Minute <= 15) && (appt.Start.Minute - currentTime.Minute >= 0)))
                    {
                        if (appt.Start.Date.Minute == 0)
                        {
                            if ((60 - currentTime.Minute >= 1))
                            {
                                int minutesUntilAppt = 60 - currentTime.Minute;
                                var notifyCustNameForAppt = customerList.Where(x => x.CustomerID == appt.CustomerID).Select(x => x.CustomerName).First();
                                MessageBox.Show($"Upcoming Appointment for {notifyCustNameForAppt}\nin {minutesUntilAppt} minutes", "The Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                    else if(TimeSpan)
                    {

                    }
                }
            }
            
        }

        private void addCustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomerForm addCustForm = new AddCustomerForm();
            addCustForm.ShowDialog();
            this.Show();
        }

        private void modifyCustomersButton_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //ModifyCustomerForm modifyCustForm = new ModifyCustomerForm();
            //modifyCustForm.ShowDialog();
            //this.Show();
        }

        private void scheduleNewApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleAppointmentForm scheduleApptForm = new ScheduleAppointmentForm();
            scheduleApptForm.ShowDialog();
            this.Show();
        }

        private void modifyApptButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyApptsForm modifyApptsForm = new ModifyApptsForm();
            modifyApptsForm.ShowDialog();
            this.Show();
        }
    }
}
