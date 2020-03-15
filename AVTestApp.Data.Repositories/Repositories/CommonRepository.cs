using AVTestApp.Data.Context.Interfaces;
using AVTestApp.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Context.Repositories
{
    public class CommonRepository<T> : IRepository<T> where T : class
    {
        protected IDbContext dbContext;
        protected IDbSet<T> DbSet;

        public CommonRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<T> All => throw new NotImplementedException();

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
