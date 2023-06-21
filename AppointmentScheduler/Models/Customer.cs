using AppointmentScheduler.Connections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduler.Models
{
    public class Customer : INotifyPropertyChanged
    {
        private int _addressID;

        public event PropertyChangedEventHandler PropertyChanged;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        // Address object property added to mirror database implementation
        public int AddressID { get; set; }
        public Address Address { get; set; } = new Address();
        public bool Active { get; set; } //Database value is likely either 0 or 1, aka False or True
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; }

        public static BindingList<Customer> AllCustomers = new BindingList<Customer>();

        public Customer() 
        {
            Address = new Address();
            CreatedBy = DbConn.loggedInUser.UserName;
            LastUpdatedBy = DbConn.loggedInUser.UserName;
        }

        public Customer(Address address, int customerID, string customerName, bool active, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            AddressID = address.AddressID;
            CustomerID = customerID;
            CustomerName = customerName;
            Active = active;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }

        public void NotifyPropertyChanged(String property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
