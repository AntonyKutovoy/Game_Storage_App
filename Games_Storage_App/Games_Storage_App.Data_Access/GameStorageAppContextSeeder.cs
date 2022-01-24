using System.Linq;

namespace Games_Storage_App.Data_Access
{
    public static class GameStorageAppContextSeeder
    {
        public static void Seed(GameStorageAppContext context)
        {
            if (!context.Games.Any())
            {
                context.Games.AddRange(SampleData.GetDefaultGamesWithGenres());
                context.SaveChanges();
            }
        }
    }
}
