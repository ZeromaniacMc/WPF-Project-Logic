using WPF_Project_Logic.Cards.Agency;
using WPF_Project_Logic.Cards.Client;
using WPF_Project_Logic.Cards.Common.Helper;
using WPF_Project_Logic.Cards.Project;

namespace WPF_Project_Logic
{
    // TODO: Nuke this class as soon as we have database access
    internal class DataFeeder {

        static Client sampleClient;
        static Project sampleProject;
        static Agency sampleAgency;
        
        /// <summary>
        /// A static Client for testing
        /// </summary>
        /// <returns>Client Object</returns>
        public Client BuildSampleClient() {
            sampleClient.Name = "RBA";
            sampleClient.ID = Helper.generateID();
            sampleClient.EMAIL = "Svenk@Svenk.com";

            return sampleClient;
        }

        /// <summary>
        /// A static Project for testing
        /// </summary>
        /// <returns>Project Object</returns>
        public Project BuildSampleProject() {
            sampleProject.Name = "RBA mobilno bankarstvo";
            sampleProject.ID = Helper.generateID();

            return sampleProject; 
        }

        /// <summary>
        /// A static Agency for testing
        /// </summary>
        /// <returns>Agency Object</returns>
        public Agency BuildSampleAgency() {
            sampleAgency.Name = "";
            sampleAgency.ID = Helper.generateID();
        
            return sampleAgency;
        }
    } 
}
