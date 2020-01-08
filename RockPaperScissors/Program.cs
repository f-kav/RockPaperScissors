using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerInput;
            string computerInput;

            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {
                int playerScore = 0;
                int computerScore = 0;

                Console.Write("First to 3 Wins! \n");

                while (playerScore < 3 && computerScore < 3)
                {
                    Console.Write("Rock, Paper or Scissors?");
                    playerInput = Console.ReadLine();
                    playerInput = playerInput.ToUpper();

                    Random random = new Random();

                    randomInt = random.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            computerInput = "ROCK";
                            Console.WriteLine("Computer Chose Rock");
                            if (playerInput == "ROCK")
                            {
                                Console.WriteLine("DRAW!\n");
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("YOU WIN!\n");
                                playerScore++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("COMPUTER WINS!\n");
                                computerScore++;
                            }
                            break;
                        case 2:
                            computerInput = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (playerInput == "PAPER")
                            {
                                Console.WriteLine("DRAW!\n");
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("COMPUTER WINS!\n");
                                computerScore++;
                            }
                            else if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("YOU WIN!\n");
                                playerScore++;
                            }
                            break;
                        case 3:
                            computerInput = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (playerInput == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!\n");
                            }
                            else if (playerInput == "ROCK")
                            {
                                Console.WriteLine("YOU WIN!\n");
                                playerScore++;
                            }
                            else if (playerInput == "PAPER")
                            {
                                Console.WriteLine("COMPUTER WINS!\n");
                                computerScore++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tYOU:\t{0}\tCPU:\t{1}", playerScore, computerScore);

                }

                if (playerScore == 3)
                {
                    Console.WriteLine("YOU WON!");
                }
                else if (computerScore == 3)
                {
                    Console.WriteLine("COMPUTER WON!");
                }
       
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}


