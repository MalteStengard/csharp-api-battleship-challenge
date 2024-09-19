using exercise.wwwapi.Models.Board;
using exercise.wwwapi.Models.Game;
using exercise.wwwapi.Models.Tile;
using Microsoft.EntityFrameworkCore;

namespace exercise.wwwapi.Data
{
    public class DataContext : DbContext
    {
        private string _connectionString;
        public DataContext()
        {
            var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            _connectionString = configuration.GetValue<string>("ConnectionStrings:DefaultConnectionString")!;


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase(databaseName: "Database");
            optionsBuilder.UseNpgsql(_connectionString);
        }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Tile> Tiles { get; set; }
    }
}
