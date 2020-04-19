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

        
        static int Multiply(int x = 1, int y = 1)
        {
            return x * y;
        }


        // overloading - same function with different parameters
        /*
        static int Multiply(int x)
        {
            // 1
            int result = Multiply(x, 1);

            // 2
            // int result = x * 1;
            return result;
        }
        */

        // aligh right
        static void Bar(int x , int y , int z = 3, int w = 4) // from default value MUST be deault till last parameter
        {
            Console.WriteLine($"x : {x}");
            Console.WriteLine($"y : {y}");
            Console.WriteLine($"z : {z}");
            Console.WriteLine($"w : {w}");

        }

        // aligh right
        static void Foo(int x = 1, int y = 2, int z = 3, int w = 4)
        {
            Console.WriteLine($"x : {x}");
            Console.WriteLine($"y : {y}");
            Console.WriteLine($"z : {z}");
            Console.WriteLine($"w : {w}");

        }

        // ref super powers:
        // changes you make in this functions will affect the variable outside the function
        static void Add1(ref int number)
        {
            number++;
        }

        // out super powers:
        // 1. can get uninitialized parameters
        // 2. like ref -- changes you make in this functions will affect the variable outside the function 
        // 3. obligation - give the out arameters value
        static void GetNumber(out int number1, out int number2)
        {
            number1 = InputNumberFromUserInRange("Enter value for number1 ", 1, 100);
            number2 = 2;
        }

        static void P1(int[] numbers )
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        // params super powers:
        // user may send array and may not -- in this case an empty array will be set as default
        // user may send numbers seperated by comma ,
        static void P2(params int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(10));

            Console.WriteLine(Multiply());

            Console.WriteLine(Multiply(12, 5));

            Console.WriteLine(Multiply(y: 5, x: 12));

            // how to solve this?
            // 1 overloading
            // 2 default value
            //Console.WriteLine(Multiply(10));

            //Console.WriteLine(Multiply());
            Foo(1, 2, 3, 4);
            Foo(z:4);

            Console.WriteLine("=================");
            int x = 14;
            Add1(ref x);
            Console.WriteLine(x);

            Console.WriteLine("=================");
            int y, z;
            GetNumber(out y, out z);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine("=================");
            int[] arr =  { 1, 5, -10, 30 };
            P1(arr);
  
            P2();

            P2(1, 4, -100); // P2 (int[] { 1, 4, -100 });
        }

    }
}
