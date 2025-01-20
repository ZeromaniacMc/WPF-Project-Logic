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
        private Contact agencySelf;

        /// <summary>
        /// <param name="agencyId"> The automatically generated ID of the agency as int. </param>
        /// </summary>
        private int agencyId;

        /// <summary>
        /// A List of contacts for the agency
        /// </summary>
        private List<Contact> agencyContacts;

        /// <summary>
        /// A List of notes for the agency where notes carry timestamp, header and description
        /// </summary>
        private List<Note> agencyNotes;

        private readonly DataType dataType = DataType.Agency;


        public override Contact selfContact
        {
            get { return agencySelf; }
            set { agencySelf = value; }
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

        public override List<Note> Notes
        {
            get { return agencyNotes; }
            set { agencyNotes = value; }
        }

        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }


        public Agency(Contact selfContact, int id, List<Contact> additionalContacts, List<Note> Notes) : base(selfContact, id, additionalContacts, Notes)
        {

        }
        public Agency(Contact selfContact, int id, List<Contact> additionalContacts)
        : this(selfContact, id, additionalContacts, new List<Note>())
        {
            // Calls base constructor, provides an empty list of notes as default.
        }
    }
}
