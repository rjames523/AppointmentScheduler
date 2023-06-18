using AppointmentScheduler.Connections;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentScheduler.Models
{
    public class City
    {
        private int _countryId;

        public int CityID { get; set; }
        public string CityName { get; set; }
        public Country Country { get; set; } = new Country();
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; } = DbConn.loggedInUser.UserName;
        public DateTime LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; } = DbConn.loggedInUser.UserName;

        public City() 
        {
            
        }


        public City(Country country, int cityID, DateTime createDate, string createdBy, DateTime lastUpdate, string LastUpdateBy)
        {
            Country.CountryID = country.CountryID;
            CityID = cityID;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = LastUpdateBy;
        }
    }
}
