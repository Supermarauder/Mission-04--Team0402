using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission_04__Team0402
{
    internal class supporting
    {
        public string[] receiveBoard(string[] asBoard)
        {
            // array from 0-8 that is received 

            //loop to print out
            for (int iCount = 0;  iCount < asBoard.Length; iCount++) 
            {
                if (iCount % 3 == 0)
                {
                    Console.WriteLine(asBoard[iCount]);
                }
                else
                {
                    Console.Write(asBoard[iCount]);
                }
                //have a  built in counter that goes to the next line every 3 values

                //maybe use an $ string method instead to print the board

                Console.WriteLine($" | {asBoard[0]} | {asBoard[1]} | {asBoard[2]} ");
                Console.WriteLine($" | {asBoard[3]} | {asBoard[4]} | {asBoard[5]} ");
                Console.WriteLine($" | {asBoard[6]} | {asBoard[7]} | {asBoard[8]} ");
            }
            return asBoard;
        }
        public string[] DetermineWinner(string[] asBoard) 
        {0




            return asBoard;
        }
    }
}
