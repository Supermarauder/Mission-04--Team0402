using TicTacToeMethods;
TicTacToeTools tttt = new TicTacToeTools(); 
// create variables for do while and a counter to see who's turn it is.
// If i = odd number, then player 1's turn. if even, player 2
bool gameOver = false; 
int i = 1; 
// initiate variables for player1 and player2 moves
string player1Move = ""; 
string player2Move = ""; 
Console.WriteLine("Welcome to Tic Tac Toe!"); 
Console.WriteLine("This game is for two players. What is player 1's name?"); 
string player1 = Console.ReadLine(); Console.WriteLine("What is Player 2's name?"); 
string player2 = Console.ReadLine(); Console.WriteLine(player1 + " is X's and " + player2 + " is O's. " + player1 + " will go first."); 
Console.WriteLine("Here is the board:"); Console.WriteLine("USE METHOD TO PRINT THE BOARD HERE"); 
Console.WriteLine("Instructions:"); 
Console.WriteLine("Type Q to go in the UPPER LEFT position. Type W to go in the UPPER MIDDLE position. Type E to go in the UPPER RIGHT position"); 
Console.WriteLine("Type A to go in the MIDDLE LEFT position. Type S to go in the MIDDLE MIDDLE position. Type D to go in the MIDDLE RIGHT position"); 
Console.WriteLine("Type Z to go in the BOTTOM LEFT position. Type X to go in the BOTTOM MIDDLE position. Type C to go in the BOTTOM RIGHT position"); 
Console.WriteLine("Any other entry will cause the board and these instructions to be printed again."); 

do 
{ 
    Console.WriteLine("Here is the board:"); 
    Console.WriteLine("USE METHOD TO PRINT THE BOARD HERE"); 
    Console.WriteLine("Instructions:"); 
    Console.WriteLine("Type Q to go in the UPPER LEFT position. Type W to go in the UPPER MIDDLE position. Type E to go in the UPPER RIGHT position"); 
    Console.WriteLine("Type A to go in the MIDDLE LEFT position. Type S to go in the MIDDLE MIDDLE position. Type D to go in the MIDDLE RIGHT position"); 
    Console.WriteLine("Type Z to go in the BOTTOM LEFT position. Type X to go in the BOTTOM MIDDLE position. Type C to go in the BOTTOM RIGHT position"); 
    Console.WriteLine("Any other entry will cause the board and these instructions to be printed again."); 
    player1Move = Console.ReadLine(); 
    while (player1Move.Length != 1) 
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

} while (gameOver == false);