using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TicTacToeDriver
{

    static void Main()
    {

        // create a new object of TicTacToe class
        TicTacToe game = new();
        int row;
        int column;

        // loop that continues until the game ends in a tie or a player has won the game
        while (!game. winner() && !game.tie())
        {
            game.displayGameBoard(); 
            Console.WriteLine("Player " + game.getPlayer() + " turn: ");
            Console.Write("Enter row(1-3): ");
            row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter column(1-3): ");
            column = Convert.ToInt32(Console.ReadLine());

            // loop that continues to take input until the player's move is valid
            while (!game.isValidMove(row - 1, column - 1))
            {
                Console.WriteLine("Invalid move. Please re-enter a valid move:");
                Console.Write("Enter row(1-3): ");
                row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter column(1-3): ");
                column = Convert.ToInt32(Console.ReadLine());
            }

            
            game.userMove(row - 1, column - 1);

            // check if player has won the game, exit the loop
            if (game.winner())
                break;
            game.changePlayer(); // change the current player
        }

        
        game.displayGameBoard();
        // display the winner if the game is won
        if (game.winner())
            Console.WriteLine("Congratulations! Player " + game.getPlayer() + " won the game.");
        else // game ends in a tie
            Console.WriteLine("The game has ended in a tie!");

    }
}