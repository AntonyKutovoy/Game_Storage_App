using System.Collections.Generic;

namespace Games_Storage_App.Models
{
    public class GameWithAllGenresViewModel
    {
        public List<GenreViewModel> Genres { get; set; }
        public GameViewModel Game { get; set; }
    }
}
