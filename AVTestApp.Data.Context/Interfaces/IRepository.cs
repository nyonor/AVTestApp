using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Data.Model.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Get all entities
        /// </summary>
        IQueryable<TEntity> Entities { get; }

        /// <summary>
        /// Remove entity
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);

        /// <summary>
        /// Add entity
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);
    }
}
