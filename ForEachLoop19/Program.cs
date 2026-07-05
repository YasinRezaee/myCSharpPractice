//string data = "tim, sue, bob, jane";
//List<string> dataList = data.Split(',').ToList();
//forEach creates a variable for evry element in our list of data.
//if you just use ide snippet it starts with a var, which basically says i do not care about your type here.
//foreach (var item in dataList)
//{

//}
//here i just changed var to my data type which is string.
//foreach (string item in dataList)
//{
//    Console.WriteLine(item);
//}

//forEach is more simple to work with when we do not care about any specific element in our list
//but once specific elememts re important sor loop is better.
//-------------------------------------home work baby------------------------------------
List<string> firstNames = new List<string>();
string name = "";
bool isExit = false
    ;

do
{
    Console.WriteLine("Add a first Name:");
    name = Console.ReadLine();
    if (name == "exit".ToLower())
    {
        isExit = true;
    }
    if (name == "" || name == " ")
    {
        Console.WriteLine("Nat a Valid First Name, Try Again!");
        continue;
    }
    else
    {
        firstNames.Add(name);
    }
}
while (isExit != true);
firstNames.RemoveAt(firstNames.Count - 1);
foreach (var firstName in firstNames)
{
    Console.WriteLine($"Hello {firstName}");
} 
 



Console.ReadKey();