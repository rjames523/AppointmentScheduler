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
        public DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public Timestamp LastUpdate { get; set; }
        public string LastUpdatedBy { get; set; }

        public City() { }

        public City(Country country)
        {
            _countryId = country.CountryID;
        }

        public City(Country country, int cityID, DateTime createDate, string createdBy, Timestamp lastUpdate, string lastUpdatedBy)
        {
            _countryId = country.CountryID;
            CityID = cityID;
            CreateDate = createDate;
            CreatedBy = createdBy;
            LastUpdate = lastUpdate;
            LastUpdatedBy = lastUpdatedBy;
        }
    }
}
