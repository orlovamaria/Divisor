using System;

namespace Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number <= 0)
            {
                Console.Write("Please, enter a natural number: ");

                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("This isn't a number. Please try again: ");
                    continue;
                }

                if(number <= 0)
                {
                    Console.WriteLine("This isn't a natural number. Please try again: ");
                }
            }

            for (int a = 2; a <= number; a++)
            {
                if (number % a == 0)
                {
                    Console.WriteLine($"The smallest divisor of this number is {a}");
                    break;
                }
            }

        }
    }
}
