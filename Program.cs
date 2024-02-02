/* Authors: Hayden Cowart, Christian Breshears (Program.cs)
 *          Ryan Whisenant, PJ Phethean (supporting.cs)
 * 2/1/24 
 * Description: This program plays tic tac toe. program.cs is the driver and runs the logic of the game 
 *      while also giving parameters to supporting.cs and receiving results supporting.cs 's methods.
 *       This game lets two players play tic tac toe. players play the game by pressing q, w, e, a, s, d, z, x, or c into the keyboard to place an X or O in the desired position.
 *      Supporting.cs has methods to display the board (received an array parameter from program.cs to display the most up to date board)
 *      and also to check if player 1 won, player 2 won, a tie game, or undetermined winner (aka, the game continues)
 */

using Mission_04__Team0402;
Supporting s = new Supporting();
// create variables for do while and a counter to see who's turn it is.
// If i = 1, then player 1's turn. if 2, player 2.
bool gameOver = false;
int i = 1;
//initiate array to pass to supporting class
string[] asBoard = new string[9] { "", "", "", "", "", "", "", "", "" };

int position = 10;  //set equal to 10 because 0-8 are used in the program


//welcome user to the game
Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine("This game is for two players. What is player 1's name?");
string player1 = Console.ReadLine();

//check for invalid entry
while (player1 == "")
{
    Console.WriteLine("Can you just type in a name instead of trying to break the program?");
    Console.WriteLine("Try again. What is Player 1's name?");
    player1 = Console.ReadLine();
}
Console.WriteLine("What is Player 2's name?");
string player2 = Console.ReadLine();

//check for invalid entry
while (player2 == "")
{
    Console.WriteLine("Can you just type in a name instead of trying to break the program?");
    Console.WriteLine("Try again. What is Player 2's name?");
    player2 = Console.ReadLine();
}

//info for user
Console.WriteLine(player1 + " is X's and " + player2 + " is O's. " + player1 + " will go first.");


