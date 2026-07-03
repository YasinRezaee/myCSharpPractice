//-----------------------Lists----------------------------
//is list is kindda like array.a modern way to store data.
// List<T> : here T is type of element or object in the list. T is generic
List<string> firstName = new List<string>();
// now  i can add to this list using Add method:
firstName.Add("Jack"); 
firstName.Add("Tim"); 
firstName.Add("Sue");
//unlike array that we had to clrar how long it should be : string[] firstName = new string[5]; in list we do not have to 
// do this and i can add to it as long as i want.
Console.WriteLine(firstName[0]); //Jack
Console.WriteLine(firstName[2]); //Sue
// if i want to get the length of a list instead of (length) we use count:
Console.WriteLine(firstName.Count); // the length is 3 ; the count is three but the index is still 0, 1 , 2
Console.WriteLine(firstName[firstName.Count - 1]); // the result will be Sue
// i can creat list with other types as well:
List<int> age = new List<int>();
age.Add(1);
age.Add(2);
//-------------------------
//List<T> : Generic means you can pass any type. even type we make.
//---------------------------
string lastName = "Rezaei, Fathi, Moradi, Nazari, Vaisi";
string[] lastNameData = lastName.Split(',');
Console.WriteLine(lastNameData[0]); // the result will be Rezaei
// last time we did this with array if we wanted to create an array out of a string CSV.
// we can not Add to array later and it is one of the diffrences with lists.
//but ulimaitlly we can change this to a list and add or do other things to it:
List<string> lastNameAsList = lastName.Split(",").ToList();
lastNameAsList.Add("Mirzaei");
Console.WriteLine(lastNameAsList[lastNameAsList.Count - 1]); // the result will be Mirzaei
Console.WriteLine(lastNameAsList.Count); // now the length will be 6
//---------------------------practice Home Work-------------------------------
List<string> teachers = new List<string>();
teachers.Add("Mohamadi");
teachers.Add("Nazari");
teachers.Add("Moradi");
Console.WriteLine(teachers[2]); //Moradi
Console.WriteLine($"the length is: {teachers.Count}");// the length is: 3
teachers.Remove("Moradi");
Console.WriteLine(teachers[teachers.Count - 1]); //Nazari -=> Moradi was removed
Console.WriteLine($"the length is: {teachers.Count}");// the length is: 2

Console.ReadKey();