using System;
using System.Collections.Generic;
using System.Linq;
using MeetCodes.Data.InterFace;
using Microsoft.EntityFrameworkCore;

namespace MeetCodes.Data.Repository
{
    public abstract class GenericRepository<TC,T> : IGenericRepository<T> 
        where T :class where TC:DbContext
    {
        protected TC Context;
        protected GenericRepository(TC context)
        {
            Context = context;
        }

       

        public virtual void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public virtual T GetBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).First();
        }

        public virtual IEnumerable<T> GetTablEnumerable()
        {
            return Context.Set<T>();
        }

        public virtual void Insert(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }

        public IQueryable<T> GetAllQueryable()
        {
            return Context.Set<T>();
        }


        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

         
    }
}
