using Games_Storage_App.Models;
using Games_Storage_App.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Games_Storage_App.Contollers
{
    public class GameController : Controller
    {
        private readonly GameService gameService;
        private readonly GenreService genreService;

        public GameController(GameService gameService, GenreService genreService)
        {
            this.gameService = gameService;
            this.genreService = genreService;
        }
        public IActionResult GetGames()
        {
            var games = gameService.GetAllGames();
            return View(games);
        }
        public IActionResult GetGame(Guid id)
        {
            return View(gameService.GetGame(id));
        }

        public IActionResult ChangeInformation(Guid id)
        {
            return View(gameService.GetGame(id));
        }

        [HttpPost]
        public IActionResult ChangeInformation(GameViewModel game)
        {
            gameService.UpdateInfo(game);
            return RedirectToAction("GetGame", new { id = game.Id });
        }

        public IActionResult UpdateGenres(Guid id)
        {
            return View(new GameWithAllGenresViewModel() { Genres = genreService.GetAllGenres(), Game = gameService.GetGame(id) });
        }

        public IActionResult DeleteGameGenre(Guid gameGenreId, Guid gameId)
        {
            gameService.DeleteGenre(gameGenreId, gameId);
            return RedirectToAction("GetGame", new { id = gameId });
        }

        public IActionResult AddGenreToGame(Guid genreId, Guid gameId)
        {
            gameService.AddGenreToGame(genreService.GetGenre(genreId), gameService.GetGame(gameId));
            return RedirectToAction("GetGame", new { id = gameId });
        }

        public IActionResult DeleteGame(Guid id)
        {
            gameService.DeleteGame(id);
            return RedirectToAction("GetGames");
        }

        public IActionResult AddGame()
        {
            return View(new GameWithAllGenresViewModel { Genres = genreService.GetAllGenres() });
        }

        [HttpPost]
        public IActionResult AddGame(GameViewModel game, Guid genreid)
        {
            return RedirectToAction("GetGame", new { id = gameService.AddGenreToGame(genreService.GetGenre(genreid), game).Id } );
        }
    }
}
