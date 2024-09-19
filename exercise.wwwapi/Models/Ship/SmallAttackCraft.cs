namespace exercise.wwwapi.Models.Ship
{
    public class SmallAttackCraft : IShip
    {
        public int size = 2;
        public string type { get; set; }
        public bool isSunk { get; set; }

        public List<Tile.Tile> tilesOccupied = new List<Tile.Tile>();

        //public int GetSize()
        //{
            
        //}

        //public bool IsSunk()
        //{
        //    throw new NotImplementedException();
        //}

        //string IShip.GetType()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
