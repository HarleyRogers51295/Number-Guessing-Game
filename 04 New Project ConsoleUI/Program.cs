using System;

namespace _04_New_Project_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randoNume = new Random();

            int winNum = randoNume.Next(0, 100);

            bool win = false;
            


            do
            {
                Console.Write("Make your guess!");
                int guess = int.Parse(Console.ReadLine());

                if(guess > winNum)
                {
                    Console.WriteLine("You guessed too high! Try again!");
                }
                else if(guess < winNum)
                {
                    Console.WriteLine("You guessed too low! Try again!");
                }
                else if(guess == winNum)
                {
                    Console.WriteLine("YOU WIN!!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("Thank you for playing our game!");
            Console.WriteLine("Press any key to exit");
        }
    }
}
