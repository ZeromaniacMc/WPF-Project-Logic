using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Project_Logic.Cards.Agency;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Helper;

namespace WPF_Project_Logic.Cards.Company {
    internal class Company
    {
        private int companyId = Helper.generateID();
        private Contact companySelf;
        private readonly DataType dataType = DataType.Company;
        private List<Contact> companyContacts;
        private string name;

        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }
        public int ID
        {
            get { return companyId; }
            set { companyId = value; }
        }
        public Contact SelfContact
        {
            get { return companySelf; }
            set { companySelf = value; }
        }

        public List<Contact> AdditonalContacts
        {
            get { return companyContacts; }
            set { companyContacts = value; }
        }

        public string Name { get; set; }



        public Company() { }
        public Company(string Name, Contact SelfContact, int ID, List<Contact> AdditonalContacts)
        {
        }
    }
}
