using System.Collections.Generic;

namespace TikTakToe 
{
    public class Board
    {
        public Square[] BoardArray
        {get;set;}
        
        public Board()

        {
            this.BoardArray = new Square[9];

            string[] positions = new string[]{
                "Top Left","Top Middle","Top Right",
                "Middle Left","Middle Middle","Middle Right",
                "Bottom Left","Bottom Middle","Bottom Right"
            };

            for(int i = 0; i < 9; i++){
                BoardArray[i] = new Square();
                BoardArray[i].Position = positions[i];
            }
        }
        public void playerMakeMove(string playerChoice){
            foreach(Square square in BoardArray){
                if(square.Position.Equals(playerChoice)){
                    square.State = 'X';
                }
            }
        }
        public void computerMakeMove(string computerChoice){
                foreach(Square square in BoardArray){
                if(square.Position.Equals(computerChoice)){
                    square.State = 'O';
                }
            }
        }

        public void printBoard()
        {
            System.Console.WriteLine($"{BoardArray[0].printState()} | {BoardArray[1].printState()} | {BoardArray[2].printState()}");
            System.Console.WriteLine("__________");
            System.Console.WriteLine($"{BoardArray[3].printState()} | {BoardArray[4].printState()} | {BoardArray[5].printState()}");
            System.Console.WriteLine("__________");
            System.Console.WriteLine($"{BoardArray[6].printState()} | {BoardArray[7].printState()} | {BoardArray[8].printState()}");
        }
//need to keep gameboard state
        public Square[] getBlankSquares() {
            List<Square> blankSquares = new List<Square>();
            foreach(Square square in BoardArray) {
                if(square.State.Equals('b')){
                    blankSquares.Add(square);
                }
            }
            Square[] blankSquareArray = blankSquares.ToArray();
            return blankSquareArray;
        }
    }
}
    