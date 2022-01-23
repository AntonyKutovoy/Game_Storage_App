using Games_Storage_App.Models;
using System.Linq;

namespace Games_Storage_App
{
    public class SampleData
    {
        public static void Initialize(GameContext context)
        {
            if (!context.Games.Any())
            {
                context.Games.AddRange(
                    new Game
                    {
                        Name = "Divinity: Original Sin 2",
                        Developer = "Larian Studios",
                        Genres = "CRPG"
                    },
                    new Game
                    {
                        Name = "Half-Life 2",
                        Developer = "Valve",
                        Genres = "First-person shooter"
                    },
                    new Game
                    {
                        Name = "Dishonored",
                        Developer = "Arkane Studios",
                        Genres = "Action-adventure, stealth"
                    },
                    new Game
                    {
                        Name = "The Witcher 3: Wild Hunt",
                        Developer = "CD Projekt Red",
                        Genres = "Action RPG"
                    },
                    new Game
                    {
                        Name = "Pathfinder: Wrath of the Righteous",
                        Developer = "Owlcat Games",
                        Genres = "RPG"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
