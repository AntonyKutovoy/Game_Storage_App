using System;
using System.Collections.Generic;

namespace Games_Storage_App.Data_Access
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public List<GameGenre> GameGenres { get; set; }
        public Game()
        {
            GameGenres = new List<GameGenre>();
        }
    }
}
