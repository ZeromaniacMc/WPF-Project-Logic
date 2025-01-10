

namespace WPF_Project_Logic.Cards.Common.Card {
    public abstract class Card {

        // This forces any class that inherits from 'Card' to define its own 'Name'.
        public abstract string Name { get; set; }

        public abstract int ID { get; set; }

        // Assign the 'name' value in the subclass when it's created.
        protected Card(string name, int iD) {
            Name = name;
            ID = iD;
        }

    }
    
}
