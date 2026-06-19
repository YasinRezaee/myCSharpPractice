//----------------ex 1------------------------------------ 
//Console.WriteLine("How Old Are you?");
//string? age = Console.ReadLine();
//int? convertAgeFormat = int.Parse(age);
//Console.WriteLine($"Your age is {age}. you will be {convertAgeFormat + 25} in next" +
//    $" twenty five Years. and you were {convertAgeFormat - 25} twenty five  years ago");
//Console.ReadKey();

//----------------ex 2------------------------------------ 
Console.WriteLine("what is your age?");
string? ageText = Console.ReadLine();
bool isAgeVarified = int.TryParse(ageText, out int age);
 
if (isAgeVarified)
{
    Console.WriteLine($"Your age will be {age + 15} in next 15 years");
}
else
{
    Console.WriteLine("Your age was not in a correct format. press any key and try again.");

}

Console.ReadKey();