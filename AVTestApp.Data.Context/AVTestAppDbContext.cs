using AVTestApp.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Context
{
    public class AVTestAppDbContext : IDbContext
    {
        DbContext _efDbContext;

        public AVTestAppDbContext(EntityFramework.AVTestAppEntities efDbContext)
        {
            _efDbContext = efDbContext;
        }

        public void Dispose()
        {
            _efDbContext.Dispose();
        }

        public int SaveChanges()
        {
            return _efDbContext.SaveChanges();
        }

        public IDbSet<T> Set<T>() where T : class
        {
            return _efDbContext.Set<T>();
        }
    }
}
