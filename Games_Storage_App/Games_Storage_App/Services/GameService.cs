using Games_Storage_App.Data_Access;
using Games_Storage_App.Extensions;
using Games_Storage_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void UpdateInfo(GameViewModel game)
        {
            gameRepository.Update(game.ToGameInfo());
        }

        public GameViewModel GetGame(Guid id)
        {
            var game = gameRepository.TryGetById(id);
            var gameViewModel = game.ToGameViewModel();
            return gameViewModel;
        }

        public void DeleteGame(Guid gameId)
        {
            var game = gameRepository.TryGetById(gameId);
            if (game != null)
            {
                gameRepository.Delete(gameId);
            }
        }

        public GameViewModel AddGenreToGame(GenreViewModel genreViewModel, GameViewModel gameViewModel)
        {
            var existingGame = gameRepository.TryGetById(gameViewModel.Id);
            Game game;
            if (existingGame == null)
            {
                game = gameRepository.Create(gameViewModel.ToGameInfo());
                game = gameRepository.AddGenre(game.Id, genreViewModel.ToGenre());
            }
            else
                game = gameRepository.AddGenre(existingGame.Id, genreViewModel.ToGenre());
            var newGameViewModel = new GameViewModel()
            {
                Id = game.Id,
                Name = game.Name,
                Developer = game.Developer,
                Genres = game.GameGenres.ToGameGenresViewModel()
            };
            return newGameViewModel;
        }

        public void DeleteGenre(Guid gameGenreId, Guid gameId)
        {
            var existingGame = gameRepository.TryGetById(gameId);
            var gameGenre = existingGame.GameGenres.FirstOrDefault(x => x.Id == gameGenreId);
            gameRepository.DeleteGenre(existingGame, gameGenre.Genre);
        }

        public List<GameViewModel> SearchByGenre(Guid genreId)
        {
            var allGames = gameRepository.GetAll();
            return (allGames.SelectMany(game => game.GameGenres.Where(gameGenre => gameGenre.GenreId == genreId).Select(gameGenre => game.ToGameViewModel()))).ToList();
        }
    }
}
