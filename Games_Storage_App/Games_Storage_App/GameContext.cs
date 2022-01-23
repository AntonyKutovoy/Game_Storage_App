using Games_Storage_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Games_Storage_App
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
