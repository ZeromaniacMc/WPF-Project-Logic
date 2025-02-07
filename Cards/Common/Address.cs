using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_Logic.Cards.Common
{
    public class Address
    {
        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }

        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        private readonly DataType dataType = DataType.Address;
        
        public Address(string streetName, int streetNumber, int zipCode, string city, string country)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
            ZipCode = zipCode;
            City = city;
            Country = country;
        }
    }
}
