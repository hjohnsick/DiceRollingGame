using System;

namespace DiceRolling
{
    class Program
    {


        static void Main(string[] args)
        {
            string userInput;
            int numberOfSides;

            Console.WriteLine("Welcome to the Grand Circus Casino!\nRoll the dice? (y/n)");
            userInput = Console.ReadLine().ToLower();

            if (userInput != "y" && userInput != "n")
            {
                Console.WriteLine("\nPlease enter a valid answer (y/n)!");
                userInput = Console.ReadLine().ToLower();
            }
            while (userInput == "y")
            {
                Console.WriteLine("\nHow many sides should each die have?");
                numberOfSides = int.Parse(Console.ReadLine());

                if (numberOfSides > 1 && numberOfSides <= 6)
                {
                    int userRoll = DiceRollerApp.RandomNumber(numberOfSides);
                    int computerRoll = DiceRollerApp.RandomNumber(numberOfSides);
                    Console.WriteLine("You rolled: " + userRoll);
                    Console.WriteLine("Computer rolled: " + computerRoll);

                    if (userRoll > computerRoll)
                    {
                        Console.WriteLine("You won!");
                    }
                    else if (userRoll < computerRoll)
                    {
                        Console.WriteLine("You lost!  Computer won!");
                    }
                    else
                    {
                        Console.WriteLine("Tie.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPlease enter a valid number between 1 and 6!");
                }

                Console.WriteLine("\nDo you want to roll again?");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "n")
                {
                    Console.WriteLine("\nThank you for playing!");
                }
            }


            Console.ReadKey();
        }



    }
}
