using Games_Storage_App.Data_Access;
using Games_Storage_App.Data_Access.Models;
using Games_Storage_App.Models;
using System.Collections.Generic;

namespace Games_Storage_App.Extensions
{
    public static class MappingExtensions
    {
        public static GameViewModel ToGameViewModel(this Game game)
        {
            return new GameViewModel()
            {
                Id = game.Id,
                Name = game.Name,
                Developer = game.Developer,
                Genres = game.GameGenres.ToGameGenresViewModel()
            };
        }

        public static List<GameGenreViewModel> ToGameGenresViewModel(this List<GameGenre> gameGenres)
        {
            var genres = new List<GameGenreViewModel>();
            foreach (var gameGenre in gameGenres)
            {
                var genre = gameGenre.ToGameGenreViewModel();
                genres.Add(genre);
            }
            return genres;
        }

        public static GameGenreViewModel ToGameGenreViewModel(this GameGenre gameGenre)
        {
            return new GameGenreViewModel
            {
                Id = gameGenre.Id,
                Genre = gameGenre.Genre.ToGenreViewModel()
            };
        }
        public static GenreViewModel ToGenreViewModel(this Genre genre)
        {
            return new GenreViewModel()
            {
                Id = genre.Id,
                Name = genre.Name
            };
        }

        public static Genre ToGenre(this GenreViewModel genreViewModel)
        {
            return new Genre()
            {
                Id = genreViewModel.Id,
                Name = genreViewModel.Name
            };
        }

        public static Game ToGameInfo(this GameViewModel gameViewModel)
        {
            return new Game()
            {
                Id = gameViewModel.Id,
                Name = gameViewModel.Name,
                Developer = gameViewModel.Developer
            };
        }
    }
}
