using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetCodes.Data.InterFace
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetTablEnumerable();
        TEntity GetBy(System.Linq.Expressions.Expression<Func<TEntity, bool>> predicate);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        void Save();
        IQueryable<TEntity> GetAllQueryable();
    }
}
