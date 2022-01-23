using Games_Storage_App.Data_Access.Models;
using System;

namespace Games_Storage_App.Data_Access
{
    public class GameGenre
    {
        public Guid Id { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
    }
}