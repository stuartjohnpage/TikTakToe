namespace TikTakToe 
{
    public class Board
    {
        private Square[] boardArray = new Square[9];

        public Square[] BoardArray
        {get;set;}
        
        
        public Board()

        {
            BoardArray = boardArray;

            string[] positions = new string[]{
                "Top Left","Top Middle","Top Right",
                "Middle Left","Middle Middle","Middle Right",
                "Bottom Left","Bottom Middle","Bottom Right"
            };

            for(int i = 0; i < 9; i++){
                this.boardArray[i] = new Square();
                this.boardArray[i].Position = positions[i];
            }
        }
        public void updateGameBoard(string playerChoice){
            foreach(Square square in this.BoardArray){
                if(square.Position.Equals(playerChoice)){
                    square.State = 'X';
                }
            }
        }

        public void printBoard()
        {
            System.Console.WriteLine($"{this.boardArray[0].printState()} | {this.boardArray[1].printState()} | {this.boardArray[2].printState()}");
            System.Console.WriteLine("__________");
            System.Console.WriteLine($"{this.boardArray[3].printState()} | {this.boardArray[4].printState()} | {this.boardArray[5].printState()}");
            System.Console.WriteLine("__________");
            System.Console.WriteLine($"{this.boardArray[6].printState()} | {this.boardArray[7].printState()} | {this.boardArray[8].printState()}");
        }
    }
}