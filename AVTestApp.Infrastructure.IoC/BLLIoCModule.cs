using Autofac;
using AVTestApp.Business.Model.Services;
using AVTestApp.Business.Model.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Infrastructure.IoC
{
    public class BLLIoCModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OrderService>().As<IOrderService>().InstancePerLifetimeScope();
        }
    }
}
