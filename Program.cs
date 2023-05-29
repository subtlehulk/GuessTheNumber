#nullable disable

using System;

namespace GuessTheNumber;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Would you like to play Guess the Number?");
        string play = Console.ReadLine();
        while ((play == "y" || play ==  "Y" || play == "yes" || play == "Yes"))
        {
            PlayGame();
            System.Console.WriteLine("Would you like to play again?");
            play = Console.ReadLine();
        }
        System.Console.WriteLine("Alright, catch you next time!");

        
        
    }

    private static void PlayGame() {
        System.Console.WriteLine("Pick a number between 1-10.");
        Random ran = new Random();
        int number = ran.Next(1,11);

        string input = Console.ReadLine();
        int guess = Convert.ToInt32(input);
        if (guess == number) {
            System.Console.WriteLine("Congrats, you guess it correctly. The number was {0}", number);

        }
        else {
            System.Console.WriteLine("Ugh, better luck next time!");
            System.Console.WriteLine("The number was {0}", number);
        }
        
    }
}
