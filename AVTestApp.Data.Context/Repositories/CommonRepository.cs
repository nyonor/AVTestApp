﻿using AVTestApp.Data.Model.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;

namespace AVTestApp.Data.Model.Repositories
{
    public class CommonRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IDbContext dbContext;
        protected IDbSet<TEntity> dbSet;

        public CommonRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> Entities => dbSet.AsQueryable();

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        //public void Dispose()
        //{
        //    dbContext.Dispose();
        //}

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }
    }
}
