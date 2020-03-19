using Autofac;
using AVTestApp.Data.Context;
using AVTestApp.Data.Context.EntityFramework;
using AVTestApp.Data.Context.Interfaces;
using AVTestApp.Data.Context.Repositories;
using AVTestApp.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Infrastructure.IoC
{
    public class DALIoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AVTestAppEntities>().AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<AVTestAppDbContext>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<RepositoryFactory>().As<IRepositoryFactory>().InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
        }
    }
}
