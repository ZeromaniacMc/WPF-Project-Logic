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
        /// Getter and setter for the <c>Name</c>.
        /// </summary>
        public override string Name {
            get { return agencyName; }
            set { agencyName = value; }
        }

        /// <summary>
        /// Getter and setter for the <c>Id</c>.
        /// </summary>
        public override int ID {
            get { return agencyId; }
            set { agencyId = value; }
        }

        /// <summary>
        /// Identifier of DataType as <c>Agency</c> via Enum. Used for validations in switch statements. 
        /// </summary>
        public DataType CardType { get; set; }
        public Agency(string name, int id) : base(name, id)
        {
            CardType = DataType.Agency;
        }
    }
}
