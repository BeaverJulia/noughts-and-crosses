namespace NoughtsAndCrosses
{
    public class CheckBoard
    {
        public int Execute(char[] board)
        {
            if ((board[1] == board[2] && board[2] == board[3]) || //Horizontal1
                (board[4] == board[5] && board[5] == board[6]) || //Horizontal2
                (board[6] == board[7] && board[7] == board[8]) || //Horizontal3
                (board[1] == board[4] && board[4] == board[7]) || //Vertical1
                (board[2] == board[5] && board[5] == board[8]) || //Vertical2
                (board[3] == board[6] && board[6] == board[9]) || //Vertical3
                (board[3] == board[5] && board[5] == board[7])|| //Diagonal up => down
                (board[1] == board[5] && board[5] == board[9])) //Diagonal down => up
            {
                return 1;
            }
            else if  (board[1] != '1' && 
                      board[2] != '2' && 
                      board[3] != '3' && 
                      board[4] != '4' && 
                      board[5] != '5' && 
                      board[6] != '6' && 
                      board[7] != '7' && 
                      board[8] != '8' && 
                      board[9] != '9')
            {
               
                    return -1;
                
            }

            return 0;
        }
    }
}