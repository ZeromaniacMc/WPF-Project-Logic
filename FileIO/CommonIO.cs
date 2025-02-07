using System;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Project_Logic.FileIO
{
    internal class CommonIO
    {
        // TODO: Move to program settings
        bool debug = false;


        public bool CheckFileExists(string filename, string directory, bool debug)
        {
            string filepath = directory + "\\" + filename;

            if (System.IO.File.Exists(filepath))
            {
                if (debug)
                {
                    Console.WriteLine($"File exists: {filepath}");
                }
                return true;
            }
            else
            {
                if (debug)
                {
                    Console.WriteLine($"File could not be found: {filename} @ {filepath}");
                }
                return false;
            }
        }

        /// <summary>
        /// Writes text to a file - will use existing file or create one and append to it.
        /// Will not replace text but just append to it.
        /// </summary>
        /// <param name="directory"></param>
        /// <param name="filename"></param>
        /// <param name="text"></param>
        /// <param name="debug"></param>
        /// <returns></returns>
        public static async Task WriteTextAsync(string directory, string filename, string text, bool debug)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);
            string filepath = directory + "\\" + filename;
            using (FileStream sourceStream = new FileStream(filepath,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            };
        }


        public static async Task<string> ReadTextAsync(string directory, string filename, bool debug)
        {
            string filepath = directory + "\\" + filename;
            using (FileStream sourceStream = new FileStream(filepath,
                FileMode.Open, FileAccess.Read, FileShare.Read,
                bufferSize: 4096, useAsync: true))
            {
                StringBuilder sb = new StringBuilder();

                byte[] buffer = new byte[0x1000];
                int numRead;
                while ((numRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                {
                    string text = Encoding.Unicode.GetString(buffer, 0, numRead);
                    sb.Append(text);
                }
                return sb.ToString();
            }
        }

        public void DeleteFile(string filename, bool debug)
        {
            try
            {
                System.IO.File.Delete(filename);
                if (debug)
                {
                    Console.WriteLine($"File deleted: {filename}");
                }
            }
            catch
            {
                Console.WriteLine($"Error deleting file: {filename}");
                throw;
            }
        }

        public bool CheckDirectoryExists(String directory, bool debug)
        {
            if (System.IO.Directory.Exists(directory))
            {
                if (debug)
                {
                    Console.WriteLine($"Directory exists: {directory}");
                }
                return true;
            }
            else
            {
                if (debug)
                {
                    Console.WriteLine($"Directory could not be found: {directory}");
                }
                return false;
            }
        }

        public void DeleteDirectory(string directory, bool debug)
        {
            try
            {
                System.IO.Directory.Delete(directory);
                if (debug)
                {
                    Console.WriteLine($"Directory deleted: {directory}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting directory: {directory} - " + ex.Message);
                throw;
            }
        }

        public void CreateDirectory(string directory, bool debug)
        {
            try
            {
                System.IO.Directory.CreateDirectory(directory);
                if (debug)
                {
                    Console.WriteLine($"Directory created: {directory}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating directory: {directory} - " + ex.Message);
                throw;
            }
        }
    }
}



