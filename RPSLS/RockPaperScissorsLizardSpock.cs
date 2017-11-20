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

        public void Play()
        {
            string UserInput = getUserInput();
            string CompInput = getCompInput();
            int PlayerOne;
            int PlayerTwo;

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
            if (( UserInput == "Rock" && CompInput == "Scissors" || UserInput == "Rock" && CompInput == "Lizard" || UserInput == "Paper" && CompInput == "Rock" || UserInput == "Paper" && CompInput == "Spock" || UserInput == "Scissors" && CompInput == "Paper" || UserInput == "Scissors" && CompInput == "Lizard" || UserInput == "Lizard" && CompInput == "Spock" || UserInput == "Lizard" && CompInput == "Paper" || UserInput == "Spock" && CompInput == "Scissors" || UserInput == "Spock" && CompInput == "Rock"))
            {
            
                Console.Write("Player One chose " +UserInput+ "and the computer chose " +CompInput+ ". Player One wins!");
            }

            else if (UserInput == CompInput)
            {
                Console.Write("Great minds think alike, its a tie.");
            }

            else
            {
              
                Console.Write("Player One chose " + UserInput + " and the computer chose " + CompInput + ". Player One lost");
            }
        }
    }

    }
