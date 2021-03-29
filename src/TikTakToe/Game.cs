using System;

namespace TikTakToe
{
    public class Game
    {
        public Board GameBoard
        {
            get; set;
        }
        public int TurnCount
        {
            get;set;
        }

        public Game()
        {
            this.GameBoard = new Board();
            this.TurnCount = 0;
        }

        public void playerTakeTurn()
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
            this.TurnCount += 1;
        }

        public bool isGameWon(char symbol)
        {
            if(this.TurnCount >= 5){
                
                for(int i = 0; i<3; i++) {
                    //across ways win
                    if(this.GameBoard.BoardArray[i].State.Equals(symbol) && this.GameBoard.BoardArray[i+1].State.Equals(symbol) && this.GameBoard.BoardArray[i+2].State.Equals(symbol) ){
                        if(symbol.Equals('X')) {
                            System.Console.WriteLine("You win! Congratulations! Exiting...");
                        } else {
                            System.Console.WriteLine("You lose :( Exiting...");
                        }
                        return true;
                }   //down ways win
                    else if(this.GameBoard.BoardArray[i].State.Equals(symbol) && this.GameBoard.BoardArray[i+3].State.Equals(symbol) && this.GameBoard.BoardArray[i+6].State.Equals(symbol) ){
                        if(symbol.Equals('X')) {
                            System.Console.WriteLine("You win! Congratulations! Exiting...");
                        } else {
                            System.Console.WriteLine("You lose :( Exiting...");
                        }
                        return true;
                }   
                //diagonals win
                }
                if(this.GameBoard.BoardArray[0].State.Equals(symbol) && this.GameBoard.BoardArray[4].State.Equals(symbol) && this.GameBoard.BoardArray[8].State.Equals(symbol) ){
                    System.Console.WriteLine("You won! Congratulations!");
                    if(symbol.Equals('X')) {
                        System.Console.WriteLine("You win! Congratulations! Exiting...");
                    } else {
                        System.Console.WriteLine("You lose :( Exiting...");
                    }
                    return true;
                }else if(this.GameBoard.BoardArray[2].State.Equals(symbol) && this.GameBoard.BoardArray[4].State.Equals(symbol) && this.GameBoard.BoardArray[6].State.Equals(symbol) ){
                    System.Console.WriteLine("You won! Congratulations!");
                    if(symbol.Equals('X')) {
                        System.Console.WriteLine("You win! Congratulations! Exiting...");
                    } else {
                        System.Console.WriteLine("You lose :( Exiting...");
                    }
                    return true;
                }
                
            }
            return false;
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
            this.TurnCount += 1;
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