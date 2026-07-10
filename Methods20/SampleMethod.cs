using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods 
{
    //internal static class SampleMethod
   public  static class SampleMethod
    {
        //what Static is, it allows us to make a call directly to the Methods,
        //without having to set things up first called instantiation,

        //public => it is Not about permissions,it simply means everybody can use this stuff.
     
        //internal=>it means there is private, which anyone inside of this scope can use it
        //but nobody else. the purpose is to not alow to call things that they really 
        //should not call directly.

        //void=> means this is a return value. this is what we gonna send back from the method.and 
        // void means nothing and Not returning anything.
        public static void SayHello()
        {
            Console.WriteLine("Hello User");
            // now we have a method called SayHello.
            //now we can call this method from program.cs
        }
        public static void GoodbyUser(string message)
        {
            Console.WriteLine(message ); 
        }
        public static void GreatingUser(string firstName, string meetingTime)
        {
            Console.WriteLine($"Hello {firstName} , you have a meeting at {meetingTime} clock");
        }

        public static void GreetLastName(string lastName)
        {
            Console.WriteLine($"hello {lastName}, what have you been up to?");
        }

        //Tuple =>allows to return two or more parameters
        public static (string firstName, string laSstName) GetFullName()
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            return (firstName, lastName);
        }
        
    }
}

//the syntax can also be like this:
//namespace Methods20;
//internal static class SampleMethod
//{
//    // codes go here...
//}
