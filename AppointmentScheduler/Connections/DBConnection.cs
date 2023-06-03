using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduler.Connections
{
    internal class DBConnection
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        string connectionStr = @"server=localhost;userid=testuser;password=Lancaster123!;database=client_schedule";

        public DBConnection()
        {
            connection = new MySqlConnection(connectionStr);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void GetAllCustomers() // change to return list
        {
            connection.Open();

            List<Customer> customerList = new List<Customer>();
            string sql = "SELECT * FROM customer";
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                reader.GetName(0);
            }

            connection.Close();

        }
    }
}
