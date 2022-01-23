using Games_Storage_App.Data_Access;
using System.Collections.Generic;

namespace Games_Storage_App
{
    public class SampleData
    {
        public static List<Game> GetDefaultGames()
        {
            var games = new List<Game>();
            games.Add(new Game { 
                Name = "Divinity: Original Sin 2", 
                Developer = "Larian Studios", 
                Genres = "CRPG" });
            games.Add(new Game {
                Name = "Half-Life 2",
                Developer = "Valve",
                Genres = "First-person shooter"
            });
            games.Add(new Game {
                Name = "Dishonored",
                Developer = "Arkane Studios",
                Genres = "Action-adventure, stealth"
            });
            games.Add(new Game {
                Name = "The Witcher 3: Wild Hunt",
                Developer = "CD Projekt Red",
                Genres = "Action RPG"
            });
            games.Add(new Game
            {
                Name = "Pathfinder: Wrath of the Righteous",
                Developer = "Owlcat Games",
                Genres = "RPG"
            });
            return games;
        }
    }
}