//this do while loop controls the entire game. while gameOver = false, the game continues. as soon as a winner is determined, gameOver is set to true and this loop is exited.
do
{

    // player 1's turn. turns are decided by the variable i. if i=1, player 1 turn. if i=2, player2's turn.
    if (i == 1)
    {

        do
        {   //check for the winner at the start of every turn
            if (s.determineWinner(asBoard) == "Player1")
            {
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine(player1 + " got 3 in a row! They win!");

                gameOver = true;
                i = 0;
            }
            else if (s.determineWinner(asBoard) == "Player2")
            {
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine(player2 + " got 3 in a row! They win!");
                gameOver = true;
                i = 0;
            }

            else if (s.determineWinner(asBoard) == "tie")
            {
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine("Tie Game! No one wins!");
                gameOver = true;
                i = 0;
            }
            // if the winner is yet to be determined, continue with the player's turn
            else if (s.determineWinner(asBoard) == "undetermined")
            {
                // give basic instructions everytime their turn starts
                Console.WriteLine("It is now " + player1 + "'s turn.");
                Console.WriteLine("Here is the board:");
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine("Instructions:");
                Console.WriteLine("Q for upper left. W for upper middle. E for upper right.");
                Console.WriteLine("A for middle left. S for middle middle. D for middle right.");
                Console.WriteLine("Z for bottom left. X for bottom middle. C for bottom right.");
                Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");




                //receive the input for their turn
                //create variable "tester" as a string. then, create char variable and sert it equal to the first position in tester. Do this to convert from a string to a char
                string tester = Console.ReadLine();

                // make sure the length of the user input is 1 character. if not, tell the user invalid entry
                if (tester.Length == 1)
                {
                    //convert from string to char
                    char player1Move = tester[0];

                    //There's probably a better way to do this... 
                    // decypher user input and keep a record of their input and update the array, asBoard, which will later be passed as a parameter to supporting.cs
                    if (player1Move == 'q')
                    {
                        position = 0;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            //Player1 has now completed a valid entry. increment i to switch to player 2's turn
                            i++;
                        }
                        // check for invalid input
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 'w')
                    {
                        position = 1;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 'e')
                    {
                        position = 2;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 'a')
                    {
                        position = 3;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 's')
                    {
                        position = 4;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 'd')
                    {
                        position = 5;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 'z')
                    {
                        position = 6;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 'x')
                    {
                        position = 7;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player1Move == 'c')
                    {
                        position = 8;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "X";
                            i++;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You made an invalid entry. Press enter then try again.");
                        //          Console.WriteLine(s.receiveBoard(asBoard));
                        //         Console.WriteLine("Instructions:");
                        /* Console.WriteLine("Q for upper left. W for upper middle. E for upper right.");
                         Console.WriteLine("A for middle left. S for middle middle. D for middle right.");
                         Console.WriteLine("Z for bottom left. X for bottom middle. C for bottom right.");
                         Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
                        */
                        tester = Console.ReadLine();
                        if (tester.Length == 1)
                        {
                            player1Move = tester[0];
                        }
                        else
                        {
                            Console.WriteLine("You made an invalid entry. Try again");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("You made an invalid entry. Try again");
                }
            }
        } while (i == 1 & gameOver == false);
    }
    // player 2's turn
    if (i == 2)
    {
        // comments for this code would be borderline the exact same thing as the comments for player 1's turn. it's the same logic, just for a different player.
        do
        {
            if (s.determineWinner(asBoard) == "Player1")
            {
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine(player1 + " got 3 in a row! They win!");

                gameOver = true;
                i = 0;
            }
            else if (s.determineWinner(asBoard) == "Player2")
            {
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine(player2 + " got 3 in a row! They win!");
                gameOver = true;
                i = 0;
            }

            else if (s.determineWinner(asBoard) == "tie")
            {
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine("Tie Game! No one wins!");
                gameOver = true;
                i = 0;
            }
            else if (s.determineWinner(asBoard) == "undetermined")
            {
                // give basic instructions everytime their turn starts
                Console.WriteLine("It is now " + player2 + "'s turn.");
                Console.WriteLine("Here is the board:");
                Console.WriteLine(s.receiveBoard(asBoard));
                Console.WriteLine("Instructions:");
                Console.WriteLine("Q for upper left. W for upper middle. E for upper right.");
                Console.WriteLine("A for middle left. S for middle middle. D for middle right.");
                Console.WriteLine("Z for bottom left. X for bottom middle. C for bottom right.");
                Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");


                //receive the input for their turn
                string tester = Console.ReadLine();
                if (tester.Length == 1)
                {


                    char player2Move = tester[0];

                    //decipher the user input
                    if (player2Move == 'q')
                    {
                        position = 0;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            //down the i to send to player 1
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 'w')
                    {
                        position = 1;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 'e')
                    {
                        position = 2;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 'a')
                    {
                        position = 3;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 's')
                    {
                        position = 4;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 'd')
                    {
                        position = 5;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 'z')
                    {
                        position = 6;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 'x')
                    {
                        position = 7;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else if (player2Move == 'c')
                    {
                        position = 8;
                        if (asBoard[position] == "")
                        {
                            asBoard[position] = "O";
                            i--;
                        }
                        else
                        {
                            Console.WriteLine("This position is filled. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("You made an invalid entry. Press enter then try again.");
                        //            Console.WriteLine(s.receiveBoard(asBoard));
                        //          Console.WriteLine("Instructions:");
                        /* Console.WriteLine("Q for upper left. W for upper middle. E for upper right.");
                         Console.WriteLine("A for middle left. S for middle middle. D for middle right.");
                         Console.WriteLine("Z for bottom left. X for bottom middle. C for bottom right.");
                         Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
                        */
                        tester = Console.ReadLine();
                        player2Move = tester[0];
                    }
                }
                else
                {
                    Console.WriteLine("You made an invalid entry. Try again.");
                }
            }
        } while (i == 2 & gameOver == false);
    }
} while (gameOver == false);

Console.WriteLine("Thanks for playing. Hopefully you found no bugs in our code.");
Console.WriteLine("If you DID find bugs, just pretend that you didn't. It won't hurt, we promise ;)");