using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        private static int[] nums = new int[1000];
        static void Main(string[] args)
        {
            //Console.WriteLine("pleas set number");
            //int num = Int32.Parse(Console.ReadLine());

            


            //Thread.Sleep(1000);
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("------Enumeration functions------- ");
            //Console.WriteLine("Foo_0");
            //Foo_0(num);
            //Thread.Sleep(1000);
            //Console.WriteLine("Foo_1");
            //Foo_1(num);
            //Thread.Sleep(1000);

            //Console.WriteLine("recursive functions");
            //Console.WriteLine("Foo_2");
            //Foo_2(num);

            //Console.WriteLine("Foo_3");
            //Foo_3(num);

            //Console.WriteLine(   $"Your {num}th is :{Fib(num)}");
            //Console.WriteLine();


            Console.ReadKey();
        }

        static int Fib(int num)
        {
            if(num < 0)

            {
                Console.WriteLine("Num is out of range :_('_')_:");
                return 0;
            }
            else if(num == 0)
            {
                return 1;
            }
            else if(num == 1)
            {
                return 1;
            }
            else
            {
                if (nums[num] != 0)
                {
                    return (nums[num]);
                }
                else
                {
                    nums[num] = (Fib(num - 2) + Fib(num - 1));
                    return nums[num];
                }
            }
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
