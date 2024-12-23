using System.Threading.Channels;
using System.Xml.Serialization;

namespace NumberGuessingGameCLI
{
    internal class Program
    {
        private GameSetup gameSetup;

        static void Main(string[] args)
        {
            var gameSetup = GetInitialSetup();
            ShowSelectedDificultyLevel(gameSetup.DificultyLevelText);

            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int attempts = 1;

            while (true)
            {
                int currentGuess = GetGuess();
                if (currentGuess == numberToGuess)
                {
                    ConsoleMessages.PrintWin($"Congratulations! You guessed the correct number in {attempts} attempt(s).");
                    break;
                }
                else if (currentGuess > numberToGuess)
                {
                    ConsoleMessages.PrintError($"Incorrect! The number is less than {currentGuess}.");
                }
                else if (currentGuess < numberToGuess)
                {
                    ConsoleMessages.PrintError($"Incorrect! The number is greater than {currentGuess}.");
                }

                if(attempts == gameSetup.MaxAttempts)
                {
                    ConsoleMessages.PrintError($"You loss! you failed {attempts} times out of {gameSetup.MaxAttempts} you had, the number was {numberToGuess}");
                    break;
                }

                attempts++;
            }
        }

        private static void ShowSelectedDificultyLevel(string difficultyLevel)
        {
            ConsoleMessages.PrintInfo($"\nGreat! You have selected the {difficultyLevel} difficulty level.\nLet's start the game!");
        }

        private static GameSetup GetInitialSetup()
        {
            ConsoleMessages.PrintInfo("Welcome to the Number Guessing Game!\nI'm thinking of a number between 1 and 100.\n");
            ConsoleMessages.PrintInfo("\nPlease select the difficulty level:\n1. Easy (10 chances)\n2. Medium (5 chances)\n3. Hard (3 chances)\n\nEnter your choice:");
            int.TryParse(Console.ReadLine(), out int choice);

            GameSetup gameSetup = new GameSetup(choice);
            ConsoleMessages.PrintInfo($"\nOk, You have {gameSetup.MaxAttempts} chances to guess the correct number.");
            return gameSetup;
        }

        private static int GetGuess()
        {
            ConsoleMessages.PrintInfo("\nEnter your guess:");
            int.TryParse(Console.ReadLine(), out int guess);
            return guess;
        }
    }

    public class GameSetup
    {
        public int DificultyLevelNumber { get; set; }
        public string DificultyLevelText { get; set; }
        public int MaxAttempts { get; set; }

        public GameSetup(int choice)
        {
            DificultyLevelNumber = choice;
            DificultyLevelText = choice switch
            {
                1 => "Easy",
                2 => "Medium",
                3 => "Hard"
            };
            MaxAttempts = choice switch
            {
                1 => 10,
                2 => 5,
                3 => 3
            };
        }
    }
}
