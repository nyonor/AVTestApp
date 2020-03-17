using AVTestApp.Data.Context.EntityFramework;
using AVTestApp.Data.Context.Interfaces;
using AVTestApp.Data.Context.Repositories;
using AVTestApp.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContext _dbContext;
        private IRepositoryFactory _repositoryFactory;

        public IRepository<TestCategory> TestCategoryRepository => _repositoryFactory.Create<TestCategory>(_dbContext);
        public IRepository<TestOrderProduct> TestOrderProductsRepository => _repositoryFactory.Create<TestOrderProduct>(_dbContext);
        public IRepository<TestOrder> TestOrdersRepository => _repositoryFactory.Create<TestOrder>(_dbContext);

        public UnitOfWork(IDbContext dbContext, IRepositoryFactory repositoryFactory)
        {
            _dbContext = dbContext;
            _repositoryFactory = repositoryFactory;
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Reject()
        {
            throw new NotImplementedException();
        }
    }
}
