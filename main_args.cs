using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1904tar3
{
    class Program
    {

        static void Main(string[] args)
        {
            //for (int i = 0; i < args.Length; i++)
            //{
            //    Console.WriteLine(args[i]);
            //}
            //Console.WriteLine();

            // string[] args
            // [0] "5"
            // [1] "+"
            // [2] "10"

            Console.ReadLine();

            if (args.Length != 3)
            {
                Console.WriteLine("must enter 3 parameters i.e. 3 + 5");
                return;
            }

            int x = Convert.ToInt32(args[0]);
            string siman = args[1]; 
            int y = Convert.ToInt32(args[2]);
            switch (siman)
            {
                case "+": Console.WriteLine($"{x} + {y} = {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"{x} - {y} = {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"{x} * {y} = {x * y}");
                    break;
                case "/":
                    Console.WriteLine($"{x} / {y} = {x / Convert.ToDouble(y)}");
                    break;
            }

        }

    }
}
