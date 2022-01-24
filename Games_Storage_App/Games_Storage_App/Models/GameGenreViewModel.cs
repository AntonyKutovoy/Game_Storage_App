using System;

namespace Games_Storage_App.Models
{
    public class GameGenreViewModel
    {
        public Guid Id { get; set; }
        public GenreViewModel Genre { get; set; }
    }
}