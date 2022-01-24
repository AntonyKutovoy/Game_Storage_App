using System;
using System.Collections.Generic;
using System.Text;

namespace Games_Storage_App.Data_Access
{
    public interface IGameRepository
    {
        List<Game> GetAll();
        Game Get(Guid id);
        void Create(Game game);
        void Delete(Guid id);
    }
}
