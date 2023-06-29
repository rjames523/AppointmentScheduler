using AppointmentScheduler.Connections;
using AppointmentScheduler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler.Views
{
    public partial class ViewReportsForm : Form
    {
        public ViewReportsForm()
        {
            InitializeComponent();
        }

        DbConn conn;

        private void ViewReportsForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();

            reportTypeComboBox.Items.Add("Number of appt. types by month");
            reportTypeComboBox.Items.Add("Schedule for each consultant");
            reportTypeComboBox.Items.Add("Number of customers created by month");

            reportDGV.DataSource = null;
            reportDGV.ClearSelection();
        }

        private void loadReportButton_Click(object sender, EventArgs e)
        {
            if (reportTypeComboBox.SelectedIndex == 0)
            {
                reportDGV.DataSource = conn.CountApptTypesByMonth();
            }
            else if (reportTypeComboBox.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(consultantNameComboBox.Text))
                {
                    var result = conn.LoadConsultantSchedules(consultantNameComboBox.Text).Select(x => new { x.AppointmentID, x.CustomerID, x.Title, x.Description, x.Location, x.Contact, x.Type, x.Url, x.Start, x.End }).ToList();

                    reportDGV.DataSource = result;
                }
                else
                {
                    MessageBox.Show("Please select a consultant before loading the report.", "The Scheduler - Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else if (reportTypeComboBox.SelectedIndex == 2)
            {
                reportDGV.DataSource = conn.CountCustomersCreatedByMonth();
            }
            else
            {
                MessageBox.Show("Please select a report to load.", "The Scheduler - Reports", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void reportTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportTypeComboBox.SelectedIndex == 1)
            {
                consultantNameComboBox.Items.Clear();

                foreach (User user in conn.GetAllUsers())
                {
                    consultantNameComboBox.Items.Add(user.UserName);
                }

                consultantNameComboBox.Visible = true;
                selectConsultantLabel.Visible = true;
            }
            else
            {
                reportDGV.DataSource = null;
                consultantNameComboBox.Visible = false;
                selectConsultantLabel.Visible = false;
            }
        }
    }
}
