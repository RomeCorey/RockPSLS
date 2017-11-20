using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class RockPaperScissorsLizardSpock
    {
        Random random = new Random();
        int PlayerOne;
        int PlayerTwo;

        public void Play()
        {
            string UserInput = getUserInput();
            string CompInput = getCompInput();
            

            Winner(UserInput, CompInput);
            Console.ReadLine();

        }



        string getUserInput()
        {

            Console.WriteLine("Choose 'Rock', 'Paper', 'Scissors', 'Lizard', or 'Spock'.");
            string choice = Console.ReadLine();

            if (choice == "Rock")
            {
                return "Rock";
            }
            if (choice == "Paper")
            {
                return "Paper";
            }
            if (choice == "Scissors")
            {
                return "Scissors";
            }
            if (choice == "Lizard")
            {
                return "Lizard";
            }
            if (choice == "Spock")
            {
                return "Spock";
            }
            return "";
        }
            string getCompInput()
                {

                int number = random.Next(1, 6);
                if (number == 1)
                {
                    return "Rock";  
                }
                if (number == 2)
                {
                    return "Paper";
                }
                if (number == 3)
                {
                    return "Scissors";
                }
                if (number == 4)
                {
                    return "Lizard";
                }
                if (number == 5)
                {
                    return "Spock";
              
                }
            return "";
            }

        public void Winner(string UserInput, string CompInput)
        {
            for (int PlayerOne = 0; PlayerOne > 3; PlayerOne++)
            {
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
                    Console.Write("Player One won best of 3!");
                }
                else if (PlayerTwo == 2)
                {
                    Console.Write("Player Two won best of 3!");
                }
            }
        }
    }

    }
