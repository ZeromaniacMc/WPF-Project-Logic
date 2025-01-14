using System;

namespace WPF_Project_Logic.Cards.Common.Helper {
    public static class Helper {


        /* user input from console helper
         * parse data types
         * generate id, verify id does not already exist (database call)
         */

        /// <summary>
        /// A simple comma and space to be reused in all lists
        /// </summary>
        public static string listSeparator = ", ";

        public static int generateID() {
            Random random = new Random();
            int id = random.Next(1, 8);
            return id;
        }

        public static bool checkIsIdUnique(int id) {
        return true;
        }
    }
}
