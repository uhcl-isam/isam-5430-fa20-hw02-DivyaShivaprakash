using System;

namespace CreditLimitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int end = 0;
            int newbal = 0;
            Console.Write("Please enter your account #:");
            int acctnum = int.Parse(Console.ReadLine());

            Console.Write("Total Items Charged on credit card from begining of the month:");
            int initbal = int.Parse(Console.ReadLine());

            Console.Write("Total Items Charged on credit card this month:");
            int purchs = int.Parse(Console.ReadLine());

            Console.Write("Total of all credits this month:");
            int credits = int.Parse(Console.ReadLine());

            Console.Write("Allowed credit limit:");
            int _limit = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Thank You......\n");

            newbal = initbal + purchs - credits;


            if (_newbal > _limit)
            {
                Console.WriteLine($"CREDIT LIMIT EXCEEDED!!!!");
            }

            Console.WriteLine($"\n Your new balance is {newbal}.");

            Console.Write("\n If you are finished enter;2.\n To input another enter; -1:");
            end = int.Parse(Console.ReadLine());

            while(end < 1)
                {
                counter++;//

                Console.Write("Please enter your account #:");
                int _acctnum = int.Parse(Console.ReadLine());

                Console.Write("Total Items Charged on credit card from begining of the month:");
                int _initbal = int.Parse(Console.ReadLine());

                Console.Write("Total Items Charged on credit card this month:");
                int _purchs = int.Parse(Console.ReadLine());

                Console.Write("Total of all credits this month:");
                int _credits = int.Parse(Console.ReadLine());

                Console.Write("Allowed credit limit:");
                int _limit = int.Parse(Console.ReadLine());

                Console.WriteLine("\n Thank You......\n");
                int _newbal = _initbal + _purchs - _credits;

                if (newbal > _limit)
                {
                    Console.WriteLine($"CREDIT LIMIT EXCEEDED!!!!");
                }

                Console.WriteLine($"\nYour new balance is {newbal}.");

                Console.Write("\nIF you are finished with your entries enter ; 2.\n To input another account:");
                end = int.Parse(Console.ReadLine());

            }
            while (end ==2)
            { end++; }

        }
    }
}
