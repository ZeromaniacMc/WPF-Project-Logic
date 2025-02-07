using System;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Company;
using WPF_Project_Logic.Cards.Project;
using WPF_Project_Logic.Cards.Client;
using WPF_Project_Logic.Cards.Agency;

namespace WPF_Project_Logic.FileIO
{
    public class JSON
    {
        // Use async

        public JSON() { }

        public string SerializeJSON(Object o)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.LatinExtendedA),
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(o, options);

            return json;
        }

        public static async Task<object> DeserializeJSONAsync(string jsonString)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };

                using (JsonDocument document = JsonDocument.Parse(jsonString)) // Parse JSON into JsonDocument
                {
                    JsonElement root = document.RootElement;

                    if (root.TryGetProperty("DataType", out JsonElement dataTypeElement) && dataTypeElement.TryGetInt32(out int dataTypeValue))
                    {
                        DataType dataType = (DataType)dataTypeValue; // Cast int to DataType enum

                        switch (dataType)
                        {
                            case DataType.Agency:
                                return root.Deserialize<Agency>(options); // Deserialize to Agency
                            case DataType.Client:
                                return root.Deserialize<Client>(options); // Deserialize to Client
                            case DataType.Project:
                                return root.Deserialize<Project>(options); // Deserialize to Project
                            case DataType.Company:
                                return root.Deserialize<Company>(options); // Deserialize to Company
                            case DataType.Contact:
                                return root.Deserialize<Contact>(options); // Deserialize to Contact
                            case DataType.Address:
                                return root.Deserialize<Address>(options); // Deserialize to Address
                            default:
                                Console.WriteLine($"Warning: Unknown DataType: {dataType}. Returning null.");
                                return null; // Handle unknown or unsupported DataType values
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error: DataType property not found or invalid in JSON.");
                        return null; // Handle cases where DataType is missing or not an integer
                    }
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing JSON: {ex.Message}");
                return null;
            }
        }
    }
}
