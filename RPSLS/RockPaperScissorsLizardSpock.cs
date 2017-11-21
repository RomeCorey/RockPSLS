using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RockPaperScissorsLizardSpock
    {        
        public int PlayerOne;
        public int PlayerTwo;
        public bool IsWinner;         

        public string GetGameMode()
        {
            Console.Write("Would you like to play option '1' against the computer, or option '2' against another human?");
            return Console.ReadLine();    
        }

        public void Play()
        {
            string GameMode = GetGameMode();           
            if (GameMode == "1")
            {
                PlayerVsAI();
            }
            else if (GameMode == "2")
            {
                PlayerVsPlayer();
            }
        }

        public void PlayerVsAI()
        {
            Player PlayerHuman = new Player();
            AI PlayerComputer = new AI();
            PlayerOne = 0;
            PlayerTwo = 0;
            IsWinner = false;           
            while (!IsWinner)
            {
                string UserInput = PlayerHuman.getUserInput();
                string CompInput = PlayerComputer.getCompInput();               
                if ((UserInput == "Rock" && CompInput == "Scissors" || UserInput == "Rock" && CompInput == "Lizard" || UserInput == "Paper" && CompInput == "Rock" || UserInput == "Paper" && CompInput == "Spock" || UserInput == "Scissors" && CompInput == "Paper" || UserInput == "Scissors" && CompInput == "Lizard" || UserInput == "Lizard" && CompInput == "Spock" || UserInput == "Lizard" && CompInput == "Paper" || UserInput == "Spock" && CompInput == "Scissors" || UserInput == "Spock" && CompInput == "Rock"))
                {
                    Console.Write("Player One chose " + UserInput + "and the computer chose " + CompInput + ". Player One wins!");
                    PlayerOne++;
                }

                else if (UserInput == CompInput)
                {
                    Console.Write("Great minds think alike, its a tie.");
                }

                else
                {
                    Console.Write("Player One chose " + UserInput + " and the computer chose " + CompInput + ". Player One lost");
                    PlayerTwo++;
                }                        
                if (PlayerOne == 2)
                {
                    IsWinner = true;
                    Console.Write("Player One won best of 3!");
                }
                else if (PlayerTwo == 2)
                {
                    IsWinner = true;
                    Console.Write("Player Two won best of 3!");
                }
            }
        }

        public void PlayerVsPlayer()
        {
            Player PlayerHuman = new Player();
            AI PlayerHumanTwo = new AI();
            PlayerOne = 0;
            PlayerTwo = 0;
            IsWinner = false;
            while (!IsWinner)
            {
                string UserInput = PlayerHuman.getUserInput();
                string HumanInput = PlayerHumanTwo.getCompInput();
                if ((UserInput == "Rock" && HumanInput == "Scissors" || UserInput == "Rock" && HumanInput == "Lizard" || UserInput == "Paper" && HumanInput == "Rock" || UserInput == "Paper" && HumanInput == "Spock" || UserInput == "Scissors" && HumanInput == "Paper" || UserInput == "Scissors" && HumanInput == "Lizard" || UserInput == "Lizard" && HumanInput == "Spock" || UserInput == "Lizard" && HumanInput == "Paper" || UserInput == "Spock" && HumanInput == "Scissors" || UserInput == "Spock" && HumanInput == "Rock"))
                {
                    Console.Write("Player One chose " + UserInput + "and the computer chose " + HumanInput + ". Player One wins!");
                    PlayerOne++;
                }

                else if (UserInput == HumanInput)
                {
                    Console.Write("Great minds think alike, its a tie.");
                }

                else
                {
                    Console.Write("Player One chose " + UserInput + " and the computer chose " + HumanInput + ". Player One lost");
                    PlayerTwo++;
                }
                if (PlayerOne == 2)
                {
                    IsWinner = true;
                    Console.Write("Player One won best of 3!");
                }
                else if (PlayerTwo == 2)
                {
                    IsWinner = true;
                    Console.Write("Player Two won best of 3!");
                }
            }
        }
    }

    }
