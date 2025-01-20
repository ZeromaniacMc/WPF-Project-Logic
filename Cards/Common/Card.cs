using System;
using System.Collections.Generic;
using WPF_Project_Logic.Cards.Common.Agency;

namespace WPF_Project_Logic.Cards.Common.Card {
    public abstract class Card {


        public abstract Contact selfContact { get; set; }
        public abstract int Id { get; set; }
        public abstract List<Contact> additionalContacts { get; set; }


        // Assign the 'name' value in the subclass when it's created.
        protected Card(Contact selfcontact, int id, List<Contact> additionalContacts) {

        }
    }
}
