using System;
using System.Collections.Generic;
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
        /// A List containing the address as generic objects
        /// </summary>
        private List<object> clientAddress = new List<object>();

        /// <summary>
        /// A DateTime object containing the date the client first hired the user
        /// </summary>
        private DateTime clientFirstHire = new DateTime();



        public override string Name {
            get { return clientName; }
            set { clientName = value; }
        }

        public override int Id {
            get { return clientId; }
            set { clientId = value; }
        }

        public string Email
        {
            get { return clientEmail; }
            set { clientEmail = value; }
        }

        public List<object> Address
        {
            get { return clientAddress; }
            set { clientAddress = value; }
        }

        public DateTime FIRSTHIRE 
        {
            get { return clientFirstHire; }
            set { clientFirstHire = value; }
        }


        /// <summary>
        /// Identifier of DataType as <c>Client</c> via Enum. Used for validations in switch statements. 
        /// </summary>
        public DataType CardType { get; }

        // This is where we pass the 'name' to the base class so the base class knows the 'name' value.
        public Client(string name, int id) : base(name, id) {
            CardType = DataType.Client;
        }
    }
}
