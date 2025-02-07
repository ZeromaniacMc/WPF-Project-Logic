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

        static Project sampleProject = new Project("",-1,null);
        static Client sampleClient = new Client(new Contact("", "", "", "", new List<Address>()), -1, new List<Contact>()); 
        static Agency sampleAgency = new Agency(new Contact("","","","",new List<Address>()),-1,new List<Contact>());

        public Contact sampleContact = new Contact("", "", "", "", new List<Address>());
        public Address sampleAddress = new Address("", -1, -1, "", "");

        /// <summary>
        /// A static Client for testing
        /// </summary>
        /// <returns>Client Object</returns>
        public Client BuildSampleClient() {
            string type = sampleClient.DataType.ToString();
            sampleClient.selfContact.FirstName = "Svenk";
            sampleClient.selfContact.LastName = "Svenk";
            sampleClient.selfContact.Phone = "01255788957";
            sampleClient.selfContact.Email = "schglibglob@gmail.com";
            sampleClient.selfContact.Equals(sampleContact);
            sampleClient.Notes.Add(new Note("First Note", "This is the first note",System.DateTime.Now));

            sampleClient.Id = helper.generateID();

            return sampleClient;
        }

        /// <summary>
        /// A static Project for testing
        /// </summary>
        /// <returns>Project Object</returns>
        public Project BuildSampleProject() {
            string type = sampleProject.DataType.ToString();
            sampleProject.Name = "RBA mobilno bankarstvo";
            sampleProject.Id = helper.generateID();
            sampleProject.AssociatedClient = BuildSampleClient();

            return sampleProject; 
        }

        /// <summary>
        /// A static Agency for testing
        /// </summary>
        /// <returns>Agency Object</returns>
        public Agency BuildSampleAgency()
        {
            Contact agencyContact = BuildSampleContact();
            string type = sampleAgency.DataType.ToString();
            sampleAgency.selfContact = agencyContact;
            sampleAgency.additionalContacts.Add(agencyContact);
            sampleAgency.Id = helper.generateID();
            return sampleAgency;
        }

        /// <summary>
        /// A static Contact for testing
        /// </summary>
        /// <returns>Contact Object</returns>
        public Contact BuildSampleContact() {
            string type = sampleContact.DataType.ToString();
            sampleContact.FirstName = "Svenk";
            sampleContact.LastName = "Svenk";
            sampleContact.Email = "blabla@gmail.de";
            sampleContact.Phone = "01255788957";
            sampleContact.ContactAdress.Add(BuildSampleAddress());

            return sampleContact;
        }

        // An address to feed to the contact
        public Address BuildSampleAddress()
        {
            string type = sampleAddress.DataType.ToString();
            sampleAddress.StreetName = "Potočka";
            sampleAddress.StreetNumber = 61;
            sampleAddress.ZipCode = 84260;
            sampleAddress.City = "Križevci";
            sampleAddress.Country = "Hrvatska";
            return sampleAddress;
        }
    } 
}
