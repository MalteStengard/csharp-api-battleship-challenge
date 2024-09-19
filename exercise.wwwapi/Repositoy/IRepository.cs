using exercise.wwwapi.Models.Game;

namespace exercise.wwwapi.Repositoy
{
    public interface IRepository
    {
        bool StartGame(int size);
        bool Shoot(int x, string y);
        Task ResetGame();
        List<Game> GetGames();
    }
}
