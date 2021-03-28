namespace TikTakToe
{
    public class Game
    {
        private Board gameBoard = new Board();

        public Board GameBoard
        {
            get;set;
        }

        public Game()
        {
            GameBoard = gameBoard;
        }

    public void playerTakeTurn()
    {
        System.Console.WriteLine("It's your move!");
        getFreeSpaces();
        bool moveNotPicked = true;
        while(moveNotPicked) {
            System.Console.WriteLine("Please enter your move choice:");
            string spaceChoiceString = System.Console.ReadLine();
            switch(spaceChoiceString){
                case "Top Left":
                    GameBoard.updateGameBoard("Top Left");
                    moveNotPicked = false;
                    break;
                case "Top Middle":
                    GameBoard.updateGameBoard("Top Middle");
                    moveNotPicked = false;
                    break;
                case "Top Right":
                    GameBoard.updateGameBoard("Top Right");
                    moveNotPicked = false;
                    break;
                case "Middle Left":
                    GameBoard.updateGameBoard("Middle Left");
                    moveNotPicked = false;
                    break;
                case "Middle Middle":
                    GameBoard.updateGameBoard("Middle Middle");
                    moveNotPicked = false;
                    break;
                case "Middle Right":
                    GameBoard.updateGameBoard("Middle Right");
                    moveNotPicked = false;
                    break;
                case "Bottom Left":
                    GameBoard.updateGameBoard("Bottom Left");
                    moveNotPicked = false;
                    break;
                case "Bottom Middle":
                    GameBoard.updateGameBoard("Bottom Middle");
                    moveNotPicked = false;
                    break;
                case "Bottom Right":
                    GameBoard.updateGameBoard("Bottom Right");
                    moveNotPicked = false;
                    break;
                default:
                System.Console.WriteLine("Please enter a valid choice: ");
                System.Console.WriteLine();
                    break;
            }
        }

    }

    public void computerTakeTurn()
    {

    }

    public void getFreeSpaces()
    {
        System.Console.WriteLine("Spaces available for moves: ");
        foreach(Square square in this.GameBoard.BoardArray){
            if(square.State == 'b'){
                System.Console.WriteLine($"{square.Position} is a free space!");
            }
        }
    }
    }

}