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

        static void Targil4()
        {
            // declerations
            int number_of_classes;
            int[][] stundents_grades;

            number_of_classes = InputNumberFromUserInRange("Enter numbers of classes: ", 1, 10);

            stundents_grades = new int[number_of_classes][];
            // jagged
            // [3][]
            //
            // [1,2,3] length = 3
            // [1] length = 1
            // [1,2,3,4,5,6,7,8,9,10] length = 10
            //
            // grades[0][1]

            // input how many students in each class
            for (int i = 0; i < number_of_classes; i++)
            {
                int number_of_students_inc_class = InputNumberFromUserInRange($"Enter numbers of students for class {i+1} : ", 2, 40);
                stundents_grades[i] = new int[number_of_students_inc_class];
            }

            // enter grades
            for (int i = 0; i < number_of_classes; i++)
            {
                for (int j = 0; j < stundents_grades[i].Length; j++)
                {
                    int grade = InputNumberFromUserInRange($"Enter grade of students {j+1} in class {i + 1} : ", 1, 100);
                    stundents_grades[i][j] = grade;
                }
            }

            // calc average
            for (int i = 0; i < number_of_classes; i++)
            {
                int sum = 0;
                for (int j = 0; j < stundents_grades[i].Length; j++)
                {
                    sum = sum + stundents_grades[i][j];
                }
                Console.WriteLine($"average for class {i+1} is {(sum / Convert.ToDouble(stundents_grades[i].Length))}");
            }

            Console.WriteLine();


        }
        static void Main(string[] args)
        {
            Targil4();
        }

    }
}
