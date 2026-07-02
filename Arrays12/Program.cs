//-----------------------Arrays----------------------------
//array is a variable type. that hold a bunch of something
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

string[] firstName = new string[5];
//this means that i have an array of stings thatcan hold 5 different names.
firstName[0] = "Tim";
//now in index 0 i have a name that is "Tim";
//base counting is 0,2,3,4,5
firstName[1] = "Bob";
 firstName[2] = "Nick";
 firstName[4] = "Milly";
//now if i log the result will be:the first name is Tim, Bob , Nick, , Milly
Console.WriteLine($"the first name is {firstName[0]}, {firstName[1]} , {firstName[2]}, {firstName[3]}, {firstName[4]}");
//since i do not have any name for index 3, it will remain un assined.
// i can laer assign different values :
firstName[0] = "Yasin";
Console.WriteLine($"the first name is {firstName[0]}, {firstName[1]} , {firstName[2]}, {firstName[3]}, {firstName[4]}");
//the result will be that you see Tim has changed to yasin : 
//the first name is Tim, Bob , Nick, , Milly
//the first name is Yasin, Bob, Nick, , Milly
//if i add a name other than this indexes say index 5, i will get IndexOutOfRangeException.
//-----------------------------------------------------------------------
// so how would we expand our array then??
//there are things build in NSC sharp that help to do this. but once we decide to add a new
//element to an array that is set to fix(here 5), what happens is we create a brand new array.
// and we copy all of our value into that array and add that one extra value and this is avery expensive proces 
//and not somthing we really want to do.
// let think we have some data, 
string data = "Bob, Sue, Ali, Nazan, Tabita";
// we might get this from a line in a *CSV* file.
// CSV file is a comma seperated file that is a simple way to share data between applicatios that do not talk to each other.
// and what we do is to put values in a text file and you separate them by commas.
// so how this work in C# :???
string[] readData = data.Split(',');
// as you can see we used single quote not dubble.
//the difference here is : single quote is identifies as char and that means a single character. in this case single character is camma.
//but doubble quotes adentifies a string value.
// so here we want to split based on commas.
Console.WriteLine(readData[1]); // the result will be Sue
Console.WriteLine(readData[3]); // the result will be Nazan
Console.WriteLine(readData[4]); // the result will be Tabita
//this how we can pull out a comma separated string and set it as an array.
//------------------------------------------------------------------------------
//by using loops we can go through arrays and read their value. 
Console.WriteLine(readData.Length); //the lenght is 5
Console.WriteLine(readData[readData.Length - 1]); //Tabita
// there is another way to declear wlwments in an array. in cases where you already know what element you want.
string[] lastName = new string[] { "corray", "Miky", "Penny" };
Console.WriteLine(lastName[0]); // corray

// well we can create array almost from everything. here type matters
int[] ages = new int[] { 25, 28, 32 };
long[] accNumbers = new long[] { 646464, 6464464, 6461321 };
//--------------------------------------------------------------------------

Console.ReadKey();
