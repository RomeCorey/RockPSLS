 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI
    {
        int wins;
        int move;
        Random random = new Random();

        public string getCompInput()
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
    }
}
