namespace HyperspaceCheese
{/// <summary>
/// Board is made up of Board tiles that will have two properties (a direction & is/isnot Cheese) 
/// w/ a method that checks and returns a true/false on player position
/// </summary>
    
    class BoardTile
    {
        public PlayerMovement Direction;
        public bool IsCheese;
        public BoardTile(PlayerMovement direction, bool isCheese = false)
        {
            Direction = direction;
            IsCheese = isCheese;
        }

        public override bool Equals(object obj)
        {   //if object is null OR object does not equal the obtained object type
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                BoardTile tile = (BoardTile)obj; //cast the BoardTile type to the object
                return this.Direction == tile.Direction && this.IsCheese == tile.IsCheese;
            }
        }
    }
}
