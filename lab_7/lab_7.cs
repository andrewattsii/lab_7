using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace lab_7
{
    class lab_7
    {

        public static bool GetName()
        {
            Console.WriteLine("Please enter your full name :");
            string name = Console.ReadLine();

            bool regexvar = Regex.IsMatch(name, @"\b([A-Z][a-z]{1,30})\b");
            if (regexvar)
            {
                Console.WriteLine("Thanks you for inputing your name :");
            }
            else
            {
                Console.WriteLine("please enter a valid full name.");
            }
            return regexvar;
        }

        public static bool GetEmail()
        {
            Console.WriteLine("Please enter a valid e-mail :");
            string name1 = Console.ReadLine();
            bool regevar1 = Regex.IsMatch(name1, @"/([0-9a-zA-Z]{5,30})+(@)+([0-9a-zA-Z]{5,10})(\.)([0-9a-z]){2,3}");
            if (regevar1 == true)
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Please enter a valid email : ");
            }
            return regevar1;
        }

        public static bool GetPhoneNumber()
        {
            Console.WriteLine("Pease enter a phone phone number :");
            string number = Console.ReadLine();
            bool regevar2 = Regex.IsMatch(number, @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
            if (regevar2 == true)
            {
                Console.WriteLine("Phone number is valid");
            }
            else
            {
                Console.WriteLine("Number is invalid");
            }
            return regevar2;
        }
        public static bool GetDate()
        {
            Console.WriteLine("Please enter a valid date");
            string date = Console.ReadLine();
            bool regevar3 = Regex.IsMatch(date, @"^(3[01]|[12][0-9]|0[1-9])/(1[0-2]|0[1-9])/[0-9]{4}$");
            if (regevar3 == true)
            {
                Console.WriteLine("Date is valid");
            }
            else
            {
                Console.WriteLine("Date is not valid");
            }
            return regevar3;
        }
    }
}
