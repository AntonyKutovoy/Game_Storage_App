using Games_Storage_App.Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Services
{
    public class GameService
    {
        private readonly IGameRepository gameRepository;

        public GameService(IGameRepository gameRepository)
        {
            this.gameRepository = gameRepository;
        }


    }
}
