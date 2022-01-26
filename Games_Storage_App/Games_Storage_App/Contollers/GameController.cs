using Games_Storage_App.Models;
using Games_Storage_App.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Contollers
{
    public class GameController : Controller
    {
        private readonly GameService gameService;

        public GameController(GameService gameService)
        {
            this.gameService = gameService;
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
            return RedirectToAction("GetGame", new { id = game.Id }); ;
        }

        public IActionResult UpdateGenres(Guid id)
        {
            return View(gameService.GetGame(id));
        }

        public IActionResult DeleteGameGenre(Guid gameGenreId, Guid gameId)
        {
            gameService.DeleteGenre(gameGenreId, gameId);
            return RedirectToAction("GetGame", new { id = gameId }); ;
        }
    }
}
