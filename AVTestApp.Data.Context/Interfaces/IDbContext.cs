using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Model.Interfaces
{
    public interface IDbContext
    {
        /// <summary>
        /// Get DbSet
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IDbSet<T> Set<T>() where T : class;

        /// <summary>
        /// Save changes to DB
        /// </summary>
        /// <returns></returns>
        int SaveChanges();
    }
}
