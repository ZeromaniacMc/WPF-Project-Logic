using System;
using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common.Agency;

namespace WPF_Project_Logic.Cards.Common.Card {
    public abstract class Card {


        public abstract Contact selfContact { get; set; }
        public abstract int Id { get; set; }
        public abstract List<Contact> additionalContacts { get; set; }

        public abstract List<Note> Notes { get; set; }


        protected Card(Contact selfContact, int id, List<Contact> additionalContacts, List<Note> Notes)
        {
            this.selfContact = selfContact;
            this.Id = id;
            this.additionalContacts = additionalContacts;
            this.Notes = Notes;
        }

        protected Card(Contact selfContact, int id, List<Contact> additionalContacts)
            : this(selfContact, id, additionalContacts, new List<Note>())
        {
            this.selfContact = selfContact;
            this.Id = id;
            this.additionalContacts = additionalContacts;
        }

        
    }
}
