using System;
using WPF_Project_Logic.Cards.Common.Agency;

namespace WPF_Project_Logic.Cards.Common.Card {
    public abstract class Card {


        // This forces any class that inherits from 'Card' to define its own 'Name'.
        public abstract string Name { get; set; }
        public abstract int ID { get; set; }
       
        // Assign the 'name' value in the subclass when it's created.
        protected Card(string name, int id) {

        // Validate the name and get the validation result
        string validationMessage = Validation.ValidateName(name);

        }
    }
}
