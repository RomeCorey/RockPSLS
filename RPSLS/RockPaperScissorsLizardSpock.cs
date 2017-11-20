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

        public void Play()
        {
            Player PlayerOne = new Player();
            AI Computer = new AI();
            string UserInput = PlayerOne.getUserInput();
            string CompInput = Computer.getCompInput();
            Winner(UserInput, CompInput);
            Console.ReadLine();
        }

        public void Winner(string UserInput, string CompInput)
        {
            Player PlayerHuman = new Player();
            AI PlayerComputer = new AI();
            PlayerOne = 0;
            PlayerTwo = 0;
            IsWinner = false;           
            while (!IsWinner)
            {
                PlayerHuman.getUserInput();
                PlayerComputer.getCompInput();                
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
    }

    }
