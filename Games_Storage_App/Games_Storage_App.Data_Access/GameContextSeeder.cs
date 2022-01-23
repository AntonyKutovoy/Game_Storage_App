using System.Linq;

namespace Games_Storage_App.Data_Access
{
    public static class GameContextSeeder
    {
        public static void Seed(GameContext context)
        {
            if (!context.Games.Any())
            {
                context.Games.AddRange(SampleData.GetDefaultGames());
                context.SaveChanges();
            }
        }
    }
}
