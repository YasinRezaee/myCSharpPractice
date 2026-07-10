using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHomeWork21
{
    internal class GreetingUsers
    {
   
        public static void Greeting()
    {
        Console.WriteLine("Welcome to our fake program");
    }
    public static string FirstName()
    {
        Console.WriteLine("What is your first name?");
        string firstName = Console.ReadLine();
        return firstName;
    }

        public static void UserName(string firstName)
        {
            Console.WriteLine($"Hello  {firstName}");
        }

}
}
