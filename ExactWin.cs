using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class ExactWin
    {
        /// <summary>
        /// This Ensure that player get exact position 100.
        /// </summary>
        public static void match(int Position, int diceValue, int countDicePlay)
        {
            Console.WriteLine("Check Exact win position 100 = True, otherwise False");
            Console.WriteLine(Position.Equals(100));
            Report.DiceThrowCount(Position, diceValue, countDicePlay);                        
        }
    }
}
