using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Models
{
    public class GameWithAllGenresViewModel
    {
        public List<GenreViewModel> Genres { get; set; }
        public GameViewModel Game { get; set; }
    }
}
