using Games_Storage_App.Data_Access.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Games_Storage_App.Data_Access
{
    public class GenreDbRepository : IGenreRepository
    {
        private readonly GameStorageAppContext gameStorageAppContext;

        public GenreDbRepository(GameStorageAppContext gameStorageAppContext)
        {
            this.gameStorageAppContext = gameStorageAppContext;
        }

        public void Create (Genre genre)
        {
            gameStorageAppContext.Genres.Add(genre);
            gameStorageAppContext.SaveChanges();
        }

        public Genre Get (Guid id)
        {
            return GetAll().FirstOrDefault(g => g.Id == id);
        }

        public List<Genre> GetAll()
        {
            return gameStorageAppContext.Genres.AsNoTracking().ToList();
        }

        public void Update(Genre genreInfo)
        {
            var genre = gameStorageAppContext.Genres.FirstOrDefault(x => x.Id == genreInfo.Id);
            if (genreInfo.Name != null)
                genre.Name = genreInfo.Name;
            gameStorageAppContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            gameStorageAppContext.Genres.Remove(Get(id));
            gameStorageAppContext.SaveChanges();
        }
    }
}
