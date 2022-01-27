using Games_Storage_App.Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Games_Storage_App.Data_Access
{
    public class GameDbRepository : IGameRepository
    {
        private readonly GameStorageAppContext gameStorageAppContext;

        public GameDbRepository(GameStorageAppContext gameStorageAppContext)
        {
            this.gameStorageAppContext = gameStorageAppContext;
        }
        public Game TryGetById(Guid id)
        {
            var allGames = GetAll();
            return allGames.FirstOrDefault(g => g.Id == id);
        }

        public List<Game> GetAll()
        {
            return gameStorageAppContext.Games.AsNoTracking().Include(c => c.GameGenres).ThenInclude(p => p.Genre).ToList();
        }

        public Game Create(Game gameInfo)
        {
            var game = new Game { Name = gameInfo.Name, Developer = gameInfo.Developer };
            gameStorageAppContext.Games.Add(game);
            gameStorageAppContext.SaveChanges();
            return game;
        }

        public Game AddGenre(Guid id, Genre genre)
        {
            var game = gameStorageAppContext.Games.FirstOrDefault(x => x.Id == id);
            var existingGameGenre = game.GameGenres.FirstOrDefault(x => x.GenreId == genre.Id);
            if (existingGameGenre == null)
            {
                game.GameGenres.Add(new GameGenre { Game = game, Genre = genre, Id = Guid.NewGuid() });
            }
            gameStorageAppContext.SaveChanges();
            return game;
        }

        public void Delete(Guid id)
        {
            gameStorageAppContext.Games.Remove(TryGetById(id));
            gameStorageAppContext.SaveChanges();
        }

        public void Update(Game gameInfo)
        {
            var game = gameStorageAppContext.Games.FirstOrDefault(x => x.Id == gameInfo.Id);
            if (gameInfo.Name != null)
                game.Name = gameInfo.Name;
            if (gameInfo.Developer != null)
                game.Developer = gameInfo.Developer;
            gameStorageAppContext.SaveChanges();
        }

        public void DeleteGenre(Game existingGame, Genre genre)
        {
            var removedGenre = gameStorageAppContext.Genres.Include(s => s.GameGenres).FirstOrDefault(s => s.Id == genre.Id);
            var game = gameStorageAppContext.Games.FirstOrDefault(x => x.Id == existingGame.Id);
            var gameGenre = removedGenre.GameGenres.FirstOrDefault(sc => sc.GameId == existingGame.Id);
            removedGenre.GameGenres.Remove(gameGenre);
            gameStorageAppContext.SaveChanges();
        }
    }
}
