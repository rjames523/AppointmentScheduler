using AppointmentScheduler.Connections;
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
            CustomersForm customersForm = new CustomersForm();
            customersForm.ShowDialog();
            this.Show();
        }

        private void viewApptsButton_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.ShowDialog();
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
            /* rm = new ResourceManager("AppointmentScheduler.Resources.Res", typeof(LandingForm).Assembly);
            culture = CultureInfo.CurrentUICulture;
            viewCustomersLabel.Text = rm.GetString("viewCustomersLabel", culture);
            viewCurrApptsLabel.Text = rm.GetString("viewCurrApptsLabel", culture);
            customersGroupBox.Text = rm.GetString("customersGroupBox", culture);
            appointmentsGroupBox.Text = rm.GetString("appointmentsGroupBox", culture);
            viewCustomersButton.Text = rm.GetString("viewCustomersButton", culture);
            viewCurrApptsButton.Text = rm.GetString("viewCurrApptsButton", culture);
            addCustomersButton.Text = rm.GetString("addCustomersButton", culture);
            addCustomersLabel.Text = rm.GetString("addCustomersLabel", culture);
            scheduleNewApptLabel.Text = rm.GetString("scheduleNewApptLabel", culture);
            scheduleNewApptButton.Text = rm.GetString("scheduleNewApptButton", culture);
            modifyCustomersButton.Text = rm.GetString("modifyCustomersButton", culture);
            modifyCustomerInfoLabel.Text = rm.GetString("modifyCustomerInfoLabel", culture);
            modifyApptButton.Text = rm.GetString("modifyApptButton", culture);
            modifyApptLabel.Text = rm.GetString("modifyApptLabel", culture); */

            // add remaining control culture-based text
            // update description of culture fields in resx files
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
            this.Hide();
            ModifyCustomerForm modifyCustForm = new ModifyCustomerForm();
            modifyCustForm.ShowDialog();
            this.Show();
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
