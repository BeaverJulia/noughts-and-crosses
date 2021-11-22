using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoughtsAndCrosses
{
    public class DrawOnBoard
    {
        public char[] Execute(char[] board, int nextPlayer, int row)
        {
            if (nextPlayer % 2 == 0)
            {
                board[row] = 'o';
                return board;
            }
            else
            {
                board[row] = 'x';
                return board;
            }
        }
    }
}
