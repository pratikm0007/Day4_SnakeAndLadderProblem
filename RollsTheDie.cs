using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class RollsTheDie
    {
        public static int countDicePlay = 0;
        /// <summary>
        /// It gives dice value.
        /// </summary>
        public static void RollsDice(int Position)
        {                
            Random throwDice = new Random();
            int diceValue = throwDice.Next(1, 7);
            Console.WriteLine("Dice value is {0}", + diceValue);
            countDicePlay++;
            CheckForOption.SelectOption(Position, diceValue, countDicePlay);
        }


    }
}
