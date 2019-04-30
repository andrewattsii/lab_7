using System;
using System.Text.RegularExpressions;

namespace lab_7
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                lab_7.GetName();
            }
            catch(Exception NotValid)
            {
                Console.WriteLine(NotValid.Message);
            }


            try
            {
                lab_7.GetEmail();
            }
            catch(Exception NotValidOne)
            {
                Console.WriteLine(NotValidOne.Message);
            }



            try
            {
                lab_7.GetPhoneNumber();
            }
            catch (Exception NotValidTwo)
            {
                Console.WriteLine(NotValidTwo.Message);
            }

            try
            {
                lab_7.GetDate();
            }
            catch(Exception NotValidThree)
            {
                Console.WriteLine(NotValidThree.Message);
            }



            

        }
    }
}
