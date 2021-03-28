namespace TikTakToe
{
    public class Square
    {
        public char State
        { get; set; }
        public string Position
        { get; set; }
        public Square()
        {
            State = 'b';
        }
        public char printState()
        {
            if (this.State == 'b')
            {
                return '_';
            }
            else
            {
                return this.State;
            }
        }
    }
}