

namespace WPF_Project_Logic.Cards.Common.Agency {
    internal class Validation {

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


    }
}
