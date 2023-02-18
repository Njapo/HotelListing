using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace HotelListing.IRepository
{
    public interface IGenericRepository<T> where T :class
    {
        Task<IList<T>> GetAll(
            Expression<Func<T,bool>> expression=null,
            Func<IQueryable<T>,IOrderedQueryable<T>> OrderBy=null,
            List<string> includes=null
            );
        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);

        Task Insert(T entity);
        Task InsertRange(IEnumerable<T> enteties);

        Task Delete(int id);

        void DeleteRange(IEnumerable<T> enteties);

        void Update(T entity);
    }
}
