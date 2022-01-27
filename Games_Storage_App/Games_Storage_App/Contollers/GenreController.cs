using Games_Storage_App.Models;
using Games_Storage_App.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Contollers
{
    public class GenreController : Controller
    {
        private readonly GenreService genreService;

        public GenreController(GenreService genreService)
        {
            this.genreService = genreService;
        }

        public IActionResult GetGenres()
        {
            return View(genreService.GetAllGenres());
        }

        public IActionResult ChangeInformation(Guid genreId)
        {
            return View(genreService.GetGenre(genreId));
        }

        [HttpPost]
        public IActionResult ChangeInformation(GenreViewModel genre)
        {
            genreService.UpdateInfo(genre);
            return RedirectToAction("GetGenres");
        }
    }
}
