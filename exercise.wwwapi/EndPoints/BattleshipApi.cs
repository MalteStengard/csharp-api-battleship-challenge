
using exercise.wwwapi.Repositoy;

namespace exercise.wwwapi.EndPoints
{
    public static class BattleshipApi
    {
        public static void ConfigureBattleshipApi(this WebApplication app)
        {
            var board = app.MapGroup("board");
            board.MapGet("/start", StartGame);
            board.MapGet("/reset", ResetGame);
        }

        private static async Task<IResult> StartGame(IRepository service)
        {
            try
            {
                var result = service.GetGames();
                return TypedResults.Ok();

            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex);
            }
        }

        private static async Task<IResult> ResetGame(IRepository service)
        {
            throw new NotImplementedException();

            try
            {

            }
            catch (Exception ex)
            {

                return TypedResults.BadRequest(ex);
            }
        }
    }
}
