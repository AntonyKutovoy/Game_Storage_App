using Games_Storage_App.Data_Access;
using Games_Storage_App.Data_Access.Models;
using System;
using System.Collections.Generic;

namespace Games_Storage_App
{
    public class SampleData
    {
        public static List<Game> GetDefaultGamesWithGenres()
        {
            var games = new List<Game>();
            games.Add(new Game { Name = "Divinity: Original Sin 2", Developer = "Larian Studios", });
            games.Add(new Game { Name = "Half-Life 2", Developer = "Valve" });
            games.Add(new Game { Name = "Dishonored", Developer = "Arkane Studios" });
            games.Add(new Game { Name = "The Witcher 3: Wild Hunt", Developer = "CD Projekt Red" });
            games.Add(new Game { Name = "Metal Gear Solid V: The Phantom Pain", Developer = "Kojima Productions" });
            games.Add(new Game { Name = "Deathloop", Developer = "Arkane Studios" });
            games.Add(new Game { Name = "Uncharted 2: Among Thieves", Developer = "Naughty Dog" });

            var genres = new List<Genre>();
            genres.Add(new Genre { Name = "RPG" });
            genres.Add(new Genre { Name = "Stealth" });
            genres.Add(new Genre { Name = "First-person shooter" });
            genres.Add(new Genre { Name = "Action-adventure" });

            games[0].GameGenres.Add(new GameGenre { Game = games[0], Genre = genres[0], Id = Guid.NewGuid() });
            games[1].GameGenres.Add(new GameGenre { Game = games[1], Genre = genres[2], Id = Guid.NewGuid() });
            games[2].GameGenres.Add(new GameGenre { Game = games[2], Genre = genres[1], Id = Guid.NewGuid() });
            games[2].GameGenres.Add(new GameGenre { Game = games[2], Genre = genres[3], Id = Guid.NewGuid() });
            games[3].GameGenres.Add(new GameGenre { Game = games[3], Genre = genres[0], Id = Guid.NewGuid() });
            games[4].GameGenres.Add(new GameGenre { Game = games[4], Genre = genres[1], Id = Guid.NewGuid() });
            games[5].GameGenres.Add(new GameGenre { Game = games[5], Genre = genres[2], Id = Guid.NewGuid() });
            games[6].GameGenres.Add(new GameGenre { Game = games[6], Genre = genres[3], Id = Guid.NewGuid() });

            return games;
        }
    }
}
