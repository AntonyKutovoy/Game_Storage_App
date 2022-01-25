using Games_Storage_App.Data_Access;
using Games_Storage_App.Data_Access.Models;
using Games_Storage_App.Extensions;
using Games_Storage_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Services
{
    public class GenreService
    {
        private readonly IGenreRepository genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            this.genreRepository = genreRepository;
        }

        public List<GenreViewModel> GetAllGenres()
        {
            var genres = genreRepository.GetAll();
            var genresViewModel = new List<GenreViewModel>();
            foreach (var genre in genres)
            {
                var genreViewModel = genre.ToGenreViewModel();
                genresViewModel.Add(genreViewModel);
            }
            return genresViewModel;
        }

        public void Create(GenreViewModel genreViewModel)
        {
            genreRepository.Create(genreViewModel.ToGenre());
        }

        public GenreViewModel GetGenre(Guid id)
        {
            var genre = genreRepository.Get(id);
            return genre.ToGenreViewModel();
        }
    }
}
