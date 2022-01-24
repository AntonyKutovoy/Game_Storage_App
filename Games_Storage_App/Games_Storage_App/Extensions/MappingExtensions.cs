using Games_Storage_App.Data_Access;
using Games_Storage_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games_Storage_App.Extensions
{
    public static class MappingExtensions
    {
        public static GameViewModel ToGameViewModel(this Game game)
        {
            return new GameViewModel()
            {
                Id = game.Id,
                Name = game.Name,
                Developer = game.Developer
            };
        }
    }
}
