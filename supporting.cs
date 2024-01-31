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
                Console.Write(asBoard[iCount]);
                //have a  built in counter that goes to the next line every 3 values
            }
            return asBoard;
        }
    }
}
