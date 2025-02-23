﻿using System;
using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common;
using WPF_Project_Logic.Cards.Common.Card;
using WPF_Project_Logic.Cards.Common.Helper;

namespace WPF_Project_Logic.Cards.Client {
    public class Client : Card {

        /// <summary>
        /// The client themself.
        /// We need not worry about the Address here, as it is already defined in the Contact class.
        /// </summary>
        private Contact clientSelf;

        /// <summary>
        /// <param name="clientId"> The automatically generated ID of the client as int. </param>
        /// </summary>
        private int clientId = Helper.generateID();

        /// <summary>
        /// A List of contacts for the client
        /// </summary>
        private List<Contact> clientContacts;

        /// <summary>
        /// A DateTime object containing the date the client first hired the user
        /// </summary>
        private DateTime clientFirstHire = new DateTime();

        private readonly DataType dataType = DataType.Client;

        /// <summary>
        /// A List of notes for the client where notes carry timestamp, header and description
        /// </summary>
        private List<Note> clientNotes;



        public DataType DataType
        {
            get { return dataType; }
            // No setter! This is a read-only property.
        }

        public override int ID
        {
            get { return clientId; }
            set { clientId = value; }
        }

        public DateTime firstHire
        {
            get { return clientFirstHire; }
            set { clientFirstHire = value; }
        }

        public override Contact SelfContact 
        {
            get { return clientSelf; }
            set { clientSelf = value; }
        }
        
        // As we want to add multiple contacts later, we need a modular list of contacts, which are also lists.
        // This list describes people the user may contact who also work at the client (which is a company).
        public override List<Contact> AdditionalContacts
        {
            get { return clientContacts; }
            set { clientContacts = value; }
        }

        public override List<Note> Notes
        {
            get { return clientNotes; }
            set { clientNotes = value; }
        }

        


        
        public Client(Contact SelfContact, int ID, List<Contact> AdditionalContacts) 
            : base(SelfContact, ID, AdditionalContacts)
        {

        }

        public Client(Contact SelfContact, int ID, List<Contact> AdditionalContacts, List<Note> notes) 
            : base(SelfContact, ID, AdditionalContacts, notes)
        {
            // Calls base constructor, provides an empty list of notes as default.
        }
    }
}

