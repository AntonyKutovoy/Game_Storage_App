using System;

namespace Games_Storage_App.Data_Access
{
    public class Game
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public string Genres { get; set; }
    }
}
