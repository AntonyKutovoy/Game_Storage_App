using Games_Storage_App.Data_Access;
using Games_Storage_App.Extensions;
using Games_Storage_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Services
{
    public class GameService
    {
        private readonly IGameRepository gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }

        public List<GameViewModel> GetAllGames()
        {
            var games = gameRepository.GetAll();
            var gamesViewModel = new List<GameViewModel>();
            foreach (var game in games)
            {
                var gameViewModel = game.ToGameViewModel();
                gamesViewModel.Add(gameViewModel);
            }
            return gamesViewModel;
        }

        public GameViewModel GetGame(Guid id)
        {
            var game = gameRepository.Get(id);
            var gameViewModel = game.ToGameViewModel();
            return gameViewModel;
        }
    }
}
