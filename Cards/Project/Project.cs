using System;
using WPF_Project_Logic.Cards.Common.Card;

namespace WPF_Project_Logic.Cards.Project {
    public class Project : Card {

        private String name;
        private int id;

        // Implement the 'Name' property. This fulfills the contract set by the abstract 'Card' class.
        public override string Name {
            get { return name; }
            set { name = value; }
        }

        public override int ID {
            get { return id; }
            set { id = value; }
        }

        // This is where we pass the 'name' to the base class so the base class knows the 'name' value.
        public Project(string name, int id) : base(name,id) {
            
        }
    }
 }
