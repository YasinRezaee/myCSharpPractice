 // dictionary is another useful type of set or grouping of elements.
 //Dictionary<Tkey, Tvalue> 
 //in this type you look up Tkey and you get Tvalue, just like a dictionary
 Dictionary<string, string> animals = new Dictionary<string, string>();
animals.Add("cat", "a pet that is so cute");
animals.Add("fish", " a creature that lives in water");
animals.Add("camle", "an animal that lives in disert");

Console.WriteLine(animals["cat"]); // a pet that is so cute
Console.WriteLine(animals["fish"]); //a creature that lives in water
Console.WriteLine(animals["camle"]); // an animal that lives in disert
//---------------------------------
Dictionary<int, string> employees= new Dictionary<int, string>();
employees[95] = "mohsen";
employees[96] = "aso";
employees[97] = "ali";

Console.WriteLine($"the employee with id 96 is {employees[96]}"); //the employee with id 96 is aso
// the key must be unique, you can not have similar key in dictionary
//

Console.ReadKey(); 