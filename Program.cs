using System;
using WPF_Project_Logic.Cards.Project;
using WPF_Project_Logic.Cards.Agency;
using WPF_Project_Logic.Cards.Client;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.FileIO;
using System.IO;
using System.Text;

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
            /*
            Console.WriteLine(serializer.SerializeJSON(address) + "--------------------\n\n");
            Console.WriteLine(serializer.SerializeJSON(contact) + "--------------------\n\n");
            Console.WriteLine(serializer.SerializeJSON(agency) + "--------------------\n\n");
            Console.WriteLine(serializer.SerializeJSON(client) + "--------------------\n\n");
            */


            CommonIO iO = new CommonIO();
            string directory = "C:\\Users\\PC\\Documents\\Boris";
            string filename = "test.txt";

            // Gotta remember that i cant just summon folders to save files, we first need
            // to assert that the user defined a location to save their data to. Could use a setting in the settings file
            // to determine if the program ran before or not (needs location set). Something like: "FirstRun": true or I could
            // skip that and check if the path is empty or not. If it is, prompt the user to set a location to save their data to.
            // Gonna ponder this for a day.
            // Regardless of the location, we will need the following files:
            // settings.json
            // clients.json
            // projects.json
            // agencies.json
            // companies.json

            // Write test
            if (iO.CheckDirectoryExists(directory, false))
            {
                Console.WriteLine("Directory exists");
                //CommonIO.WriteTextAsync(directory, filename, serializer.SerializeJSON(client), false).Wait();
                //CommonIO.WriteTextAsync(directory, filename, serializer.SerializeJSON(contact), false).Wait();
                CommonIO.WriteTextAsync(directory, filename, serializer.SerializeJSON(agency), false).Wait();
            }

            else
            {
                Console.WriteLine("Directory does not exist, creating it now.");
                iO.CreateDirectory(directory, false);
            }
            
            /*
            // Read test
            if (iO.CheckFileExists(filename, directory, false))
            {
                Console.WriteLine("File exists");
                Console.WriteLine(CommonIO.ReadTextAsync(directory, filename, false).Result);
            }
            else
            {
                Console.WriteLine($"{directory}{filename}");
                Console.WriteLine("File does not exist");
            }
            */

            Console.ReadLine();
        }
    }
}
