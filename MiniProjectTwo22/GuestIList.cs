using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjectTwo22
{
    public static class GuestIList
    {
        public static void GreetingGuests()
        {
            Console.WriteLine("Hello Dear Gusts.");
            Console.WriteLine("welcome to the Guest List Apllication,");
            Console.WriteLine("I Will Hope you all Have a Great Moments");
            Console.WriteLine("Please Answer Following Questions:");
            Console.WriteLine("*******************************************");
        }

        public static string GetGuestsNames()
        {
            string lastName = "";
            {
                Console.WriteLine("What is Your Last Name?");
                if (lastName != "" || lastName != " ")
                {
                    lastName = Console.ReadLine();
                }

            }
            return lastName;
        }

        public static int GetNumberOfGuests()
        {
            bool validNum;
            Console.WriteLine("How Many People Are There in Your Group?");
            string number = Console.ReadLine();
            validNum = int.TryParse(number, out int guestNumber);
            return guestNumber;
        }

        public static bool IsExit()
        {
            bool isExit=false;
            Console.WriteLine("If Your List is Done type 'Exit'");
            string exit = Console.ReadLine();
            if (exit == "exit")
            {
                isExit = true;
            } else {
                isExit = false;
            };
            return isExit;

        }

        public static (List<string> lastName, List<int> guestNumber) GetListOfGuests(string lastName, int guestNumber)
        {
            List<string> lastNames = new List<string>();
            List<int> numberOfGuests = new List<int>();
            lastNames.Add(lastName);
            numberOfGuests.Add(guestNumber);
            return (lastNames, numberOfGuests);
        }
    }
}
