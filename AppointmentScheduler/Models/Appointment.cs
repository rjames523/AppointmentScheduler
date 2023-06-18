using AppointmentScheduler.Connections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
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

        public static int AppointmentID { get; set; }
        public static int UserID { get; set; }
        public static int CustomerID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Contact { get; set; }
        public string Type { get; set; }
        public string URL { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = DbConn.loggedInUser.UserName;
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; } = DbConn.loggedInUser.UserName;


        public Appointment() { }

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
            URL = uRL;
            Start = start;
            End = end;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }
    }
}
