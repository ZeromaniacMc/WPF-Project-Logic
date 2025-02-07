using System;
using System.Text.Json;
using System.Threading.Tasks;
using WPF_Project_Logic.Cards.Agency;
using WPF_Project_Logic.Cards.Client;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Company;
using WPF_Project_Logic.FileIO;

namespace WPF_Project_Logic {
    internal class Program
    {
        static async Task Main(string[] args)
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

            /*
            // Write test
            if (iO.CheckDirectoryExists(directory, false))
            {
                //CommonIO.WriteTextAsync(directory, filename, serializer.SerializeJSON(client), false).Wait();
                //CommonIO.WriteTextAsync(directory, filename, serializer.SerializeJSON(contact), false).Wait();
                CommonIO.WriteTextAsync(directory, filename, serializer.SerializeJSON(agency), false).Wait();
            }

            else
            {
                Console.WriteLine("Directory does not exist, creating it now.");
                iO.CreateDirectory(directory, false);
            }

            */

            // Read test
            object deserializedObject = await JSON.DeserializeJSONAsync(await CommonIO.ReadTextAsync(directory, filename, false));

            if (deserializedObject != null)
            {
                if (deserializedObject is Contact)
                {
                    Console.WriteLine($"Deserialized as Contact. \nFirstName: {contact.FirstName}");
                    Console.WriteLine($"DataType: {(int)DataType.Contact}"); // Print DataType enum value as int
                }
                else if (deserializedObject is Address)
                {
                    Console.WriteLine($"Deserialized as Address. \nCity: {address.City}");
                    Console.WriteLine($"DataType: {(int)DataType.Address}"); // Print DataType enum value as int
                }
                else if (deserializedObject is Company)
                {
                    Console.WriteLine($"Deserialized as Company. \nName: {((Company)deserializedObject).Name}");
                    Console.WriteLine($"DataType: {(int)DataType.Company}"); // Print DataType enum value as int
                }
                else if (deserializedObject is Agency)
                {
                    Console.WriteLine($"Deserialized as Agency.\n");
                    Console.WriteLine($"DataType: {(int)DataType.Agency}"); // Print DataType enum value as int
                    Console.WriteLine($"DataType: {DataType.Agency}"); // Print DataType as type string
                    Console.WriteLine($"ID: {((Agency)deserializedObject).ID}");
                    Console.WriteLine($"First Name: {((Agency)deserializedObject).SelfContact.FirstName}");
                    Console.WriteLine($"Last Name: {((Agency)deserializedObject).SelfContact.LastName}");
                }
                else if (deserializedObject is Client)
                {
                    Console.WriteLine($"Deserialized as Client. \nName: {((Client)deserializedObject).SelfContact.FirstName}");
                    Console.WriteLine($"DataType: {(int)DataType.Client}"); // Print DataType enum value as int
                }
                else
                {
                    Console.WriteLine("Deserialized object is of an unexpected type.");
                }
            }
            else
            {
                Console.WriteLine("Failed to deserialize JSON.");
            }
            Console.ReadLine();
        }
    }
}
