using System;
using WPF_Project_Logic.Cards.Project;
using WPF_Project_Logic.Cards.Agency;
using WPF_Project_Logic.Cards.Client;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.FileIO;

namespace WPF_Project_Logic {
    internal class Program
    {
        static void Main(string[] args)
        {
            // Needed for croatian characters in console
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DataFeeder feeder = new DataFeeder();
            Client client = feeder.BuildSampleClient();
            Address address = feeder.sampleAddress;
            Contact contact = feeder.sampleContact;
            Agency agency = feeder.BuildSampleAgency();

            JSON serializer = new JSON();
            // Serialize the data to JSON
            Console.WriteLine(serializer.SerializeJSON(address) + "--------------------\n\n");
            Console.WriteLine(serializer.SerializeJSON(contact) + "--------------------\n\n");
            Console.WriteLine(serializer.SerializeJSON(agency) + "--------------------\n\n");
            Console.WriteLine(serializer.SerializeJSON(client) + "--------------------\n\n");

            Console.ReadLine();
        }
    }
}
