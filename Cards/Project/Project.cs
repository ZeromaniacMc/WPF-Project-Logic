using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Helper;

namespace WPF_Project_Logic.Cards.Project {
    public class Project
    {

        /// <summary>
        /// <param name="projectName"> The name of the project as string. </param>
        /// </summary>
        private string projectName;

        /// <summary>
        /// <param name="projectId"> The automatically generated ID of the project as int. </param>
        /// </summary>
        private int projectId = Helper.generateID();

        /// <summary>
        /// <param name="associatedClient"> The <c>Client Object</c> associated with this project. </param>
        /// </summary>
        private Client.Client associatedClient;

        /// <summary>
        /// <param name="dataType"> The type of data associated with this project. </param>
        /// </summary>
        private readonly DataType dataType = DataType.Project;



        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public int ID
        {
            get { return projectId; }
            set { projectId = value; }
        }

        /// <summary>
        /// Client associated with the current Project 
        /// </summary>
        /// <returns>Client Object from database lookup, else default set</returns>
        public Client.Client AssociatedClient
        {
            get { return associatedClient; }
            set { associatedClient = value; }
        }

        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }

        public Project() {}
        public Project(string ProjectName, int ID, Client.Client AssociatedClient, List<Note> notes)
        {

        }

        public Project(string ProjectName, int ID, Client.Client AssociatedClient)
        {

        }
    }
 }
