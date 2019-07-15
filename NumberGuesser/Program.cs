using System;

namespace NumberGuesser
{
    class Program
    {
        // Entry Point Method
        public static void Main(string[] args)
        {
            // Show App Info
            GetAppInfo();

            GreetUser();

            while (true)
            {
                // Create a New Random Object
                Random random = new Random();

                // Set Correct Number
                int correctNumber = random.Next(1, 10);

                // Init Guess Var
                int guess = 0;

                // Ask User For Number
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //Get Users Input
                    string input = Console.ReadLine();

                    // Make Sure It's a Number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep the Game Going
                        continue;
                    }

                    // Parse to Int and Put in Guess
                    guess = Int32.Parse(input);

                    // Match Guess to Correct Number
                    if (guess != correctNumber)
                    {

                        //Print Error Message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, guess again");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "Your a Winner!!");

                // Ask to Play Again
                Console.WriteLine("Play again [Y or N]");

                // Get Answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }

        }

        // Show App Info
        static void GetAppInfo()
        {
            // Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Alex Wissing";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write Out App Info
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // Reset Text Color
            Console.ResetColor();
        }

        // Ask Users Name and Greet
        static void GreetUser()
        {
            // Ask Users Name
            Console.WriteLine("What is your name?");

            // Get User Input
            string inputName = Console.ReadLine();

            // Intro to Game With User Name
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print Color Message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change Text Color
            Console.ForegroundColor = color;

            // Tell User It's The Wrong Number
            Console.WriteLine(message);

            // Reset Text Color
            Console.ResetColor();
        }

    }
}
