using System;

namespace WPF_Project_Logic.Cards.Common.Helper {
    public class Helper {


        private static readonly Random random = new Random();

        /// <summary>
        /// A simple comma and space to be reused in all lists
        /// </summary>
        public static string listSeparator = ", ";

        public int generateID() {
            return random.Next(1, 1000);
        }

        public static bool checkIsIdUnique(int id) {
        return true;
        }
    }
}
