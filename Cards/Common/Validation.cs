using System;
using System.Text.RegularExpressions;

namespace WPF_Project_Logic.Cards.Common.Agency {
    public static class Validation {

        // Regular expression that matches only Latin letters (including Croatian characters) and spaces
        private static readonly Regex validNameRegex = new Regex(@"^[a-zA-ZčćžšđČĆŽŠĐ ]+$");

        // Method to validate the name and return detailed error message
        public static bool ValidateName(string name) {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) {
                Console.WriteLine("Name should not be null, empty, or just spaces.");
                return false;
            }

            // Check each character to see if it's a valid letter or space
            for (int i = 0; i < name.Length; i++) {
                char currentChar = name[i];

                if (!Char.IsLetter(currentChar) && currentChar != ' ') {
                    // Return a message showing the exact invalid character and its position
                    Console.WriteLine($"Invalid character '{currentChar}' at position {i + 1}. Only letters and spaces are allowed.");
                    return false;
                }
            }
         return true;
        }
    }
}