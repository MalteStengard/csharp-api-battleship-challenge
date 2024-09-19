namespace exercise.wwwapi.Models.Ship
{
    public class Cruiser : IShip
    {
        public int size { get; set; }
        public string type { get; set; }
        public bool isSunk { get; set; }

        public List<Tile.Tile> tilesOccupied = new List<Tile.Tile>();


        //public int GetSize()
        //{
        //    throw new NotImplementedException();
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
