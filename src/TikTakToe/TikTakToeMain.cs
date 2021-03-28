using System;

namespace TikTakToe
{
    class TikTakToeMain
    {
        static void Main(string[] args)
        {

            var newGame = new Game();
            newGame.GameBoard.printBoard();
            newGame.playerTakeTurn();
            newGame.GameBoard.printBoard();

            }
        }
    }
