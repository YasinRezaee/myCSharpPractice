using System.Text.Json.Nodes;
Console.WriteLine("STRING VARIABLE");

string firstName = string.Empty; //this is just a sarting value. it means there is no value at the moment
string lastName = ""; // a value is set but is just an emty strinng.
firstName = "Tim";
lastName = "Coray";
string path = string.Empty;
path = @"C:\\Temp\Demo";// if @ is not use,C# sees \ as special caracters and does not build
//path = "C:\Temp\Demo"; //unrecognized special characters(\)
//we can mix both $ ans @- the oreder does not matter.
string testString = $@"the file for {firstName} is stored in  C:\\file";
//string testStrings = JSON.stringify();
// with only $ the result log will be : the file for Tim is stored in  C:\fileD
// with only $@ the result log will be : the file for Tim is stored in  C:\\fileD
Console.WriteLine(testString);

Console.WriteLine(firstName + " " + lastName); // " " is called string leteral
Console.WriteLine($"Hey there  {firstName} {lastName}");// this is called string interpolation
Console.WriteLine("STRING VARIABLE");

//???????////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("INT VARIABLE");

//Yes : 2, 18 , 1654, -9
//No: -1.2, -5.6
int age = 0;
age = 45;
int ageInTenYears = age + 10; 

//two billion +/-
//signed Int32
//unsigned - 4 billion
//bit - 0 or
//byte - 8 bite - 00000000
// 1, 11 , 111
Console.WriteLine(ageInTenYears);
Console.WriteLine(age);

Console.WriteLine("age is" + " "  + age / 2); //Dont divide ints

Console.ReadKey(); 