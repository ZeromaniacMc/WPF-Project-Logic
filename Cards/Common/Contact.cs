using System;
using System.Collections.Generic;

namespace WPF_Project_Logic.Cards.Common
{
    public class Contact {

        private List<object> contactAddress = new List<object>();

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public List<object> ContactAdress
        {
            get { return contactAddress; }
            set { contactAddress = value; }
        }

        public Contact(string firstName, string lastName, string email, string phone, List<Object> contactAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            ContactAdress = contactAddress;
        }
    }
}
