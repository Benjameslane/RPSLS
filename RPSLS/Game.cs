using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;                                                       //Need to walk through "committing" with instructor. Too important to mess up.
namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {
            
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper \nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock\n");
            
            Console.WriteLine("First player to score 2 points win!");
        }

        public int ChooseNumberOfHumanPlayers()
        //int numberOfHumanPlayers = int.Parse(Console.ReadLine());
        {
            Console.WriteLine("How many players will there be: 1 or 2?");
            int onePlayer = 1;
            int twoPlayers = 2;
            int numberOfHumanPlayers = int.Parse(Console.ReadLine());

            if (numberOfHumanPlayers == onePlayer)
            {
                Console.WriteLine("You picked One Human Player.");
                
            }
            else if (numberOfHumanPlayers == twoPlayers)
            {
                Console.WriteLine("You Picked Two Human Players");
                
            }
            else 
            {
                Console.WriteLine("Try selecting One or Two Human Players");
            }


            


                return numberOfHumanPlayers;
            
        }
        public void CreatePlayerObjects(int numberOfHumanPlayers)                                      //missing something here to get a value into numberOfHumanPlayers
        {                                                                                              // really struggling with how and when to return values. This i where mst of my error codes come from
            
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Insert Player Name:");
                
                
                playerOne = new HumanPlayer(Console.ReadLine());
                playerTwo = new ComputerPlayer("Player Two");
                
            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Insert Name For Player One");
              
                
               playerOne = new HumanPlayer(Console.ReadLine());
                 
                Console.WriteLine("Insert Name For Player Two");
               
                
                playerTwo = new HumanPlayer(Console.ReadLine());
                
            }
            
        }

        public void CompareGestures()                       // need a bit of guidance before starting my if else statement. I feel as if my variable to pass in are not alligned. 
        {
            

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("it's a draw");
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("it's a draw");
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("it's a draw");
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("it's a draw");
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("it's a draw");
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine($"{playerTwo.name} wins that round");
                    playerTwo.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine($"{playerOne.name} wins that round");
                    playerOne.score++;
                }
            }
        }

        public void DisplayGameWinner()
        {
            if(playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} WINS THE GAME!!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} WINS THE GAME!!");
            }
        }

        public void RunGame()
            //StepOne: Display the rules of the game
            //StepTwo: Ask how many human players will be playing
        {
            WelcomeMessage();
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);

            CompareGestures();
            DisplayGameWinner(); 




        }
    }
}
