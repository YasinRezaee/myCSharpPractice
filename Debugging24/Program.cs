//namespace ConsoleUI
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < 20; i++)
//            {
//                Console.WriteLine($"the value of I is : {i}");
//                for (int j = 0; j < 10; j++)
//                {
//                    Console.WriteLine($"the value of J is {j}");
//                }
//            }
//            Console.ReadLine();
//        }
//    }
//}
//\\\\\\\\\\\\\\\\\\\\exception\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
//namespace ConsoleUI
//{
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                BadCall();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//                throw;
//            }
//            Console.ReadLine();
//        }

//        private static void BadCall()
//        {
//            int[] ages = new int[] { 2, 3, 5 };

//            for (int i = 0; i <= ages.Length; i++)
//            {
//                try
//                {
//                    Console.WriteLine(ages[i]);
//                }
//                catch (Exception EX)

//                {
//                    //Console.WriteLine(EX.Message);
//                    //throw;
//                    //throw says we caught this exception , now throw it again
//                    throw new Exception("error happened");
//                    throw new Exception(EX.Message);
//                }
//            }
//        }
//    }
//}
//\\\\\\\\\\\\\\\\\\\\Advanced exception\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
//using System.Threading.Channels;

//namespace ConsoleUI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            AdifferentMethod();

//            try
//            {
//                SimpleMethod();
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            Console.ReadLine();
//        }

//        private static void AdifferentMethod()
//        {
//            throw new NotImplementedException();
//        }

//        private static void SimpleMethod()
//        {
//            throw new InvalidOperationException("error happened");
//        }
//    }
//}
//\\\\\\\\\\\\\\\\\\\\Advanced BreakPoint\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
using System.Threading.Channels;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = W(0);
            Console.WriteLine(i);
            Console.ReadLine();
        }

        private static int W(int e)
        {
            int n = 1;
            n = J(e) + 4;
            return n;
        }
        private static int P(int v)
        {
            int o = 0;
            o = F(v) + 2;
            return o;
        }
        private static int F(int x)
        {
            int y = 0;
            y = x / 5;
            return y;
        }
        private static int J(int a)
        {
            int c = 0;
            a = a - 1;
            c = R(a);
            c = P(c) / 3;
            return c;
        }
        private static int R(int v)
        {
            int z = 5;
            z = 3 / v;
            return v;
        }
    }
}