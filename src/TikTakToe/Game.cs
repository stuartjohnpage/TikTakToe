using System;

namespace TikTakToe
{
    public class Game
    {
        private Board gameBoard = new Board();

        public Board GameBoard
        {
            get; set;
        }

        public Game()
        {
            GameBoard = gameBoard;
        }

        public void getPlayerInput()
        {
            //you need a display valid choices method
            System.Console.WriteLine("It's your move!");
            bool moveNotPicked = true;
            while (moveNotPicked)
            {
                System.Console.WriteLine("Please enter your move choice:");
                string spaceChoiceString = System.Console.ReadLine();
                switch (spaceChoiceString)
                {
                    case "Top Left":
                        GameBoard.playerMakeMove("Top Left");
                        moveNotPicked = false;
                        break;
                    case "Top Middle":
                        GameBoard.playerMakeMove("Top Middle");
                        moveNotPicked = false;
                        break;
                    case "Top Right":
                        GameBoard.playerMakeMove("Top Right");
                        moveNotPicked = false;
                        break;
                    case "Middle Left":
                        GameBoard.playerMakeMove("Middle Left");
                        moveNotPicked = false;
                        break;
                    case "Middle Middle":
                        GameBoard.playerMakeMove("Middle Middle");
                        moveNotPicked = false;
                        break;
                    case "Middle Right":
                        GameBoard.playerMakeMove("Middle Right");
                        moveNotPicked = false;
                        break;
                    case "Bottom Left":
                        GameBoard.playerMakeMove("Bottom Left");
                        moveNotPicked = false;
                        break;
                    case "Bottom Middle":
                        GameBoard.playerMakeMove("Bottom Middle");
                        moveNotPicked = false;
                        break;
                    case "Bottom Right":
                        GameBoard.playerMakeMove("Bottom Right");
                        moveNotPicked = false;
                        break;
                    default:
                        System.Console.WriteLine("Please enter a valid choice: ");
                        System.Console.WriteLine();
                        break;
                }
            }

        }

        internal void isGameWon()
        {
            throw new NotImplementedException();
        }

        public void computerTakeTurn()
        {
            System.Console.WriteLine("It's the computers turn...");
            System.Console.WriteLine("Computer is thinking...");
            var rand = new Random();
            var possibleChoices = this.GameBoard.getBlankSquares();
            int randomChoiceIndex = rand.Next(possibleChoices.Length);
            String squareChosen = possibleChoices[randomChoiceIndex].Position;
            this.GameBoard.computerMakeMove(squareChosen);
        }

        public void displayFreeSpaces()
        {
            System.Console.WriteLine("Spaces available for moves: ");
            foreach (Square square in this.GameBoard.getBlankSquares())
            {
                System.Console.WriteLine($"{square.Position} is a free space!");

            }
        }
    }

}