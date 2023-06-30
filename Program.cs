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
        //Ask for the number of players, between 1 and 4
        System.Console.WriteLine("Please enter how many players there are, between 1 - 4.");
        string input = Console.ReadLine();
        int numOfPlayers = Convert.ToInt32(input);

        /******************************
            One Player Game
        ******************************/
        if (numOfPlayers == 1) {
            //Create one instance of Player
            Player newPlayer1 = new Player("Player 1"); 

            //Print the prompt to screen
            System.Console.WriteLine("Pick a number between 1-10.");

            //create a new instance of Random
            Random ran = new Random();
            //store the random number in an int
            int number = ran.Next(1,11);
            //Take input from the user
            input = Console.ReadLine();
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
        /*****************************************
            Two Player Game
        *****************************************/
        else if (numOfPlayers == 2) {
            //Create two instances of Player
            Player newPlayer1 = new Player("Player 1");
            Player newPlayer2 = new Player("Player 2");
            

             //create a new instance of Random
            Random ran = new Random();
            //store the random number in an int
            int number = ran.Next(1,11);

            //Print the prompt to screen
            System.Console.WriteLine("Pick a number between 1-10.");

            System.Console.WriteLine("Player 1: ");
            input = Console.ReadLine();
            newPlayer1.guess = Convert.ToInt32(input);
            System.Console.WriteLine("Player 2: ");
            input = Console.ReadLine();
            newPlayer2.guess = Convert.ToInt32(input);

            int p1Diff = number - newPlayer1.guess; 
            int p2Diff = number - newPlayer2.guess; 

            System.Console.WriteLine("The number was {0}.", number);
            if (p1Diff < p2Diff) {
                System.Console.WriteLine("Player 1 is closest!");
            }
            else if (p2Diff < p1Diff) { 
                System.Console.WriteLine("Player 2 is closest!");
            }
            
        }
        /************************************
            Three Player Game
        ***********************************/
        else if (numOfPlayers == 3) {
            //create three
            Player newPlayer1 = new Player("Player 1");
            Player newPlayer2 = new Player("Player 2");
            Player newPlayer3 = new Player("Player 3");

             //create a new instance of Random
            Random ran = new Random();
            //store the random number in an int
            int number = ran.Next(1,11);

            //Print the prompt to screen
            System.Console.WriteLine("Pick a number between 1-10.");

            System.Console.WriteLine("Player 1: ");
            input = Console.ReadLine();
            newPlayer1.guess = Convert.ToInt32(input);
            System.Console.WriteLine("Player 2: ");
            input = Console.ReadLine();
            newPlayer2.guess = Convert.ToInt32(input);
            System.Console.WriteLine("Player 3: ");
            input = Console.ReadLine();
            newPlayer3.guess = Convert.ToInt32(input);

            int p1Diff = number - newPlayer1.guess;
            if (p1Diff < 0) {
                p1Diff = Math.Abs(p1Diff);
            }
            int p2Diff = number - newPlayer2.guess;
            if (p2Diff < 0) {
                p2Diff = Math.Abs(p2Diff);
            }
            int p3Diff = number - newPlayer3.guess;
            if (p3Diff < 0) {
                p3Diff = Math.Abs(p3Diff);
            }

            System.Console.WriteLine("The number was {0}.", number);
            if (p1Diff < p2Diff && p1Diff < p3Diff || newPlayer1.guess == number) {
                System.Console.WriteLine("Player 1 is closest!");
            }
            else if (p2Diff < p1Diff && p2Diff < p3Diff || newPlayer2.guess == number) {
                System.Console.WriteLine("Player 2 is closest!");
            }
            else if (p3Diff < p1Diff && p3Diff < p2Diff || newPlayer3.guess == number) {
                System.Console.WriteLine("Player 3 is the closest!");
            }
        }
        /***********************************
            Four Player Game
        ***********************************/
        else if (numOfPlayers == 4) {
            //create four instances
            Player newPlayer1 = new Player("Player 1");
            Player newPlayer2 = new Player("Player 2");
            Player newPlayer3 = new Player("Player 3");
            Player newPlayer4 = new Player("Player 4");

            //create a new instance of Random
            Random ran = new Random();
            //store the random number in an int
            int number = ran.Next(1,11);

            //Print the prompt to screen
            System.Console.WriteLine("Pick a number between 1-10.");

            System.Console.WriteLine("Player 1: ");
            input = Console.ReadLine();
            newPlayer1.guess = Convert.ToInt32(input);
            System.Console.WriteLine("Player 2: ");
            input = Console.ReadLine();
            newPlayer2.guess = Convert.ToInt32(input);
            System.Console.WriteLine("Player 3: ");
            input = Console.ReadLine();
            newPlayer3.guess = Convert.ToInt32(input);
            System.Console.WriteLine("Player 4: ");
            input = Console.ReadLine();
            newPlayer4.guess = Convert.ToInt32(input);

            int p1Diff = number - newPlayer1.guess;
            if (p1Diff < 0) {
                p1Diff = Math.Abs(p1Diff);
            }
            int p2Diff = number - newPlayer2.guess;
            if (p2Diff < 0) {
                p2Diff = Math.Abs(p2Diff);
            }
            int p3Diff = number - newPlayer3.guess;
            if (p3Diff < 0) {
                p3Diff = Math.Abs(p3Diff);
            }
            int p4Diff = number - newPlayer4.guess;
            if (p4Diff < 0) {
                p4Diff = Math.Abs(p4Diff);
            }

            System.Console.WriteLine("The number was {0}.", number);
            if (p1Diff < p2Diff && p1Diff < p3Diff || newPlayer1.guess == number) {
                System.Console.WriteLine("Player 1 is closest!");
            }
            else if (p2Diff < p1Diff && p2Diff < p3Diff || newPlayer2.guess == number) {
                System.Console.WriteLine("Player 2 is closest!");
            }
            else if (p3Diff < p1Diff && p3Diff < p2Diff || newPlayer3.guess == number) {
                System.Console.WriteLine("Player 3 is the closest!");
            }
            else if (p4Diff < p1Diff && p4Diff < p2Diff  && p4Diff < p3Diff || newPlayer3.guess == number) {
                System.Console.WriteLine("Player 4 is the closest!");
            }

        }
        else {
            System.Console.WriteLine("That's not a valid choice.");
        }
        
    }
}
