
using System;

//Namespace
namespace numberGuesser
{

    //Main Class
    class Program
    {

        //Entry Point
        static void Main(string[] args)
        {

            GetAppInfo();

            GreetUser();


            while (true)
            {

                //int correctNum = 7;
                Random random = new Random();
                int correctNum = random.Next(1, 11);
                int guessNum = 0;
                Console.WriteLine("Guess a number between 1 and 10. ");

                while (guessNum != correctNum)
                {
                    string input2 = Console.ReadLine();
                    //validation
                    if (!int.TryParse(input2, out guessNum))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number: ");
                        continue;
                    }
                    guessNum = Int32.Parse(input2);

                    if (guessNum != correctNum)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Number is incorrect...guess again: ");
                    }

                }

                PrintColorMessage(ConsoleColor.Yellow, "You guessed the correct number! ");

                Console.WriteLine("Would you like to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {

                } else if (answer == "N")
                {
                    return;
                }


            }

        } //Ends main

        //**********************************************************

        static void GetAppInfo()
        {
            // app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mike Santoro";

            //text color
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //header
            Console.WriteLine("{0}: Version: {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            Console.WriteLine("What is your name? ");
            // user input
            string input = Console.ReadLine();
            Console.WriteLine("Hello {0}, lets play a game...", input);
        }

        static void PrintColorMessage (ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    } //Ends class


} //Ends Namespace
