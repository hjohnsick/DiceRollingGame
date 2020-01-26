using System;

namespace DiceRolling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Circus Casino! Roll the dice? (y/n) ");
            string userInput = Console.ReadLine();

            while (userInput == "y")
            {
                if (userInput == "y")
                {
                    Console.WriteLine("How many sides should each die have?");
                    int numberOfSides = int.Parse(Console.ReadLine());


                    Random rnd = new Random();

                    int dice1 = rnd.Next(1, numberOfSides);
                    int dice2 = rnd.Next(1, 7);

                    Console.WriteLine($"Dice 1: {dice1}");
                    Console.WriteLine($"Dice 2: {dice2}");

                    if (dice1 > dice2)
                    {
                        Console.WriteLine("Dice 1 wins!");
                    }
                    else if (dice1 < dice2)
                    {
                        Console.WriteLine("Dice 2 wins!");
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                    }
                }
                else if (userInput == "n")
                {
                    Console.WriteLine("Come back soon!");
                }
                else
                {
                    Console.WriteLine("Please enter a valid input. (y/n)");
                }
                string playAgain = "";
                Console.WriteLine("Do you want to play again? (y/n)");
                playAgain = Console.ReadLine();
                if (playAgain == "n")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }

            }
        }
        
    }
}
