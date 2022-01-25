using Games_Storage_App.Models;
using Games_Storage_App.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Contollers
{
    public class HomeController : Controller
    {
        private readonly GameService gameService;

        public HomeController(GameService gameService)
        {
            this.gameService = gameService;
        }

        public IActionResult Index()
        {
            var games = gameService.GetAllGames();
            return View(games);
        }
    }
}
