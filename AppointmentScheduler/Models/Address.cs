﻿using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduler.Models
{
    public class Address
    {
        private int _cityID;

        public int AddressID { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }

        public Address() { }

        public Address(City city)
        {
            _cityID = city.CityID;
        }

        public Address(City city, int addressID, string address1, string address2, string postalCode, string phone, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            _cityID = city.CityID;
            AddressID = addressID;
            Address1 = address1;
            Address2 = address2;
            PostalCode = postalCode;
            Phone = phone;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdateBy = LastUpdateBy;
        }
    }
}
