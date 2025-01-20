using System;
using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Card;

namespace WPF_Project_Logic.Cards.Agency {
    internal class Agency : Card {

        /// <summary>
        /// The agency themself.
        /// We need not worry about the Address here, as it is already defined in the Contact class.
        /// </summary>
        private Contact agencytSelf = new Contact("", "", "", "", new List<Address>());

        /// <summary>
        /// <param name="agencyId"> The automatically generated ID of the agency as int. </param>
        /// </summary>
        private int agencyId;

        /// <summary>
        /// A List of contacts for the agency
        /// </summary>
        private List<Contact> agencyContacts = new List<Contact>();

        private readonly DataType dataType = DataType.Agency;



        public override Contact selfContact
        {
            get { return agencytSelf; }
            set { agencytSelf = value; }
        }

        public override int Id {
            get { return agencyId; }
            set { agencyId = value; }
        }

        // As we want to add multiple contacts later, we need a modular list of contacts, which are also lists.
        public override List<Contact> additionalContacts
        {
            get { return agencyContacts; }
            set { agencyContacts = value; }
        }

        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }


        public Agency(Contact selfContact, int id, List<Contact> additionalContacts) : base(selfContact, id, additionalContacts)
        {
        }
    }
}
