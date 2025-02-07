using System;
using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common.Agency;

namespace WPF_Project_Logic.Cards.Common.Card {
    public abstract class Card {


        public abstract Contact SelfContact { get; set; }
        public abstract int ID { get; set; }
        public abstract List<Contact> AdditionalContacts { get; set; }

        public abstract List<Note> Notes { get; set; }

        protected Card() { }
        protected Card(Contact SelfContact, int ID, List<Contact> AdditionalContacts, List<Note> Notes)
        {
            this.SelfContact = SelfContact;
            this.ID = ID;
            this.AdditionalContacts = AdditionalContacts;
            this.Notes = Notes;
        }

        protected Card(Contact SelfContact, int ID, List<Contact> AdditionalContacts)
            : this(SelfContact, ID, AdditionalContacts, new List<Note>())
        {
            this.SelfContact = SelfContact;
            this.ID = ID;
            this.AdditionalContacts = AdditionalContacts;
        }

        
    }
}
