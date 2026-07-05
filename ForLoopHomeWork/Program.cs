Console.WriteLine("Please Add Your students lastName List, separate each name by a comma only:");
string firstNames=Console.ReadLine();
List<string> firstNamesList= firstNames.Split(',').ToList();
for (int i = 0; i < firstNamesList.Count; i++)
{
    Console.WriteLine($"Hello {firstNamesList[i]}");
}

Console.ReadKey();
 