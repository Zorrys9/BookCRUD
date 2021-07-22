using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repository.Implementations
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {

        private readonly LibraryContext _context;

        public BaseRepository(LibraryContext context)
        {

            _context = context;

        }

        public IQueryable<T> GetQuery()
        {

            return _context.Set<T>();

        }

        public void Save()
        {

            _context.SaveChanges();

        }

        public T Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            Save();

            return entity;
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            Save();

            return entity;
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            Save();
        }


    }
}
