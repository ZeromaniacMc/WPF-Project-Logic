using System;

namespace WPF_Project_Logic.Cards.Common.Helper {
    internal class Helper {


        /* user input from console helper
         * parse data types
         * generate id, verify id does not already exist (database call)
         */

        public int generateID() {
            Random random = new Random();
            int id = random.Next(1, 8);
            return id;
        }

        public bool checkIsIdUnique(int id) {
        return true;
        }
    }
}
