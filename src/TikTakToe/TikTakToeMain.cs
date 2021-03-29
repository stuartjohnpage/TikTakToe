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
                newGame.playerTakeTurn();
                newGame.GameBoard.printBoard();
                if(newGame.isGameWon('X')){
                    break;
                }
                newGame.computerTakeTurn();
                gameWon = newGame.isGameWon('O');
            //end game loop
            }
        }
    }
}
