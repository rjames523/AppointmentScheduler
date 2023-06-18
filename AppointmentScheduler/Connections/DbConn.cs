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
    public class DbConn
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataReader reader;

        public static User loggedInUser;

        // home laptop testing --
        string _connectionStr = @"server=localhost;userid=testuser;password=Lancaster123!;database=client_schedule";

        //private string _connectionStr = @"server=localhost;userid=admin;password=Lancaster123!;database=client_schedule"; // work laptop testing

        public DbConn()
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
                //while (reader.Read())
                //{
                //    loggedInUser = reader[0] as User;
                //    connection.Close();
                //    return true;
                //}
                loggedInUser = new User();
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        switch (reader.GetName(i).ToLower())
                        {
                            case "userid":
                                loggedInUser.UserID = (int)reader.GetValue(i);
                                break;
                            case "username":
                                loggedInUser.UserName = (string)reader.GetValue(i);
                                break;
                            case "password":
                                loggedInUser.Password = (string)reader.GetValue(i);
                                break;
                            case "active":
                                if ((SByte)reader.GetValue(i) != 0) 
                                { 
                                    loggedInUser.Active = true; 
                                }
                                else
                                    loggedInUser.Active = false;
                                break;
                            case "createdate":
                                loggedInUser.CreateDate = (DateTime)reader.GetValue(i);
                                break;
                            case "createdby":
                                loggedInUser.CreatedBy = (string)reader.GetValue(i);
                                break;
                            case "lastupdate":
                                loggedInUser.LastUpdate = (DateTime)reader.GetValue(i);
                                break;
                            case "lastupdateby":
                                loggedInUser.LastUpdatedBy = (string)reader.GetValue(i);
                                break;
                            default:
                                return false;
                        }
                    }
                }
                connection.Close();
                reader.Close();
                return true;

            }
            else
            {
                reader.Close();
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
                            newCust.Address.AddressID = (int)reader.GetValue(i);
                            break;
                        case "active":
                            newCust.Active = (bool)reader.GetValue(i);
                            break;
                        case "createdate":
                            newCust.CreateDate = (DateTime)reader.GetValue(i);
                            break;
                        case "createdby":
                            newCust.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            newCust.LastUpdate = (DateTime)reader.GetValue(i);
                            break;
                        case "lastupdateby":
                            newCust.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            return null;
                    }
                }
                
                customerList.Add(newCust);
            }
            reader.Close();

            connection.Close();

            return customerList;

        }

        public List<Country> GetAllCountries()
        {
            connection.Open();

            List<Country> countryList = new List<Country>();
            string sql = "SELECT * FROM country";
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                Country country = new Country();
                for (int i=0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "countryid":
                            country.CountryID = (int)reader.GetValue(i);
                            break;
                        case "country":
                            country.CountryName = (string)reader.GetValue(i);
                            break;
                        case "createdate":
                            country.CreateDate = (DateTime)reader.GetValue(i);
                            break;
                        case "createdby":
                            country.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            country.LastUpdate = (DateTime)reader.GetValue(i);
                            break;
                        case "lastupdateby":
                            country.LastUpdatedBy = (string) reader.GetValue(i);
                            break;
                        default:
                            return null;
                    }
                }
                countryList.Add(country);
            }
            reader.Close();

            connection.Close();
            return countryList;
        }

        public void InsertCustomer(Customer customer)
        {
            connection.Open();

            string sql = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customername, (SELECT COUNT(*)+=1 FROM address), 1, @createdate, @createdby, NOW(), @lastupdatedby)";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@customername", customer.CustomerName);
            command.Parameters.AddWithValue("@createdate", DateTime.Now);
            command.Parameters.AddWithValue("@createdby", customer.CreatedBy);
            command.Parameters.AddWithValue("@lastupdatedby", customer.LastUpdatedBy);

            command.ExecuteNonQuery();

            connection.Close();
        }


        // Fix this!!!
        public int AddCustomerAddress(Address customerAddr)
        {
            connection.Open();

            string sql = "INSERT INTO address( address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES( @address1, @address2, @cityid, @postalcode, @phone, @createdate, @createdby, @lastupdate, @lastupdateby)";
            command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("@address1", customerAddr.Address1);
            command.Parameters.AddWithValue("@address2", customerAddr.Address2);
            command.Parameters.AddWithValue("@cityid", customerAddr.City.CityID);
            command.Parameters.AddWithValue("@postalcode", customerAddr.PostalCode);
            command.Parameters.AddWithValue("@phone", customerAddr.Phone);
            //command.Parameters.AddWithValue("@countryname", customerAddr.City.Country.CountryName);
            command.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            command.Parameters.AddWithValue("@createdate", DateTime.Now);
            command.Parameters.AddWithValue("@lastupdate", DateTime.Now);
            command.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            command.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        public List<City> GetAllCities()
        {
            connection.Open();

            List<City> cityList = new List<City>();
            string sql = "SELECT * FROM city";
            command = new MySqlCommand(sql, connection);
            reader = command.ExecuteReader();

            while (reader.Read())
            {
                City city = new City();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "cityid":
                            city.CityID = (int)reader.GetValue(i);
                            break;
                        case "city":
                            city.CityName = (string)reader.GetValue(i);
                            break;
                        case "countryid":
                            city.Country.CountryID = (int)reader.GetValue(i);
                            break;
                        case "createdate":
                            city.CreateDate = (DateTime)reader.GetValue(i);
                            break;
                        case "createdby":
                            city.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            city.LastUpdate = (DateTime)reader.GetValue(i);
                            break;
                        case "lastupdateby":
                            city.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            return null;
                    }
                }
                cityList.Add(city);
            }
            reader.Close();

            connection.Close();
            return cityList;
        }
    }
}
