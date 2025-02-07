using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WPF_Project_Logic.Cards.Common
{
    public class Contact {

        private List<Address> contactAddress = new List<Address>();

        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }

        private readonly DataType dataType = DataType.Contact;

        public List<Address> ContactAdress
        {
            get { return contactAddress; }
            set { contactAddress = value; }
        }
        public Contact()
        {
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
        //[JsonConstructor]
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
}
