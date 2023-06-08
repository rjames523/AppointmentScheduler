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
    public class DBConnection
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;
        // home laptop testing -- string connectionStr = @"server=localhost;userid=testuser;password=Lancaster123!;database=client_schedule";
        private string _connectionStr = @"server=localhost;userid=admin;password=Lancaster123!;database=client_schedule"; // work laptop testing

        public DBConnection()
        {
            connection = new MySqlConnection(_connectionStr);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public bool AuthenticateUser(string username, string password)
        {
            connection.Open();

            string sql = $"SELECT * FROM user WHERE username = '{username}' AND password = '{password}'";
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
        }

        public List<Customer> GetAllCustomers() // change to return list
        {
            connection.Open();

            List<Customer> customerList = new List<Customer>();
            string sql = "SELECT * FROM customer";
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                Customer newCust = new Customer();
                for (int i = 0; i < reader.FieldCount; i++)
                {
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
                            newCust.AddressID = (int)reader.GetValue(i);
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
                        case "lastupdateby":
                            newCust.LastUpdateBy = (string)reader.GetValue(i);
                            break;
                            // do something
                        default:
                            return null;
                    }
                }

                customerList.Add(newCust);
            }

            connection.Close();

            return customerList;

        }
    }
}
