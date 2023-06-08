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

        DBConnection conn;

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            conn = new DBConnection();
            customersDGV.DataSource = conn.GetAllCustomers();
        }
    }
}
