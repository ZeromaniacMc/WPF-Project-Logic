using System.Collections.Generic;
using WPF_Project_Logic.Cards.Agency;
using WPF_Project_Logic.Cards.Client;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Helper;
using WPF_Project_Logic.Cards.Project;

namespace WPF_Project_Logic
{
    // TODO: Nuke this class as soon as we have database access
    internal class DataFeeder {

        Helper helper = new Helper();

        static Project sampleProject = new Project();
        static Client sampleClient = new Client(new Contact("", "", "", "", new List<Address>()), -1, new List<Contact>()); 
        static Agency sampleAgency = new Agency(new Contact("","","","",new List<Address>()),-1,new List<Contact>());

        public Contact sampleContact = new Contact("", "", "", "", new List<Address>());
        public Address sampleAddress = new Address("", -1, -1, "", "");

        /// <summary>
        /// A static Client for testing
        /// </summary>
        /// <returns>Client Object</returns>
        public Client BuildSampleClient() {
            sampleClient.selfContact.FirstName = "Svenk";
            sampleClient.selfContact.LastName = "Svenk";
            sampleClient.selfContact.Phone = "01255788957";
            sampleClient.selfContact.Email = "schglibglob@gmail.com";

            sampleClient.Id = helper.generateID();

            return sampleClient;
        }

        /// <summary>
        /// A static Project for testing
        /// </summary>
        /// <returns>Project Object</returns>
        public Project BuildSampleProject() {
            sampleProject.Name = "RBA mobilno bankarstvo";
            sampleProject.Id = helper.generateID();

            return sampleProject; 
        }

        /// <summary>
        /// A static Agency for testing
        /// </summary>
        /// <returns>Agency Object</returns>
        // TODO: Consider using the contact object here? Only ID would be needed outside of Contact object...
        public Agency BuildSampleAgency()
        {
            // Build a new Contact object with data
            Contact agencyContact = BuildSampleContact();
            sampleAgency.selfContact = agencyContact;
            sampleAgency.additionalContacts.Add(agencyContact); // Or build another contact if needed
            sampleAgency.Id = helper.generateID();
            return sampleAgency;
        }

        /// <summary>
        /// A static Contact for testing
        /// </summary>
        /// <returns>Contact Object</returns>
        public Contact BuildSampleContact() {
            sampleContact.FirstName = "Svenk";
            sampleContact.LastName = "Svenk";
            sampleContact.Email = "blabla@gmail.de";
            sampleContact.Phone = "01255788957";

            return sampleContact;
        }

        // An address to feed to the contact
        public Address BuildSampleAddress()
        {
            sampleAddress.StreetName = "Potočka";
            sampleAddress.StreetNumber = 61;
            sampleAddress.ZipCode = 84260;
            sampleAddress.City = "Križevci";
            sampleAddress.Country = "Hrvatska";
            return sampleAddress;
        }
    } 
}
