using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Card;

namespace WPF_Project_Logic.Cards.Project {
    public class Project : Card {

        /// <summary>
        /// <param name="projectName"> The name of the project as string. </param>
        /// </summary>
        private string projectName;

        /// <summary>
        /// <param name="projectId"> The automatically generated ID of the project as int. </param>
        /// </summary>
        private int projectId;

        /// <summary>
        /// <param name="associatedClient"> The <c>Client Object</c> associated with this project. </param>
        /// </summary>
        private Client.Client associatedClient;

        /// <summary>
        /// Getter and setter for the <c>Name</c>.
        /// </summary>
        public override string Name {
            get { return projectName; }
            set { projectName = value; }
        }

        /// <summary>
        /// Getter and setter for the <c>Id</c>.
        /// </summary>
        public override int ID {
            get { return projectId; }
            set { projectId = value; }
        }

        /// <summary>
        /// Client associated with the current Project 
        /// </summary>
        /// <returns>Client Object from database lookup, else default set</returns>

        public Client.Client ASSOCIATEDCLIENT
        {
            get { return associatedClient; }
            set { associatedClient = value; }
        }

        /// <summary>
        /// Identifier of DataType as <c>Project</c> via Enum. Used for validations in switch statements. 
        /// </summary>
        public DataType CardType { get; set; }

        // This is where we pass the 'name' to the base class so the base class knows the 'name' value.
        public Project(string name, int id) : base(name,id) {
            CardType = DataType.Project;
        }

    }
 }
