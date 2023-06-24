using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentScheduler.Models;
using System.ComponentModel;
using System.Net.NetworkInformation;
//using MySqlX.XDevAPI.Relational;

namespace AppointmentScheduler.Connections
{
    public class DbConn
    {
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;

        public event PropertyChangedEventHandler PropertyChanged;

        public static User loggedInUser;

        // home laptop testing --
        string _connectionStr = @"server=localhost;userid=testuser;password=Lancaster123!;database=client_schedule";

        // work laptop
        // private string _connectionStr = @"server=localhost;userid=admin;password=Lancaster123!;database=client_schedule";  testing

        // school VM
        //private string _connectionStr = @"server=127.0.0.1;userid=sqlUser;password=Passw0rd!;database=client_schedule";

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
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
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

        public List<Customer> GetAllCustomers()
        {
            connection.Open();

            //Customer.AllCustomers.Clear();

            List<Customer> customerList = new List<Customer>();
            //string sql = "SELECT * FROM customer";
            string sql = "SELECT * FROM customer c INNER JOIN address a " +
                                    "ON c.addressid = a.addressid " +
                                    "INNER JOIN city t " +
                                    "ON a.cityid = t.cityid " +
                                    "INNER JOIN country y " +
                                    "ON t.countryid = y.countryid";
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

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
                            newCust.AddressID = (int)reader.GetValue(i);
                            break;
                        case "address":
                            newCust.Address.Address1 = (string)reader.GetValue(i);
                            break;
                        case "address2":
                            newCust.Address.Address2 = (string)reader.GetValue(i);
                            break;
                        case "active":
                            newCust.Active = (bool)reader.GetValue(i);
                            break;
                        case "cityid":
                            newCust.Address.City.CityID = (int)reader.GetValue(i);
                            break;
                        case "city":
                            newCust.Address.City.CityName = (string)reader.GetValue(i);
                            break;
                        case "postalcode":
                            newCust.Address.PostalCode = (string)reader.GetValue(i);
                            break;
                        case "phone":
                            newCust.Address.Phone = (string)reader.GetValue(i);
                            break;
                        case "countryid":
                            newCust.Address.City.Country.CountryID = (int)reader.GetValue(i);
                            break;
                        case "country":
                            newCust.Address.City.Country.CountryName = (string)reader.GetValue(i);
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
                            break;
                    }
                }

                //Customer.AllCustomers.Add(newCust);
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
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Country country = new Country();
                for (int i = 0; i < reader.FieldCount; i++)
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
                            country.LastUpdatedBy = (string)reader.GetValue(i);
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

        public int GetAddressCount()
        {
            connection.Open();

            string sql = "SELECT COUNT(*) FROM address";
            cmd = new MySqlCommand(sql, connection);

            int addressCount = int.Parse(cmd.ExecuteScalar().ToString());

            connection.Close();
            return addressCount + 1;
        }

        /*
        public void InsertCustomer(Customer customer)
        {
            connection.Open();

            string sql = "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES (@customername, @addressid, 1, @createdate, @createdby, NOW(), @lastupdatedby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customername", customer.CustomerName);
            cmd.Parameters.AddWithValue("@addressid", customer.Address.AddressID);
            cmd.Parameters.AddWithValue("@createdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@createdby", customer.CreatedBy);
            cmd.Parameters.AddWithValue("@lastupdatedby", customer.LastUpdatedBy);

            cmd.ExecuteNonQuery();

            connection.Close();
        }*/

