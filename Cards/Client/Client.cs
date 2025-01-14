using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Card;

namespace WPF_Project_Logic.Cards.Client {
    public class Client : Card {

        /// <summary>
        /// <param name="clientName"> The name of the client as string. </param>
        /// </summary>
        private string clientName;

        /// <summary>
        /// <param name="clientId"> The automatically generated ID of the client as int. </param>
        /// </summary>
        private int clientId;

        /// <summary>
        /// <param name="clientEmail"> The email address of the client as string. </param>
        /// </summary>
        private string clientEmail;

        /// <summary>
        /// Getter and setter for the <c>Name</c>.
        /// </summary>
        public override string Name {
            get { return clientName; }
            set { clientName = value; }
        }

        /// <summary>
        /// Getter and setter for the <c>Id</c>.
        /// </summary>
        public override int ID {
            get { return clientId; }
            set { clientId = value; }
        }

        /// <summary>
        /// Getter and setter for the <c>Email</c>.
        /// </summary>
        public string EMAIL
        {
            get { return clientEmail; }
            set { clientEmail = value; }
        }

        /// <summary>
        /// Identifier of DataType as <c>Client</c> via Enum. Used for validations in switch statements. 
        /// </summary>
        public DataType CardType { get; set; }

        // This is where we pass the 'name' to the base class so the base class knows the 'name' value.
        public Client(string name, int id) : base(name, id) {
            CardType = DataType.Client;
        }
    }
}
