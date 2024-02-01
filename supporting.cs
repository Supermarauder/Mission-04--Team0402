using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_04__Team0402
{
    internal class Supporting
    {
        public string receiveBoard(string[] asBoard)
        {
           //The Board array is received and put into the sResults string so it can be easily returned and printed
           //The following print simulates a 3x3 grid
         string sResults = $" | {asBoard[0]} | {asBoard[1]} | {asBoard[2]} ";
                sResults += $"\n ------";
                sResults += $"\n | {asBoard[3]} | {asBoard[4]} | {asBoard[5]} ";
                sResults += $"\n ------";
                sResults += $"\n | {asBoard[6]} | {asBoard[7]} | {asBoard[8]} ";
                sResults += $"\n ------";

            return sResults;
        }
        public string determineWinner(string[] asBoard) 
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (asBoard[i * 3] == asBoard[i * 3 + 1] && asBoard[i * 3 + 1] == asBoard[i * 3 + 2])
                {
                   if (asBoard[i * 3] == "X" )
                    {
                        return "Player 1 wins";
                    }
                   else
                    {
                        return "Player 2 wins";
                    }
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (asBoard[i] == asBoard[i + 3] && asBoard[i + 3] == asBoard[i + 6])
                {
                    if (asBoard[i] == "X")
                    {
                        return "Player 1 wins";
                    }
                    else
                    {
                        return "Player 2 wins";
                    }
                }
            }

            // Check diagonals
            if (asBoard[0] == asBoard[4] && asBoard[4] == asBoard[8])
            {
                if (asBoard[0] == "X")
                {
                    return "Player 1 wins";
                }
                else
                {
                    return "Player 2 wins";
                }
            }

            if (asBoard[2] == asBoard[4] && asBoard[4] == asBoard[6])
            {
                if (asBoard[2] == "X")
                {
                    return "Player 1 wins";
                }
                else
                {
                    return "Player 2 wins";
                }
            }

            // Check for any open spaces
            for (int i = 0; i < asBoard.Length; i++)
            {
                if (asBoard[i] == " ")
                {
                    return "The game continues!";
                }
            }

            // No winner and no open spaces
            return "Tie game";

        }
    }
}
