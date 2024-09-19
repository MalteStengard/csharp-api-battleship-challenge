
using exercise.wwwapi.Data;
using exercise.wwwapi.Models.Game;
using Microsoft.EntityFrameworkCore;

namespace exercise.wwwapi.Repositoy
{
    public class Repository : IRepository
    {
        private DataContext _db;
        public Repository(DataContext context)
        {
            _db = context;
        }

        public List<Game> GetGames()
        {
            return _db.Games.ToList();
        }

        public Task ResetGame()
        {
            throw new NotImplementedException();
        }

        public bool Shoot(int x, string y)
        {
            throw new NotImplementedException();
        }

        public bool StartGame(int size)
        {
            _db.Games.Add(new Game() { boardOneId = 1, boardTwoId = 2 });
            _db.SaveChanges();
            return true;
        }
    }
}
