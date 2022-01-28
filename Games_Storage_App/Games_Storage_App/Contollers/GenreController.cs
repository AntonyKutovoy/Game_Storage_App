using Games_Storage_App.Models;
using Games_Storage_App.Services;
using Microsoft.AspNetCore.Mvc;
using System;

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

        public IActionResult DeleteGenre(Guid genreId)
        {
            genreService.DeleteGenre(genreId);
            return RedirectToAction("GetGenres");
        }

        public IActionResult AddGenre()
        {
            return View(new GenreViewModel {});
        }

        [HttpPost]
        public IActionResult AddGenre(GenreViewModel genre)
        {
            genreService.AddGenre(genre);
            return RedirectToAction("GetGenres");
        }
    }
}
