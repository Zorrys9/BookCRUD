using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBooks.Data.Repository
{
    public interface IBaseRepository<T>
    {

        IQueryable<T> GetQuery();

        T Insert(T entity);

        T Update(T entity);

        void Delete(T entity);

    }
}
