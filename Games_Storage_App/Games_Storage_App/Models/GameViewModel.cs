using System;

namespace Games_Storage_App.Models
{
    public class GameViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Genres { get; set; }
    }
}
