namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreCPU = 0;


                while (scorePlayer < 3 && scoreCPU < 3)
                {



                    Console.WriteLine("Choose between Rock, Paper and Scissors: ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!! \n \n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!! \n \n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!! \n \n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!! \n \n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!! \n \n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!! \n \n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!! \n \n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!! \n \n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!! \n \n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            break;
                    }

                    Console.WriteLine("\n PLAYER SCORE: " + scorePlayer + " \n CPU SCORE: " + scoreCPU);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON GAME!!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON GAME !!! ");
                }

                Console.WriteLine("Do you want to play again? ");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else Console.WriteLine("Bad input!");

            }

        }
    }
}