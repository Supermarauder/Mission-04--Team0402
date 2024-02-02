using Mission_04__Team0402;
Supporting s = new Supporting();

// create variables for do while and a counter to see who's turn it is.
// If i = 1, then player 1's turn. if 2, player 2
bool gameOver = false; 
int i = 1;
//initiate array to pass to supporting class
string[] asBoard = new string[9] {"", "", "", "", "", "", "", "", ""}; 

// initiate variables for player1 and player2 moves.

// initiate winner variable and position variable
string winner = "";
int position = 10;  //set equal to 10 because 0-8 are used in the program

Console.WriteLine("Welcome to Tic Tac Toe!"); 
Console.WriteLine("This game is for two players. What is player 1's name?"); 
string player1 = Console.ReadLine(); Console.WriteLine("What is Player 2's name?"); 
string player2 = Console.ReadLine(); Console.WriteLine(player1 + " is X's and " + player2 + " is O's. " + player1 + " will go first."); 

do
{

    // player 1's turn
    do
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
        
        //run function of checking a winner
        Console.WriteLine(s.determineWinner(asBoard));


        //receive the input for their turn
        string tester = Console.ReadLine();

            char player1Move = tester[0];

            //decipher the user input
            if (player1Move == 'q')
            {
                position = 0;
                if (asBoard[position] == "")
                {
                    asBoard[position] = "X";
                    //up the i to send to player 2
                    i++;
                }
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
                Console.WriteLine("You made an invalid entry.");
            Console.WriteLine(s.receiveBoard(asBoard));
            Console.WriteLine("Instructions:");
            Console.WriteLine("Q for upper left. W for upper middle. E for upper right.");
            Console.WriteLine("A for middle left. S for middle middle. D for middle right.");
            Console.WriteLine("Z for bottom left. X for bottom middle. C for bottom right.");
            Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
                tester = Console.ReadLine();
                player1Move = tester[0];
            }
    } while (i == 1);

    // player 2's turn
    do
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

        //run function of checking a winner
        Console.WriteLine(s.determineWinner(asBoard));

        //receive the input for their turn
        string tester = Console.ReadLine();
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
            Console.WriteLine("You made an invalid entry.");
            Console.WriteLine(s.receiveBoard(asBoard));
            Console.WriteLine("Instructions:");
            Console.WriteLine("Q for upper left. W for upper middle. E for upper right.");
            Console.WriteLine("A for middle left. S for middle middle. D for middle right.");
            Console.WriteLine("Z for bottom left. X for bottom middle. C for bottom right.");
            Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
            tester = Console.ReadLine();
            player2Move = tester[0];
        }
    } while (i == 2);

} while (gameOver == false);

Console.WriteLine("Test line of code. If this prints, the game has jumped out of the overarching do while loop");
