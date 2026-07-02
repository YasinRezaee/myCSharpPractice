
string userName;
bool validKey;

do
{
    Console.WriteLine("What is your name?");
    userName = Console.ReadLine();
     
    if (userName == "tim")
    {
        Console.WriteLine("Hello Professor Tim");
    }else
    {
        Console.WriteLine($" welcome dear {userName}");
    }

}
while (userName != "exit");
return ;
Console.ReadKey();