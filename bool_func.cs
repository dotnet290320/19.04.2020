using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1904tar3
{
    class Program
    {
        static int InputNumberFromUserInRange(string message, int min, int max)
        {
            int number = 0;
            do
            {
                Console.WriteLine(message);
            }
            while (int.TryParse(Console.ReadLine(), out number) == false || number < min || number > max);

            return number;
        }

        // boolean = true or false
        static bool CheckPrime(int number)
        {
            int m1 = 2;
            while (number % m1 != 0 && m1 < number)
            {
                m1++;
            }
            if (number == m1)
            {
                return true; // prime
            }

            return false; // not prime
        }

        static void Main(string[] args)
        {
            int number = InputNumberFromUserInRange("Please enter a number: ", 1, 100);

            //bool checkPrimeResult; // true or false
            //checkPrimeResult = CheckPrime(number);

            // longer
            //if (checkPrimeResult == true)
            //{
            //    Console.WriteLine("prime");
            //}
            //else
            //{
            //    Console.WriteLine("not prime");
            //}

            if (CheckPrime(number)) // the same: CheckPrime(number) == true
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("not prime");
            }

            bool isBiggerThan10 = number > 10;
            if (isBiggerThan10) // the same: isBiggerThan10 == true
            {
                // ....
                Console.WriteLine($"{number} is bigger than 10");
            }

            if (!isBiggerThan10) // the same: isBiggerThan10 == false
            {
                // ....
                Console.WriteLine($"{number} is NOT bigger than 10");
            }
        }

        
    }
}
