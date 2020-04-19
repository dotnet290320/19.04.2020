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

        static void Targi3()
        {
            //כתוב תוכנית המדמה משחק צוללות.כלומר תייצר מטריצה בגודל 3 ,3 ושים בתוכה מספרים
            //אקראים של 0 או 1.
            //קלוט מהמשתמש מספר שורה ומספר עמודה. אם במטריצה בשורה ועמודה שהמשתמש כתב יש
            //את הערך 1 הדפס “Boom( “פגיעה(אחרת הדפס “Miss( “החטאה(
            //אם המשתמש פגע בצוללת הפוך את ערך התא מ 1 ל 0
            //המספר יגמר כאשר לא יהיו יותר צוללות)כלומר כל הערכים במטריצה יהיו 0)
            //כאשר המשחק נגמר הדפס כמה נסיונות היו

            // declerations (config)
            int rows = 3;
            int columns = 3;
            int guesses = 0;
            int submarines = 0;

            // ---- coding
            // create the matrix
            int[,] matrix = new int[rows, columns];
            Random random_generator = new Random();

            // i 1 -> 3
            // X X X  ; j 1->3
            // X X X
            // X X X 


            // put submarines in the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int random_number = random_generator.Next(0, 2); // 0-1
                    matrix[i, j] = random_number;

                    submarines = submarines + random_number;
                }
            }

            // ------------------------- main game loop
            do
            {
                guesses++;
                Console.WriteLine($"Guess number {guesses}");

                // user guess location: row + column
                int user_guess_row_not_zero_based = InputNumberFromUserInRange("Please guess a number (1-3):", 1, 3);
                int user_guess_col_not_zero_based = InputNumberFromUserInRange("Please guess a number (1-3):", 1, 3);

                if (matrix[user_guess_row_not_zero_based - 1, user_guess_col_not_zero_based - 1] == 1)
                {
                    // hit
                    Console.WriteLine("******** Boom you hit!!!");
                    matrix[user_guess_row_not_zero_based - 1, user_guess_col_not_zero_based - 1] = 0;
                    submarines--;
                }
                else
                {
                    // miss
                    Console.WriteLine(".... You missed ....");
                }
            }
            while (submarines > 0);

            Console.WriteLine($"well done! it tooked you {guesses} guesses!");

        }
        static void Main(string[] args)
        {
            Targi3();
        }

    }
}
