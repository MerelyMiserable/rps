public class main
{
    public static void Main()
    {
        string userInput = "";
        string computerInput = "";
        int userScore = 0;
        int computerScore = 0;
        int round = 1;
        bool gameOver = false;
        bool userWins = false;
        bool computerWins = false;
        bool tie = false;
        string[] options = { "rock", "paper", "scissors" };

        while (!gameOver)
        {
            Console.WriteLine("Round " + round);
            Console.WriteLine("Enter your choice: rock, paper, or scissors");
            userInput = Console.ReadLine();
            computerInput = options[new Random().Next(3)];
            Console.WriteLine("Computer chose " + computerInput);
            if (userInput == computerInput)
            {
                tie = true;
                Console.WriteLine("It's a tie!");
            }
            else if (userInput == "rock" && computerInput == "scissors")
            {
                userWins = true;
                Console.WriteLine("You win!");
            }
            else if (userInput == "rock" && computerInput == "paper")
            {
                computerWins = true;
                Console.WriteLine("Computer wins!");
            }
            else if (userInput == "paper" && computerInput == "rock")
            {
                userWins = true;
                Console.WriteLine("You win!");
            }
            else if (userInput == "paper" && computerInput == "scissors")
            {
                computerWins = true;
                Console.WriteLine("Computer wins!");
            }
            else if (userInput == "scissors" && computerInput == "paper")
            {
                userWins = true;
                Console.WriteLine("You win!");
            }
            else if (userInput == "scissors" && computerInput == "rock")
            {
                computerWins = true;
                Console.WriteLine("Computer wins!");
            }
            if (userWins)
            {
                userScore++;
                userWins = false;
            }
            else if (computerWins)
            {
                computerScore++;
                computerWins = false;
            }
            if (userScore == 3)
            {
                Console.WriteLine("You win the game!");
                gameOver = true;
                //ask to play again
                Console.WriteLine("Play again? y/n");
                userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    Main();
                }
            }
            else if (computerScore == 3)
            {
                Console.WriteLine("Computer wins the game!");
                gameOver = true;
                //ask to play again
                Console.WriteLine("Play again? y/n");
                userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    Main();
                }
            }
            round++;
        }
    }
}
