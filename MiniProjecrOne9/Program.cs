Console.WriteLine("what is your name?");
string? firstName  = Console.ReadLine();
Console.WriteLine("How Old Are You?");
string age = Console.ReadLine();
int modefiedAge = int.Parse(age);


//if ((firstName.ToLower() == "bob" || firstName.ToLower() == "sue") && modefiedAge > 21)
//{
//    Console.WriteLine($"Hello Professor {firstName}, you are aged enough , welcome to the class");
//}else if ((firstName.ToLower() == "bob" || firstName.ToLower() == "sue") && modefiedAge < 21)
//{
//    int requiredAge = 21 - int.Parse(age);
//    Console.WriteLine($"Hello professor {firstName}, you should enter this class in next {requiredAge} years.");
//}
//if ((firstName.ToLower() != "bob" || firstName.ToLower() != "sue") && modefiedAge > 21)
//{
//    Console.WriteLine($"Hello {firstName}, you are aged enough , welcome to the class");
//}
//else if ((firstName.ToLower() != "bob" || firstName.ToLower() != "sue") && modefiedAge < 21)
//{
//    int requiredAge = 21 - int.Parse(age);
//    Console.WriteLine($"Hello {firstName}, you should enter this class in next {requiredAge} years.");
//}

string nameLower = (firstName ?? "").ToLower();
int modifiedAge = int.Parse(age);

switch (nameLower, modifiedAge >= 21)
{
    case ("bob" or "sue", true):
        Console.WriteLine($"Hello Professor {firstName}, you are aged enough, welcome to the class");
        break;

    case ("bob" or "sue", false):
        int requiredAgeProf = 21 - modifiedAge;
        Console.WriteLine($"Hello professor {firstName}, you should enter this class in next {requiredAgeProf} years.");
        break;

    case (_, true):
        Console.WriteLine($"Hello {firstName}, you are aged enough, welcome to the class");
        break;

    case (_, false):
        int requiredAge = 21 - modifiedAge;
        Console.WriteLine($"Hello {firstName}, you should enter this class in next {requiredAge} years.");
        break;
}
Console.ReadKey(); 
 