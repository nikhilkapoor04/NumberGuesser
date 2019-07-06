using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Namespace
namespace NumberGeusser
{
    //Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser();  // Ask for Username and greet 

            while (true)
            {
                //Create a random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                // Ask user for number 
                Console.WriteLine("Guess a number between 1 to 10");

                while (guess != correctNumber)
                {
                    // Get user input 
                    string input = Console.ReadLine();

                    // Make sure it's a number 
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                        //keep going 
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {

                        // Set error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }
                // Output success message
                // Change text color
                PrintColorMessage(ConsoleColor.Green, "You are correct");

                // Ask to play again
                Console.WriteLine("Play Again? [ Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

                // Get and display app info
                static void GetAppInfo() {

                    // Set app vars
                    string appName = "Number Guesser";
                    string appVersion = "1.0.0";
                    string appAuthor = "Nikhil Kapoor";

                    // Change text color
                    Console.ForegroundColor = ConsoleColor.Green;


                    // Write out application info
                    Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

                    // Reset text color
                    Console.ResetColor();
                }

        // Ask users name and greet 
        static void GreetUser() {
            // Ask user name
            Console.WriteLine("What is your name?");

            // Get user Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game....", inputName);
        }

        // To print color message
        static void PrintColorMessage(ConsoleColor color, string message) {

            // Change text color
            Console.ForegroundColor = color;

            // Tell user it'sthe wrong number 
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();

        }
    }

}