        public void AddCustomer(Customer cust)
        {
            connection.Open();

            string sql = "INSERT INTO customer( customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES( @customername, @addressid, @active, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customername", cust.CustomerName);
            cmd.Parameters.AddWithValue("@addressid", cust.Address.AddressID);
            cmd.Parameters.AddWithValue("@active", cust.Active);
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@createdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public int AddCustomerAddress(Address customerAddr, List<Customer> customers)
        {
            connection.Open();

            string sql = "INSERT INTO address( addressid, address, address2, cityid, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy) VALUES( @addressid, @address1, @address2, @cityid, @postalcode, @phone, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@addressid", customerAddr.AddressID);
            cmd.Parameters.AddWithValue("@address1", customerAddr.Address1);
            cmd.Parameters.AddWithValue("@address2", customerAddr.Address2);
            cmd.Parameters.AddWithValue("@cityid", customerAddr.City.CityID);
            cmd.Parameters.AddWithValue("@postalcode", customerAddr.PostalCode);
            cmd.Parameters.AddWithValue("@phone", customerAddr.Phone);
            //command.Parameters.AddWithValue("@countryname", customerAddr.City.Country.CountryName);
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@createdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        public int AddCity(int cityId, int countryId, string cityName)
        {
            connection.Open();

            string sql = "INSERT INTO city( cityid, city, countryid, createdate, createdby, lastupdate, lastupdateby) VALUES( @cityid, @cityname, @countryid, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@cityid", cityId);
            cmd.Parameters.AddWithValue("@cityname", cityName);
            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@createdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        public int AddCountry(int countryId, string countryName)
        {
            connection.Open();

            string sql = "INSERT INTO country( countryId, country, createdate, createdby, lastupdate, lastupdateby) VALUES( @countryId, @country, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@country", countryName);
            cmd.Parameters.AddWithValue("@createdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        public void AddAppointment(Appointment newAppt, string text)
        {
            connection.Open();

            string sql = "INSERT INTO appointment( appointmentId, customerId, userId, title, description, location, contact, type, url, start, end, createdate, createdby, lastupdate, lastupdateby) VALUES( @appointmentId, @customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createdate, @createdby, @lastupdate, @lastupdateby)";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@appointmentid", newAppt.AppointmentID);
            cmd.Parameters.AddWithValue("@customerid", newAppt.CustomerID);
            cmd.Parameters.AddWithValue("@userid", loggedInUser.UserID);
            cmd.Parameters.AddWithValue("@title", newAppt.Title);
            cmd.Parameters.AddWithValue("@description", newAppt.Description);
            cmd.Parameters.AddWithValue("@location", newAppt.Location);
            cmd.Parameters.AddWithValue("@contact", newAppt.Contact);
            cmd.Parameters.AddWithValue("@type", newAppt.Type);
            cmd.Parameters.AddWithValue("@url", newAppt.Url);
            cmd.Parameters.AddWithValue("@start", newAppt.Start.ToUniversalTime());
            cmd.Parameters.AddWithValue("@end", newAppt.End.ToUniversalTime());
            cmd.Parameters.AddWithValue("@createdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@createdby", loggedInUser.UserName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public List<City> GetAllCities()
        {
            connection.Open();

            List<City> cityList = new List<City>();
            string sql = "SELECT * FROM city";
            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();

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

        public void UpdateCustomer(Customer selectedCustomer)
        {
            connection.Open();

            string sql = "UPDATE customer SET customerName = @customername, active = @active, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE customerId = @customerid";
            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);
            cmd.Parameters.AddWithValue("@customername", selectedCustomer.CustomerName);
            //cmd.Parameters.AddWithValue("@addressId", selectedCustomer.Address.AddressID);
            cmd.Parameters.AddWithValue("@active", selectedCustomer.Active);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

            connection.Close();
            
        }

        public void UpdateAddress(Customer selectedCustomer)
        {
            connection.Open();
            string sql = "UPDATE address a SET a.address = @address, a.address2 = @address2, a.cityId = @cityid, a.postalCode = @postalcode, a.phone = @phone, a.lastUpdate = @lastupdate, a.lastUpdateBy = @lastupdateby WHERE a.addressId = @addressid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@addressid", selectedCustomer.Address.AddressID);
            cmd.Parameters.AddWithValue("@address", selectedCustomer.Address.Address1);
            cmd.Parameters.AddWithValue("@address2", selectedCustomer.Address.Address2);
            cmd.Parameters.AddWithValue("@cityid", selectedCustomer.Address.City.CityID);
            cmd.Parameters.AddWithValue("@postalcode", selectedCustomer.Address.PostalCode);
            cmd.Parameters.AddWithValue("@phone", selectedCustomer.Address.Phone);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        public void UpdateCustomerCountry(int countryId, string countryName)
        {
            connection.Open();
            string sql = "UPDATE country SET country = @country, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE countryId = @countryid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@country", countryName);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        public void UpdateCustomerCity(int cityId, int countryId, string cityName)
        {
            connection.Open();
            string sql = "UPDATE city SET city = @city, countryId = @countryId, lastUpdate = @lastupdate, lastUpdateBy = @lastupdateby WHERE cityId = @cityid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@cityid", cityId);
            cmd.Parameters.AddWithValue("@city", cityName);
            cmd.Parameters.AddWithValue("@countryid", countryId);
            cmd.Parameters.AddWithValue("@lastupdate", DateTime.Now.ToUniversalTime());
            cmd.Parameters.AddWithValue("@lastupdateby", loggedInUser.UserName);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
            connection.Close();
        }

        internal void UpdateCustomerAddress(object custAddress)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerData(Customer selectedCustomer)
        {
            connection.Open();

            // Delete any customer appointments
            DeleteCustomerAppointments(selectedCustomer);

            DeleteCustomerInfo(selectedCustomer);
            
            DeleteCustomerAddress(selectedCustomer);

            connection.Close();
        }

        private void DeleteCustomerInfo(Customer selectedCustomer)
        {
            string sql = "DELETE FROM customer WHERE customerId = @customerid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);

            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
        }

        private void DeleteCustomerAppointments(Customer selectedCustomer)
        {
            string sql = "DELETE FROM appointment WHERE customerId = @customerid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
        }

        private void DeleteCustomerAddress(Customer selectedCustomer)
        {
            string sql = "DELETE a FROM address a INNER JOIN customer c ON c.addressId = a.addressId WHERE c.customerId = @customerid";

            cmd = new MySqlCommand(sql, connection);

            cmd.Parameters.AddWithValue("@customerid", selectedCustomer.CustomerID);

            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();

        }


        public List<Appointment> GetAllCustomerAppointments()
        {
            connection.Open();

            List<Appointment> appointments = new List<Appointment>();
           
            string sql = "SELECT * FROM appointment";

            cmd = new MySqlCommand(sql, connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Appointment custAppt = new Appointment();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    switch (reader.GetName(i).ToLower())
                    {
                        case "appointmentid":
                            custAppt.AppointmentID = (int)reader.GetValue(i);
                            break;
                        case "customerid":
                            custAppt.CustomerID = (int)reader.GetValue(i);
                            break;
                        case "userid":
                            custAppt.UserID = (int)reader.GetValue(i);
                            break;
                        case "title":
                            custAppt.Title = (string)reader.GetValue(i);
                            break;
                        case "description":
                            custAppt.Description = (string)reader.GetValue(i);
                            break;
                        case "location":
                            custAppt.Location = (string)reader.GetValue(i);
                            break;
                        case "contact":
                            custAppt.Contact = (string)reader.GetValue(i);
                            break;
                        case "type":
                            custAppt.Type = (string)reader.GetValue(i);
                            break;
                        case "url":
                            custAppt.Url = (string)reader.GetValue(i);
                            break;
                        case "start":
                            DateTime startTime = (DateTime)reader.GetValue(i);
                            custAppt.Start = startTime.ToLocalTime();
                            break;
                        case "end":
                            DateTime endTime = (DateTime)reader.GetValue(i);
                            custAppt.End = endTime.ToLocalTime();
                            break;
                        case "createdate":
                            custAppt.CreateDate = (DateTime)reader.GetValue(i);
                            break;
                        case "createdby":
                            custAppt.CreatedBy = (string)reader.GetValue(i);
                            break;
                        case "lastupdate":
                            custAppt.LastUpdate = (DateTime)reader.GetValue(i);
                            break;
                        case "lastupdateby":
                            custAppt.LastUpdatedBy = (string)reader.GetValue(i);
                            break;
                        default:
                            break;
                    }
                }

                //Appointment.AllCustomerAppts.Add(custAppt);
                appointments.Add(custAppt);

            }
            reader.Close();

            connection.Close();

            return appointments;
        }

        public int GetAppointmentCount()
        {
            connection.Open();

            string sql = "SELECT MAX(appointmentId) FROM appointment";
            cmd = new MySqlCommand(sql, connection);

            int appointmentCount = int.Parse(cmd.ExecuteScalar().ToString());

            connection.Close();
            return appointmentCount + 1;
        }

        
    }
}
