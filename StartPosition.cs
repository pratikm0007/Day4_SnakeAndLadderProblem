using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SnakeAndLadderProblem
{
    public class StartPosition
    {
        /// <summary>
        /// Initialize position zero.
        /// </summary>
        public static void TakeStartPosition()
        {
            Console.WriteLine("Snake And Ladder Simulator");
            int Position = 0;           
            RollsTheDie.RollsDice(Position);
        }
    }
}
