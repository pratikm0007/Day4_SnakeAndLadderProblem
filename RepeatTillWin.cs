using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class RepeatTillWin
    {
        /// <summary>
        /// Repeating till the player reaches wining position.
        /// </summary>
        public static void PlayerWin(int Position, int diceValue, int countDicePlay )
        {
            if (Position == 100)
            {
                Console.WriteLine("Player reach the win position  {0}", +Position);
                ExactWin.match(Position, diceValue, countDicePlay);
            }
            else
            {                
                while (Position < 100)
                {
                    RollsTheDie.RollsDice(Position);
                    break;
                }
            }          
        }
    }
}
