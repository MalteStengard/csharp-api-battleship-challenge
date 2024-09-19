namespace exercise.wwwapi.Models.Tile
{
    public class Tile
    {
        public int xValue { get; set; }
        public int yValue { get; set; }

        public Tile(int x, int y)
        {
            xValue = x;
            yValue = y;
            isHit = false;

        }

        public bool isHit { get; set; }
        public bool containsShip { get; set; }

        //public bool hasTileAbove { get; set; }
        //public bool hasTileBelow { get; set; }
        //public bool hasTileRight { get; set; }
        //public bool hasTileLeft { get; set; }
    }
}
