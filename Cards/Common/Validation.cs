using System;
using System.Text.RegularExpressions;

namespace WPF_Project_Logic.Cards.Common.Agency {
    public static class Validation {

        /* Repetitive needs
         * date to string
         * string check not null or empty
         * string forbid funky characters like brackets etc using regex?
         * id generation
         * uniform string length for names, street names, province and emails
         */

        /* Rules for agency entries
         * name, id, email and address and 1 contact are not optional
         * 
         * name = string, not "", not null, length 3-50 chars
         * id = generated using date created plus a random number, ddmmyyyy-xxxxxx
         * email = must contain '@', length 3-50?
         * contact
         *      name = string, not "", not null, length 3-50 chars
         *      // TODO: decide phone format
         *      phone = 
         *      address
         *          street = string
         *          street number = ubyte
         *          zip = length < 16, only num
         *          province = string
         *          TODO: check out documentation about culture and iso
         *          country = check culture using iso standards
         *      
         */

        // TODO: Switch statement, use DataType enums as identifier, to validate input as each type needs differently
        // assempbled validations in and under different subgroups of data.


        // Regular expression that matches only Latin letters (including Croatian characters) and spaces
        private static readonly Regex validNameRegex = new Regex(@"^[a-zA-ZčćžšđČĆŽŠĐ ]+$");

        // Method to validate the name and return detailed error message
        public static string ValidateName(string name) {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name)) {
                return "Name should not be null, empty, or just spaces.";
            }

            // Check each character to see if it's a valid letter or space
            for (int i = 0; i < name.Length; i++) {
                char currentChar = name[i];

                if (!Char.IsLetter(currentChar) && currentChar != ' ') {
                    // Return a message showing the exact invalid character and its position
                    return $"Invalid character '{currentChar}' at position {i + 1}. Only letters and spaces are allowed.";
                }
            }

            // If no invalid characters were found, return null (indicating success)
            return null; // No error, name is valid
        }
    }
}