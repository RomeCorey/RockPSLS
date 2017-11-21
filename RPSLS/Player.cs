using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {    
         public string getUserInput()
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


    }
}
