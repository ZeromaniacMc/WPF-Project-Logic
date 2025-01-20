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

        static Client sampleClient = new Client("", -1);
        static Project sampleProject = new Project("", -1);
        static Agency sampleAgency = new Agency("", -1);
        public Contact sampleContact = new Contact("", "", "", "", new List<object>());
        
        /// <summary>
        /// A static Client for testing
        /// </summary>
        /// <returns>Client Object</returns>
        public Client BuildSampleClient() {
            sampleClient.Name = "RBA";
            sampleClient.Id = Helper.generateID();
            sampleClient.Email = "Svenk@Svenk.com";

            return sampleClient;
        }

        /// <summary>
        /// A static Project for testing
        /// </summary>
        /// <returns>Project Object</returns>
        public Project BuildSampleProject() {
            sampleProject.Name = "RBA mobilno bankarstvo";
            sampleProject.Id = Helper.generateID();

            return sampleProject; 
        }

        /// <summary>
        /// A static Agency for testing
        /// </summary>
        /// <returns>Agency Object</returns>
        // TODO: Consider using the contact object here? Only ID would be needed outside of Contact object...
        public Agency BuildSampleAgency() {
            sampleAgency.Name = "Hello";
            sampleAgency.Id = Helper.generateID();

            sampleAgency.Adress.Add("Potočka");
            sampleAgency.Adress.Add(61);
            sampleAgency.Adress.Add(84260);
            sampleAgency.Adress.Add("Križevci");
            sampleAgency.Adress.Add("Hrvatska");

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

            sampleContact.ContactAdress.Add("Potočka");
            sampleContact.ContactAdress.Add(61);
            sampleContact.ContactAdress.Add(84260);
            sampleContact.ContactAdress.Add("Križevci");
            sampleContact.ContactAdress.Add("Hrvatska");

            return sampleContact;
        }
    } 
}
