using System;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

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


        public void ReadJSON()
        {
        }

        public void UpdateJSON()
        {
        }

        public void DeleteJSON()
        {
        }

        public void CreateJSON()
        {
        }

    }
}
