using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, and Scissors!");
            GameStart();
            Console.Read();




        }

        private static void GameStart()
        {
            string playerChoice;
            int playerScore;
            int enemyScore;
            int numberOfRounds;
            int roundsPlayed;
            Random enemyChoice = new Random();
            bool playAgain = true;
            string playAgainAnswer;
            // 1 = rock
            // 2 = paper
            // 3 = scissors


            while (playAgain == true)
            {
                Console.WriteLine("How many rounds would you like to play?");
                playerScore = 0;
                enemyScore = 0;
                roundsPlayed = 0;

                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out numberOfRounds))
                    {
                        Console.WriteLine("Please type a positive integer");
                    }
                    else
                    {
                        if (numberOfRounds >= 1)
                        {
                            break;
                        }
                        Console.WriteLine("Please type a positive integer");
                    }
                }

                while (roundsPlayed < numberOfRounds)
                {
                    Console.WriteLine("Rock, Paper, or Scissors?");
                    playerChoice = Console.ReadLine();
                    playerChoice = playerChoice.ToLower();
                    int roundChoice = enemyChoice.Next(1, 4);
                    if (playerChoice == "rock")
                    {
                        if (roundChoice == 1)
                        {
                            Console.WriteLine("Enemy chose Rock");
                            Console.WriteLine("It's a tie");

                            roundsPlayed++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);


                        }
                        if (roundChoice == 2)
                        {
                            Console.WriteLine("Enemy chose Paper");
                            Console.WriteLine("Paper beats Rock, you lose.");

                            roundsPlayed++;
                            enemyScore++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);

                        }
                        if (roundChoice == 3)
                        {
                            Console.WriteLine("Enemy chose Scissors");
                            Console.WriteLine("Rock beats Scissors, you win!");
                            roundsPlayed++;
                            playerScore++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);

                        }

                    }
                    if (playerChoice == "paper")
                    {

                        if (roundChoice == 1)
                        {
                            Console.WriteLine("Enemy chose Rock");
                            Console.WriteLine("Paper beats Rock, you win!");

                            roundsPlayed++;
                            playerScore++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);


                        }
                        if (roundChoice == 2)
                        {
                            Console.WriteLine("Enemy chose Paper");
                            Console.WriteLine("It's a tie.");

                            roundsPlayed++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);

                        }
                        if (roundChoice == 3)
                        {
                            Console.WriteLine("Enemy chose Scissors");
                            Console.WriteLine("Scissors beats Paper, you lose.");
                            roundsPlayed++;
                            enemyScore++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);


                        }


                    }
                    if (playerChoice == "scissors")
                    {

                        if (roundChoice == 1)
                        {
                            Console.WriteLine("Enemy chose Rock");
                            Console.WriteLine("Rock beats Scissors, you lose");

                            roundsPlayed++;
                            enemyScore++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);


                        }
                        if (roundChoice == 2)
                        {
                            Console.WriteLine("Enemy chose Paper");
                            Console.WriteLine("Scissors beats Paper, you win!.");

                            roundsPlayed++;
                            playerScore++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);

                        }
                        if (roundChoice == 3)
                        {
                            Console.WriteLine("Enemy chose Scissors");
                            Console.WriteLine("It's a tie.");
                            roundsPlayed++;
                            RoundResult(playerScore, enemyScore, numberOfRounds, roundsPlayed);


                        }


                    }
                    if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
                    {
                        Console.WriteLine("Incorrect choice, please try again");
                    }
                }

                if (playerScore > enemyScore)
                {
                    Console.WriteLine($"The final score was {playerScore} to {enemyScore}. You won! Congratulations!!");
                }
                if (enemyScore > playerScore)
                {
                    Console.WriteLine($"The final score was {playerScore} to {enemyScore}. You lost! Better luck next time!!");
                }
                if (playerScore == enemyScore)
                {
                    Console.WriteLine($"The final score was {playerScore} to {enemyScore}. It ended in a tie!!");
                }
                Console.WriteLine("Would you like to play again? Yes or No?");
                playAgainAnswer = Console.ReadLine();
                playAgainAnswer = playAgainAnswer.ToLower();
                bool goodInput = true;
                while (goodInput)
                {
                    if (playAgainAnswer != "yes" && playAgainAnswer != "no")
                    {
                        Console.WriteLine("Incorrect input, please enter yes or no");
                        playAgainAnswer = Console.ReadLine();
                        playAgainAnswer = playAgainAnswer.ToLower();
                    }
                    else
                    {
                        if (playAgainAnswer == "yes")
                        {
                            goodInput = false;


                            break;
                        }
                        if (playAgainAnswer == "no")
                        {
                            Console.WriteLine("Thanks for playing!");
                            goodInput = false;
                            playAgain = false;
                        }
                    }

                }

            }
        }

        private static void RoundResult(int playerScore, int enemyScore, int numberOfRounds, int roundsPlayed)
        {
            Console.WriteLine($"The score is {playerScore} to {enemyScore}. {numberOfRounds - roundsPlayed} rounds reamin");
        }
    }
}
