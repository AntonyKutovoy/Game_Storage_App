using Games_Storage_App.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games_Storage_App.Data_Access
{
    public interface IGameRepository
    {
        List<Game> GetAll();
        Game TryGetById(Guid id);
        Game Create(Game game);
        Game AddGenre(Guid id, Genre genre);
        void Delete(Guid id);
        void Update(Game game);
        void DeleteGenre(Game game, Genre genre);
    }
}
