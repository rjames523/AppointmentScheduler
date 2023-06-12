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

namespace AppointmentScheduler
{
    public partial class ModifyApptsForm : Form
    {
        public ModifyApptsForm()
        {
            InitializeComponent();
        }

        DBConnection conn;

        private void ModifyApptsForm_Load(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            customerNamesComboBox.DataSource = conn.GetAllCustomers();
        }
    }
}
