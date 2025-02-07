using System;
using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Card;
using WPF_Project_Logic.Cards.Common.Helper;

namespace WPF_Project_Logic.Cards.Agency {
    internal class Agency : Card {

        /// <summary>
        /// The agency themself.
        /// We need not worry about the Address here, as it is already defined in the Contact class.
        /// </summary>
        private Contact agencySelf;

        /// <summary>
        /// <param name="agencyId"> The automatically generated ID of the agency as int. </param>
        /// </summary>
        private int agencyId = Helper.generateID();

        /// <summary>
        /// A List of contacts for the agency
        /// </summary>
        private List<Contact> agencyContacts;

        /// <summary>
        /// A List of notes for the agency where notes carry timestamp, header and description
        /// </summary>
        private List<Note> agencyNotes;

        private readonly DataType dataType = DataType.Agency;

        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }

        public override int ID
        {
            get { return agencyId; }
            set { agencyId = value; }
        }

        public override Contact SelfContact
        {
            get { return agencySelf; }
            set { agencySelf = value; }
        }


        // As we want to add multiple contacts later, we need a modular list of contacts, which are also lists.
        public override List<Contact> AdditionalContacts
        {
            get { return agencyContacts; }
            set { agencyContacts = value; }
        }

        public override List<Note> Notes
        {
            get { return agencyNotes; }
            set { agencyNotes = value; }
        }


        public Agency(){}
        public Agency(Contact SelfContact, int ID, List<Contact> AdditionalContacts, List<Note> Notes) 
            : base(SelfContact, ID, AdditionalContacts, Notes)
        {

        }
        public Agency(Contact SelfContact, int ID, List<Contact> AdditionalContacts)
        : this(SelfContact, ID, AdditionalContacts, new List<Note>())
        {
            // Calls base constructor, provides an empty list of notes as default.
        }
    }
}
