using System;
using System.Collections.Generic;
using System.Text;

namespace Games_Storage_App.Data_Access
{
    public class GenreDbRepository : IGenreRepository
    {
        private readonly GameStorageAppContext gameContext;

        public GenreDbRepository(GameStorageAppContext gameContext)
        {
            this.gameContext = gameContext;
        }
    }
}
