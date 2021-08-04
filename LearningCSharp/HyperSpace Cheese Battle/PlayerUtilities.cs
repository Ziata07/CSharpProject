/// <summary>
/// This file holds code that store where a player is, (on an up arrow, down arrow, etc) what a player has (a number, an x/y coordinate)
/// and how a player moves.
/// </summary>
namespace HyperspaceCheese
{
    enum PlayerMovement
    {
        arrowUp,
        arrowDown,
        arrowLeft,
        arrowRight,
        win
    }
    class Player
    {   
        public int Number;
        public int X = 0;
        public int Y = 0;
        
        public void Move(int xInput)
        {
            X = xInput;
        }
        public void Move(int xInput, int yInput)
        {
            X = xInput;
            Y = yInput;
        }
    }
}
