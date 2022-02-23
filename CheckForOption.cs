using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class CheckForOption
    {
        /// <summary>
        /// To check the option between Snake, Ladder or NoPlay.
        /// </summary>
        public static void SelectOption(int Position, int diceValue, int countDicePlay)
        {
            int noPlay = 1;
            int snake = 2;
            Random Option = new Random();
            int checkoption = Option.Next(1, 4);            
            if (checkoption == noPlay)
            {
                Console.WriteLine("NoPlay");
                Position = Position + 0;
                Console.WriteLine("Updated position is {0}", + Position);
            }
            else if (checkoption == snake)
            {
                Console.WriteLine("Snake");
                Position -= diceValue;
                if (Position < 0)
                {
                    Position = 0;
                }
                Console.WriteLine("Updated position is {0}", + Position);
            }
            else
            {
                Console.WriteLine("Ladder");
                 Position += diceValue;
                if (Position > 100)
                {
                    Position -= diceValue;
                }
                Console.WriteLine("Updated position is {0}", + Position);
            }           
            RepeatTillWin.PlayerWin(Position, diceValue, countDicePlay);
        }


    }
}
