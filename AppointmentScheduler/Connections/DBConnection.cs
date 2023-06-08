using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentScheduler.Models;
using MySqlX.XDevAPI.Relational;

namespace AppointmentScheduler.Connections
{
    internal class DBConnection
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        // home laptop testing -- string connectionStr = @"server=localhost;userid=testuser;password=Lancaster123!;database=client_schedule";
        string connectionStr = @"server=localhost;userid=admin;password=Lancaster123!;database=client_schedule"; // work laptop testing

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
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Customer newCust = new Customer();
                    switch (reader.GetName(i).ToLower())
                    {
                        case "customerid":
                            newCust.CustomerID = (int)reader.GetValue(i);
                            break;
                        case "customername":
                            newCust.CustomerName = (string)reader.GetValue(i);
                            break;
                        case "addressid":
                            //get the address ID ***
                            break;
                        case "active":
                            newCust.Active = (bool)reader.GetValue(i);
                            break;
                            //do something
                        case "createdate":
                            newCust.CreateDate = (DateTime)reader.GetValue(i);
                            break;
                            //do something
                        case "createdby":
                            newCust.CreatedBy = (string)reader.GetValue(i);
                            break;
                            //do something
                        case "lastupdate":
                            newCust.LastUpdate = (DateTime)reader.GetValue(i);
                            break;
                            // do something
                        case "lastupdatedby":
                            newCust.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                            // do something
                        default:
                            return;
                    }
                }
            }

            connection.Close();

        }
    }
}
