class TicTacToe
{
    // 2D array to represent the gameboard 
    private string[][] gameboard = new string[3][];
    private string currentPlayer; 

    // constructor 
    public TicTacToe()
    {
        for (int i = 0; i < gameboard.Length; i++)
        {
            gameboard[i] = new string[3];
            for (int j = 0; j < gameboard[i].Length; j++)
                gameboard[i][j] = " ";
        }

        currentPlayer = "X";
    }

    // method to return the current player
    public string getPlayer()
    {
        return currentPlayer;
    }

    // method to display the gameboard
    public void displayGameBoard()
    {
        Console.WriteLine("GameBoard:");
        for (int i = 0; i < gameboard.Length; i++)
        {

            for (int j = 0; j < gameboard[i].Length; j++)
            {
                if (j == gameboard[i].Length - 1)
                    Console.Write(gameboard[i][j]);
                else
                    Console.Write(gameboard[i][j] + " |");

            }
            Console.WriteLine();
            if (i < gameboard.Length - 1)
                Console.WriteLine("---------");

        }

    }

    // method to check for a valid move by the user. (i.e what user enters is not already taken, and is an exsisting space on the board)
    public bool isValidMove(int row, int col)
    {
       
        return (row >= 0 && row < gameboard.Length && col >= 0 && col < gameboard.Length && gameboard[row][col].Equals(" "));
    }

    // method to set the array location (row,col)
    public void userMove(int row, int col)
    {
        gameboard[row][col] = currentPlayer;
    }

    // method that returns true if the game ends in a tie
    // else returns false
    public bool tie()
    {
       
        for (int i = 0; i < gameboard.Length; i++)
        {
           
            for (int j = 0; j < gameboard[i].Length; j++)
            {
                if (gameboard[i][j].Equals(" ")) 
                    return false;
            }
        }

        return true; 
    }

    // method to return true if the current player has won the game
    public bool winner()
    {
        for (int i = 0; i < gameboard.Length; i++)
        {
            if (gameboard[i][0].Equals(gameboard[i][1]) && gameboard[i][0].Equals(gameboard[i][2]) && gameboard[i][0].Equals(currentPlayer))
                return true;
            if (gameboard[0][i].Equals(gameboard[1][i]) && gameboard[0][i].Equals(gameboard[2][i]) && gameboard[0][i].Equals(currentPlayer))
                return true;
        }

        if (gameboard[0][0].Equals(gameboard[1][1]) && gameboard[0][0].Equals(gameboard[2][2]) && gameboard[0][0].Equals(currentPlayer))
            return true;

        if (gameboard[0][2].Equals(gameboard[1][1]) && gameboard[1][1].Equals(gameboard[2][0]) && gameboard[1][1].Equals(currentPlayer))
            return true;

        return false; // player has not won
    }

    // method to change the current player
    public void changePlayer()
    {
        if (currentPlayer.Equals("X"))
            currentPlayer = "O";
        else
            currentPlayer = "X";
    }
} 