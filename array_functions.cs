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

        static int[] InputNumbersFromUserIntoArray(int array_size)
        {
            int[] result = new int[array_size];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = InputNumberFromUserInRange("enter number between 1-100", 1, 100);
            }

            return result;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void IncArrayBy1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]++; // this change will be made on the calling array
            }
        }

        static void Main(string[] args)
        {
            int[] random_numbers_player1 = InputNumbersFromUserIntoArray(100);


            int[] random_numbers_player2 = InputNumbersFromUserIntoArray(20);

            // the same as:
            // int number = InputNumberFromUserInRange("enter number between 1-100", 1, 100);

            PrintArray(random_numbers_player1);

            PrintArray(random_numbers_player2);

            IncArrayBy1(random_numbers_player1);

            IncArrayBy1(random_numbers_player2);

        }

        
    }
}
