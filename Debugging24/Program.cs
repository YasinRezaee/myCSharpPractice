namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"the value of I is : {i}");
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"the value of J is {j}");
                }
            }
            Console.ReadLine();
        }
    }
}