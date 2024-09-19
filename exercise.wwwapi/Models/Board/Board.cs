using exercise.wwwapi.Models.Ship;

namespace exercise.wwwapi.Models.Board
{
    public class Board
    {
        public int Id { get; set; }
        public List<IShip> ships { get; set; }

    }
}
