
//------------------------Basic if statements -----------------------------
//bool isComplete = false;

//if (!isComplete)
//{
//    Console.WriteLine("isComplete is true");
//}
//else
//{
//    Console.WriteLine("isComplete is true");
//}
//Console.WriteLine("End of Program");
//---------------------------------------------------------
//Console.WriteLine("What is your name?");
//string? firstName = Console.ReadLine();
//if (firstName.ToLower() == "yasin")
//{
//    Console.WriteLine("Hello Mr.Rezaei");
//}
//else
//{
//    Console.WriteLine($"Hello {firstName}");
//}
//------------------Advanced If Statements ---------------
//string? firstName = "Aso";
//int password = 23651;


//switch (password)
//{
//    case 12345:
//        Console.WriteLine("you are Arshad");
//        break; 
//    case 2365:
//        Console.WriteLine("You are Arshad's uncle");
//        break;
//    default: Console.WriteLine("i do not know you");
//        break;

//}
//.....................................................................
//int age = 25;
//switch (age)
//{
//    case >= 25 and < 26:
//        Console.WriteLine("aaaaaaaa");
//        break;
//    case < 25 and >12:
//        Console.WriteLine("bbbbbbbbb");
//        break;
//}
//................................HomeWork.....................................

Console.WriteLine("What is your Name?");

string userName = Console.ReadLine();
//if (userName.ToLower() == "tim" || userName.ToLower() == "timoty")
//{
//    Console.WriteLine("Hello professor");
//}
//else
//{
//    Console.WriteLine($"hello {userName}, you are a student");
//}
switch (userName.ToLower())

{
    case "tim" or "timoty":
        Console.WriteLine("hello professor");
        break;
    default: Console.WriteLine("you are a regular student");
        break;
}

Console.ReadKey();