string[] firstNames = new string[] { "Ali", "Mohsen", "Aso" };
string number;
bool validNumber;
int writtenNumber;


do
{
	Console.WriteLine("Type a number between 0 and 2");
	number = Console.ReadLine();
	validNumber = int.TryParse(number, out writtenNumber);
    if (!validNumber || writtenNumber > 2)
    {
        Console.WriteLine("Not Valid Number, Try Again");
    }
} while (!validNumber|| writtenNumber > 2);
switch(writtenNumber)
{
    case 0:
        Console.WriteLine($"You select {firstNames[0]}"); 
        break;
        case 1:
        Console.WriteLine($"You select {firstNames[1]}");
        break;
        case 2:
        Console.WriteLine($"You select {firstNames[2]}");
        break;
}


Console.ReadKey();

