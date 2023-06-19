using AppointmentScheduler.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentScheduler
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        DbConn conn;

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            conn = new DbConn();
            customersDGV.DataSource = conn.GetAllCustomers();
        }

        private void editCustomerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyCustomerForm modifyCustForm = new ModifyCustomerForm();
            modifyCustForm.ShowDialog();
            this.Show();
        }

        private void scheduleAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScheduleAppointmentForm scheduleApptForm = new ScheduleAppointmentForm();
            scheduleApptForm.ShowDialog();
            this.Show();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            // delete selected row (cast as Customer object)
        }
    }
}
