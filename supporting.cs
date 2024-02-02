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
            string sResults = $"   {asBoard[0]} | {asBoard[1]} | {asBoard[2]} ";
            sResults += $"\n ----------";
            sResults += $"\n   {asBoard[3]} | {asBoard[4]} | {asBoard[5]} ";
            sResults += $"\n ----------";
            sResults += $"\n   {asBoard[6]} | {asBoard[7]} | {asBoard[8]}";
            

            return sResults;
        }
        public string determineWinner(string[] asBoard)
        {
            string sResult = "";
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                //This will systematically go throw row by row to see if there are any values that match 3 in a row
                if (asBoard[i * 3] == asBoard[i * 3 + 1] && asBoard[i * 3 + 1] == asBoard[i * 3 + 2])
                {
                    //If there is a match of 3 of the same value it determines the winner based on if its X's (player 1) or O's (player 2)
                    if (asBoard[i * 3].ToUpper() == "X")
                    {
                        sResult = "Player1";
                        return sResult;
                    }
                    else if (asBoard[i * 3].ToUpper() == "O")
                    {
                        sResult = "Player2";
                        return sResult;
                    }
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                //This will systematically go throw column by column to see if there are any values that match 3 in a column
                if (asBoard[i] == asBoard[i + 3] && asBoard[i + 3] == asBoard[i + 6])
                {
                    //If there is a match of 3 of the same value it determines the winner based on if its X's (player 1) or O's (player 2)
                    if (asBoard[i].ToUpper() == "X")
                    {
                        sResult = "Player1";
                        return sResult;
                    }
                    else if (asBoard[i].ToUpper() == "O")
                    {
                        sResult = "Player2";
                        return sResult;
                    }
                }
            }

            // Check diagonals
            //Checks from the top left to the bottom right to see if there is three in a row
            if (asBoard[0] == asBoard[4] && asBoard[4] == asBoard[8])
            {
                //If there is three in a row, method determines the winner based on if its X's (player 1) or O's (player 2)
                if (asBoard[0].ToUpper() == "X")
                {
                    sResult = "Player1";
                    return sResult;
                }
                else if (asBoard[0].ToUpper() == "O")
                {
                    sResult = "Player2";
                    return sResult;
                }
            }

            //Checks from the top right to the bottom left to see if there is three in a row
            if (asBoard[2] == asBoard[4] && asBoard[4] == asBoard[6])
            {
                //If there is three in a row, method determines the winner based on if its X's (player 1) or O's (player 2)
                if (asBoard[2].ToUpper() == "X")
                {
                    sResult = "Player1";
                    return sResult;
                }
                else if (asBoard[2].ToUpper() == "O")
                {
                    sResult = "Player2";
                    return sResult;
                }
            }

            // Check for any open spaces
            for (int i = 0; i < asBoard.Length; i++)
            {
                if (asBoard[i].ToUpper() == "")
                {
                    sResult = "undetermined";
                    return sResult;
                }
            }

            // No winner and no open spaces
            sResult = "tie";
            return sResult;


        }
    }
}
