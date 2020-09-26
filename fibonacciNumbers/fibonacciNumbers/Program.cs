using System;

namespace fibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
                       Console.WriteLine("Enter the last number of Fibonacci Sequence of numbers.");
                int end = int.Parse(Console.ReadLine());


                int input, first = 0, second = 1, third = 0;
                Console.Write("Enter a number : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("First {0} Fibonacci numbers {1} {2} ", input, first, second);

                for (int i = 3; i <= input; i++)
                {
                    third = first + second;
                    Console.Write("{0} ", third);
                    first = second;
                    second = third;
                }


            }

        }
    }
}
    }
}
