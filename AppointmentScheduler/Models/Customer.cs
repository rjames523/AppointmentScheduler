using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduler.Models
{
    public class Customer
    {
        private int _addressID;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int AddressID { get; set; }
        public bool Active { get; set; } //Database value is likely either 0 or 1, aka False or True
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        public Customer() { }

        public Customer(Address address)
        {
            AddressID = address.AddressID;
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
            LastUpdateBy = LastUpdateBy;
        }
    }
}
