using Games_Storage_App.Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Games_Storage_App.Data_Access
{
    public interface IGenreRepository
    {
        List<Genre> GetAll();
        void Create(Genre genre);
        Genre Get(Guid id);
    }
}
