namespace TikTakToe {
    public class Square
    {
        private char state;
        private string position;

        public char State
        { get; set;}
        public string Position
        { get; set;}
        public Square()
        {
            State = 'b';
            Position = position;
        }
        public char printState()
        {
            if(this.State == 'b') {
                return '_';
            } else {
                return this.State;
            }
        }
    }
}