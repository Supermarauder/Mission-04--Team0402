using Mission_04__Team0402;
Supporting s = new Supporting();

// create variables for do while and a counter to see who's turn it is.
// If i = 1, then player 1's turn. if 2, player 2
bool gameOver = false; 
int i = 1;
//initiate array to pass to supporting class
string[] board = new string[9] {"", "", "", "", "", "", "", "", ""}; 

// initiate variables for player1 and player2 moves
string player1Move = ""; 
string player2Move = "";

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
        Console.WriteLine("Here is the board:");
        Console.WriteLine("USE METHOD TO PRINT THE BOARD HERE");
        Console.WriteLine("Instructions:");
        Console.WriteLine("Type Q to go in the UPPER LEFT position. Type W to go in the UPPER MIDDLE position. Type E to go in the UPPER RIGHT position");
        Console.WriteLine("Type A to go in the MIDDLE LEFT position. Type S to go in the MIDDLE MIDDLE position. Type D to go in the MIDDLE RIGHT position");
        Console.WriteLine("Type Z to go in the BOTTOM LEFT position. Type X to go in the BOTTOM MIDDLE position. Type C to go in the BOTTOM RIGHT position");
        Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
        
        //run function of checking a winner
        s.determineWinner(board);

        //receive the input for their turn
        player1Move = Console.ReadLine();

        //decipher the user input
        if (player1Move == 'q')
        {
            position = 0;
            if board[position] = ""
            {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            Console.WriteLine("USE METHOD TO PRINT THE BOARD HERE");
            Console.WriteLine("Instructions:");
            Console.WriteLine("Type Q to go in the UPPER LEFT position. Type W to go in the UPPER MIDDLE position. Type E to go in the UPPER RIGHT position");
            Console.WriteLine("Type A to go in the MIDDLE LEFT position. Type S to go in the MIDDLE MIDDLE position. Type D to go in the MIDDLE RIGHT position");
            Console.WriteLine("Type Z to go in the BOTTOM LEFT position. Type X to go in the BOTTOM MIDDLE position. Type C to go in the BOTTOM RIGHT position");
            Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
            player1Move = Console.ReadLine();
        }
    } while (i == 1);

    // player 2's turn
    do
    {
        // give basic instructions everytime their turn starts
        Console.WriteLine("Here is the board:");
        Console.WriteLine("USE METHOD TO PRINT THE BOARD HERE");
        Console.WriteLine("Instructions:");
        Console.WriteLine("Type Q to go in the UPPER LEFT position. Type W to go in the UPPER MIDDLE position. Type E to go in the UPPER RIGHT position");
        Console.WriteLine("Type A to go in the MIDDLE LEFT position. Type S to go in the MIDDLE MIDDLE position. Type D to go in the MIDDLE RIGHT position");
        Console.WriteLine("Type Z to go in the BOTTOM LEFT position. Type X to go in the BOTTOM MIDDLE position. Type C to go in the BOTTOM RIGHT position");
        Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");

        //run function of checking a winner
        s.determineWinner(board);

        //receive the input for their turn
        player2Move = Console.ReadLine();

        //decipher the user input
        if (player2Move == 'q')
        {
            position = 0;
            if board[position] = ""
            {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            if board[position] = ""
                {
                board[position] = "X";
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
            Console.WriteLine("USE METHOD TO PRINT THE BOARD HERE");
            Console.WriteLine("Instructions:");
            Console.WriteLine("Type Q to go in the UPPER LEFT position. Type W to go in the UPPER MIDDLE position. Type E to go in the UPPER RIGHT position");
            Console.WriteLine("Type A to go in the MIDDLE LEFT position. Type S to go in the MIDDLE MIDDLE position. Type D to go in the MIDDLE RIGHT position");
            Console.WriteLine("Type Z to go in the BOTTOM LEFT position. Type X to go in the BOTTOM MIDDLE position. Type C to go in the BOTTOM RIGHT position");
            Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
            player2Move = Console.ReadLine();
        }
    } while (i == 2);

} while (gameOver == false);