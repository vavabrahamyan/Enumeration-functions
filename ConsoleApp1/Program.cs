using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas set number");
            int num = Int32.Parse(Console.ReadLine());
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------Enumeration functions------- ");
            Console.WriteLine("Foo_0");
            Foo_0(num);
            Thread.Sleep(1000);
            Console.WriteLine("Foo_1");
            Foo_1(num);
            Thread.Sleep(1000);

            Console.WriteLine("recursive functions");
            Console.WriteLine("Foo_2");
            Foo_2(num);

            Console.WriteLine("Foo_3");
            Foo_3(num);


            Console.ReadKey();
        }

        static void Foo_0(int num)
        {
            Console.WriteLine("numbers in reverse order");
            for (int i = num; i > 0; i--)
            {
                Thread.Sleep(200);
                Console.WriteLine($"Your number is:{i}");
            }
        }
        static void Foo_1(int num)
        {
            Console.WriteLine("numbers in the correct sequence");
            for (int i = 1; i <= num; i++)
            {
                Thread.Sleep(200);
                Console.WriteLine($"Your number is:{i}");
            }
        }
        static int Foo_2(int num)
        {
            Thread.Sleep(200);
            Console.WriteLine($"Your num is: {num}");
            if (num == 1)
            {
                
                return num;
                
            }
            return Foo_2(num-1);
        }
        static void Foo_3(int num)
        {


            if (num == 1)
            {
                Console.WriteLine($"Your num is: {num}");
                return;

            }
            Foo_3(num - 1);
            Thread.Sleep(200);
            Console.WriteLine($"Your num is: {num}");
        }
    }
}
