using TicTacToeMethods;
TicTacToeTools tttt = new TicTacToeTools(); 


// create variables for do while and a counter to see who's turn it is.
// If i = 1, then player 1's turn. if 2, player 2
bool gameOver = false; 
int i = 1;

// if totalMoveCounter = 9, then 9 valid moves are made. if there is no winner, then its a tie game
int totalMoveCounter = 0;


// initiate variables for player1 and player2 moves
string player1Move = ""; 
string player2Move = "";

// initiate winner variable
string winner = "";

Console.WriteLine("Welcome to Tic Tac Toe!"); 
Console.WriteLine("This game is for two players. What is player 1's name?"); 
string player1 = Console.ReadLine(); Console.WriteLine("What is Player 2's name?"); 
string player2 = Console.ReadLine(); Console.WriteLine(player1 + " is X's and " + player2 + " is O's. " + player1 + " will go first."); 

do
{

    // player 1's turn
    do
    {
        /*check to see if there is a winner USE METHOD FOR THIS
        * if CheckWinnerMethod = player1;
        *      winner = player1
        *      gameOver = true
        *      
        *      Console.WriteLine(winner + " got 3 in a row! They Win!")
        * 
        *      if CheckWinnerMEthod = false (false is arbitrary. it could be anything as long as there is no winner) AND totalMoveCounter = 9;
        *      console.writeline("Cat's game! no one wins")
        *
        *
        */

        // give basic instructions everytime their turn starts
        Console.WriteLine("Here is the board:");
        Console.WriteLine("USE METHOD TO PRINT THE BOARD HERE");
        Console.WriteLine("Instructions:");
        Console.WriteLine("Type Q to go in the UPPER LEFT position. Type W to go in the UPPER MIDDLE position. Type E to go in the UPPER RIGHT position");
        Console.WriteLine("Type A to go in the MIDDLE LEFT position. Type S to go in the MIDDLE MIDDLE position. Type D to go in the MIDDLE RIGHT position");
        Console.WriteLine("Type Z to go in the BOTTOM LEFT position. Type X to go in the BOTTOM MIDDLE position. Type C to go in the BOTTOM RIGHT position");
        Console.WriteLine("Any other entry will cause the board and these instructions to be printed again.");
        player1Move = Console.ReadLine();

        //use logic toensure player1's move is valid. First check to see if it is one ofthe appropriate 9 letters,
        //then check to see if that part of the board has already been played on
        //if it has already been played, tell the user to pick a valid spot
        if (player1Move == "q" || player1Move == "w" || player1Move == "e" || player1Move == "a" || player1Move == "s" || 
            player1Move == "d" || player1Move == "z" || player1Move == "x" || player1Move == "c")
        {
            


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

        i++;
        totalMoveCounter++;
    } while (i == 1);

    // player 2's turn

} while (gameOver == false);