using System;

namespace TikTakToe
{
    class TikTakToeMain
    {
        static void Main(string[] args)
        {
            var newGame = new Game();
            bool gameWon = false;
            while(!gameWon)
            {
            //start game loop
            newGame.GameBoard.printBoard();
            newGame.displayFreeSpaces();
            newGame.getPlayerInput();
            newGame.GameBoard.printBoard();
            newGame.computerTakeTurn();
            newGame.isGameWon();
            //end game loop
            }
        }
    }
}
