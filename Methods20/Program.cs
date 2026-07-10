//----------------Methods----------- 
//methods are ways of encapsulating codes or putting code in one spot an then calling that code 
//with just one line.It allow us to reuse our code or call our code more than once and keeps 
//our code cleaner and easier to read. helps us not to repeat ourselfs.
//----------------Creating a Methods----------- 
//SayHello method created now we call it from here to use it:
//to do this you need to call SampleMethod first, in which the SayHello() exists.
// the name space nned to be called as well , here is Methods.
// so basically we can say :Methods.SampleMethod.SayHello() . but we first import it by writting
// "using" key word and then the name of namespace.

using Methods;
using Methods20;
using System.Timers;

SampleMethod.SayHello();
SampleMethod.GoodbyUser("Goodby every one");
//---------we can use it no loops just as en ex:
for (int i = 0; i < 5; i++)
{
    SampleMethod.SayHello();
//consoles Hello User 5 time
}
//---------------------------------------------
// nameing methods are critical, name methods based on what they do. 
//---------------------------------------------
Console.WriteLine("---------------------------------------------");
//----------------------ex notification----------------------
Notification.WarningMessage("Be Carefull");
Notification.ErrorMessage("This is a mistak");

//----------------------ex Passing Parameters to method----------------------
Console.WriteLine("---------------------------------------------");
Console.WriteLine("What is your Name?");
string name = Console.ReadLine();
Console.WriteLine("what time is your meeting?");
string meeting = Console.ReadLine();
SampleMethod.GreatingUser(name, meeting);
//What is your Name?
//yasin
//what time is your meeting ?
//10 : 22
//Hello yasin , you have a meeting at 10:22 clock
//---------------------------------------------------------------------------
MathShortcut.Add(15 , 110); // the sum of 15 + 110 is 125

//---------------------------------------------------------------------------
double[] numbers = {10, 20, 30, 60, 90, 23};
MathShortcut.CalculateMean(numbers); //the mean is 38.833333333333336
//---------------------------------------------------------------------------
// we creat method, we called the method, now we talk about the purpose of method:
//the basic purpose of a method as we seen, is we can put codes in them and np mather
//ow many lines are the, them we can call them all in asingle line of code. 
//But ther is more to it than just lines. 
//so here is a couple of best practices:
// 1***> DRY: which means Don't Repeat Yourself. 
// it means we do not want to have the same logic in more than one spot because then, if we 
//have to fix that logic , it is only in one spot and it be done fore everywhere else.
// but if same logic of code is repeated in many spots, in case of fixing bug or error,
// we might miss one and cause a pretty bad bug!.

// 2***>SOLID: it stands for five different principles:
//this is just the first one(s)
//2-1=> SRP : which stands for Single Responsibility Principles: basicallly means
//somethig should only do one thing

//-----------------returning a value --------------
 string lastName = MathShortcut.Greatings();
SampleMethod.GreetLastName(lastName);//hello rezaeiiii, what have you been up to?
//---------------ex---------------
double addedNums = MathShortcut.AddUp(15, 36.5);
Console.WriteLine($"the sum is {addedNums}"); //the sum is 51.5

//----------------------Tuple------------------
(string, string) fullName = SampleMethod.GetFullName();
//var fullName = SampleMethod.GetFullName();
// i can also use vat instead of (string, string)
Console.WriteLine($"full name is {fullName}");
Console.WriteLine($"first name is {fullName.Item1}");
Console.WriteLine($"last name is {fullName.Item2}");
Console.ReadKey();