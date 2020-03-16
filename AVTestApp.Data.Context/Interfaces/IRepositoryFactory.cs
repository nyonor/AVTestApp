using AVTestApp.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Context.Interfaces
{
    public interface IRepositoryFactory
    {
        IRepository<TEntity> Create<TEntity>(IDbContext dbContext) where TEntity : class;
    }
}
