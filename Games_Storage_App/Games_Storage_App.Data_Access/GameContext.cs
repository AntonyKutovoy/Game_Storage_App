using Games_Storage_App.Data_Access;
using Games_Storage_App.Data_Access.Models;
using Microsoft.EntityFrameworkCore;

namespace Games_Storage_App
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public GameContext(DbContextOptions<GameContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<GameGenre>()
            .HasKey(t => new { t.GenreId, t.GameId });

            builder.Entity<GameGenre>()
                .HasOne(sc => sc.Genre)
                .WithMany(s => s.GameGenres)
                .HasForeignKey(sc => sc.GenreId);

            builder.Entity<GameGenre>()
                .HasOne(sc => sc.Game)
                .WithMany(c => c.GameGenres)
                .HasForeignKey(sc => sc.GameId);
        }
    }
}
