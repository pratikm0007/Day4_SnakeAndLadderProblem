using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Report
    {
        /// <summary>
        /// The Number of time dice was played to win position .
        /// </summary>
        public static void DiceThrowCount(int Position, int diceValue, int countDicePlay)
        {
            Console.WriteLine(" Number of Times Dice was played is : {0}", + countDicePlay);
            Console.WriteLine("Position after {0} Die play is {1}",+countDicePlay, Position);
        }
    }
}
