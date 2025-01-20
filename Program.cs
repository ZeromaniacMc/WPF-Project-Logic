using System;
using WPF_Project_Logic.Cards.Project;
using WPF_Project_Logic.Cards.Agency;
using WPF_Project_Logic.Cards.Client;
using WPF_Project_Logic.Cards.Common;

namespace WPF_Project_Logic {
    internal class Program {
        static void Main(string[] args) {

            DataFeeder feeder = new DataFeeder();

            // Build and print Client data
            Client client = feeder.BuildSampleClient();
            Console.WriteLine("--- Client Data ---");
            Console.WriteLine($"Client ID: {client.Id}");
            Console.WriteLine($"First Name: {client.selfContact.FirstName}");
            Console.WriteLine($"Last Name: {client.selfContact.LastName}");
            Console.WriteLine($"Phone: {client.selfContact.Phone}");
            Console.WriteLine($"Email: {client.selfContact.Email}");
            Console.WriteLine();

            // Build and print Project data
            Project project = feeder.BuildSampleProject();
            Console.WriteLine("--- Project Data ---");
            Console.WriteLine($"Project ID: {project.Id}");
            Console.WriteLine($"Project Name: {project.Name}");
            Console.WriteLine();

            // Build and print Agency data
            Agency agency = feeder.BuildSampleAgency();
            Console.WriteLine("--- Agency Data ---");
            Console.WriteLine($"Agency ID: {agency.Id}");
            Console.WriteLine($"Contact First Name: {agency.selfContact.FirstName}");
            Console.WriteLine($"Contact Last Name: {agency.selfContact.LastName}");
            if (agency.additionalContacts.Count > 0)
            {
                Console.WriteLine("Additional Contacts:");
                foreach (var contacts in agency.additionalContacts)
                {
                    Console.WriteLine($"  First Name: {contacts.FirstName}");
                    Console.WriteLine($"  Last Name: {contacts.LastName}");
                    Console.WriteLine($"  Email: {contacts.Email}");
                    Console.WriteLine($"  Phone: {contacts.Phone}");
                }
            }
            Console.WriteLine();

            // Build and print Contact data
            Contact contact = feeder.BuildSampleContact();
            Console.WriteLine("--- Contact Data ---");
            Console.WriteLine($"First Name: {contact.FirstName}");
            Console.WriteLine($"Last Name: {contact.LastName}");
            Console.WriteLine($"Email: {contact.Email}");
            Console.WriteLine($"Phone: {contact.Phone}");
            Console.WriteLine();

            // Build and print Address data
            Address address = feeder.BuildSampleAddress();
            Console.WriteLine("--- Address Data ---");
            Console.WriteLine($"Street: {address.StreetName} {address.StreetNumber}");
            Console.WriteLine($"Zip Code: {address.ZipCode}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Country: {address.Country}");


        }
    }
}
