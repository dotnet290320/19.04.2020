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

        static void Main(string[] args)
        {
            string[] words = new string[5];
            words[0] = "Hello!";
            words[1] = "World";
            words[2] = "I";
            words[3] = "Love";
            words[4] = "C#";
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            bool flag = true;
            bool[] flags = new bool[5];
            flags[0] = true;
            flags[1] = false;
            flags[2] = 0 == 1;
            flags[3] = 1 == 1;
            flags[4] = words.Length > 3;

            // how to make a random numebers in 10 cells array without repitation ?

            // int[10]  -- 1..10 in random
            // bool[10] -- true/ false per number

            int[] numbers = new int[10];
            bool[] number_already_used = new bool[10];

            Random random_generator = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                int random_number = 0;
                do
                {
                    random_number = random_generator.Next(1, 11);
                }
                while (number_already_used[random_number - 1] == true);

                number_already_used[random_number - 1] = true;
                numbers[i] = random_number;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

    }
}
