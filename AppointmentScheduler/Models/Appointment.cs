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
    public class Appointment
    {
        private int _customerID;
        private int _userID;

        private static int _appointmentID = 0;

        public int AppointmentID { get; set; }
        public int UserID { get; set; }
        public int CustomerID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = DbConn.loggedInUser.UserName;
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; } = DbConn.loggedInUser.UserName;

        public static BindingList<Appointment> AllCustomerAppts = new BindingList<Appointment>();


        public Appointment() 
        {
            AppointmentID = 0;
            UserID = 0;
            CustomerID = 0;
            Title = "n/a";
            Description = "n/a";
            Location = "n/a";
            Contact = "n/a";
            Type = "n/a";
            Url = "n/a";
            Start = DateTime.UtcNow;
            End = DateTime.UtcNow;
            CreateDate = DateTime.UtcNow;
            CreatedBy = DbConn.loggedInUser.UserName;
            LastUpdate = DateTime.UtcNow;
            LastUpdatedBy = DbConn.loggedInUser.UserName;
        }

        public Appointment(User user, Customer customer)
        {
            _userID = user.UserID;
            _customerID = customer.CustomerID;
        }
        public Appointment(User user, Customer customer, string title, string description, string location, string contact, string type, string uRL, DateTime start, DateTime end, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            
            CustomerID = customer.CustomerID;
            UserID = user.UserID;
            AppointmentID = _appointmentID + 1;
            Title = title;
            Description = description;
            Location = location;
            Contact = contact;
            Type = type;
            Url = uRL;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }
    }
}
