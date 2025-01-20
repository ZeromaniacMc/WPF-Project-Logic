using System;
using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Card;

namespace WPF_Project_Logic.Cards.Agency {
    internal class Agency : Card {

        /// <summary>
        /// <param name="agencyName"> The name of the agency as string. </param>
        /// </summary>
        private string agencyName;

        /// <summary>
        /// <param name="agencyId"> The automatically generated ID of the agency as int. </param>
        /// </summary>
        private int agencyId;

        /// <summary>
        /// A List containing the address as generic objects
        /// </summary>
        private List<object> agencyAddress = new List<object>();



        public override string Name {
            get { return agencyName; }
            set { agencyName = value; }
        }

        public override int Id {
            get { return agencyId; }
            set { agencyId = value; }
        }

        public List<object> Adress
        {
            get { return agencyAddress; }
            set { agencyAddress = value; }
        }


        /// <summary>
        /// Identifier of DataType as <c>Agency</c> via Enum. Used for validations in switch statements. 
        /// </summary>
        public DataType CardType { get; }
        public Agency(string name, int id) : base(name, id)
        {
            CardType = DataType.Agency;
        }
    }
}
