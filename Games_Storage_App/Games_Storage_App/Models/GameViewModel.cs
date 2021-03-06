using System;
using System.Collections.Generic;

namespace Games_Storage_App.Models
{
    public class GameViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public List<GameGenreViewModel> Genres { get; set; } = new List<GameGenreViewModel>();
    }
}
