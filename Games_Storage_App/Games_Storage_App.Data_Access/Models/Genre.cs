using System;
using System.Collections.Generic;
using System.Text;

namespace Games_Storage_App.Data_Access.Models
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<GameGenre> GameGenres { get; set; }
        public Genre()
        {
            GameGenres = new List<GameGenre>();
        }
    }
}
