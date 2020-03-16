using AVTestApp.Data.Context.Interfaces;
using AVTestApp.Data.Model.Interfaces;
using AVTestApp.Data.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Context.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository<TEntity> Create<TEntity>(IDbContext dbContext) where TEntity : class
        {
            return new CommonRepository<TEntity>(dbContext);
        }
    }
}
