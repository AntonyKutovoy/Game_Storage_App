using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Games_Storage_App.Data_Access
{
    public class GameDbRepository : IGameRepository
    {
        private readonly GameContext gameContext;

        public GameDbRepository(GameContext gameContext)
        {
            this.gameContext = gameContext;
        }
        public Game Get(Guid id)
        {
            var allGames = GetAll();
            return allGames.FirstOrDefault(p => p.Id == id);
        }

        public List<Game> GetAll()
        {
            return gameContext.Games.AsNoTracking().ToList();
        }

        public void Create(Game game)
        {
            gameContext.Games.Add(game);
            gameContext.SaveChanges();
        }
    }
}
