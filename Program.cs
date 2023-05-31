#nullable disable

using System;

namespace GuessTheNumber;
class Program
{
    static void Main(string[] args)
    {
        //Take prompt from the user and store it
        System.Console.WriteLine("Would you like to play Guess the Number?");
        string play = Console.ReadLine();
        //Check the input against conditions
        while ((play == "y" || play ==  "Y" || play == "yes" || play == "Yes"))
        {
            //if condition is met, call the playGame method
            PlayGame();
            //prompt the user for another go at the game
            System.Console.WriteLine("Would you like to play again?");
            play = Console.ReadLine();
        }
        //When the condition isn't met, prompt an exit message
        System.Console.WriteLine("Alright, catch you next time! Please press 'enter' to exit..");
        Console.ReadKey();

        
        
    }

    private static void PlayGame() { 
        //Print the prompt to screen
        System.Console.WriteLine("Pick a number between 1-10.");

        //create a new instance of Random
        Random ran = new Random();
        //store the random number in an int
        int number = ran.Next(1,11);

        //Take input from the user
        string input = Console.ReadLine();
        //convert the input to an int and store it
        int guess = Convert.ToInt32(input);
        ////Check the input against the random number
        if (guess == number) {
            System.Console.WriteLine("Congrats, you guess it correctly. The number was {0}", number);

        }
        else {
            System.Console.WriteLine("Ugh, better luck next time!");
            System.Console.WriteLine("The number was {0}", number);
        }
        
    }
}
