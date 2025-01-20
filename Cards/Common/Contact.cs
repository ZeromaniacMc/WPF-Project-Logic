using System;
using System.Collections.Generic;

namespace WPF_Project_Logic.Cards.Common
{
    public class Contact {

        private List<Address> contactAddress = new List<Address>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }

        public List<Address> ContactAdress
        {
            get { return contactAddress; }
            set { contactAddress = value; }
        }

        // Constructor without a note
        public Contact(string firstName, string lastName, string email, string phone, List<Address> contactAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            ContactAdress = contactAddress;
        }

        // Overloaded constructor with a note
        public Contact(string firstName, string lastName, string email, string phone, List<Address> contactAddress, string note)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            ContactAdress = contactAddress;
            Note = note;
        }
    }

    public class Address
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
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
