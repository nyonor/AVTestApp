using AVTestApp.Business.Model.Services.Interfaces;
using AVTestApp.Data.Context;
using AVTestApp.Data.Context.EntityFramework;
using AVTestApp.Data.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Business.Model.Services
{
    public class OrderService : IOrderService
    {
        private UnitOfWork _uow;

        public OrderService(UnitOfWork uow)
        {
            _uow = uow;
        }

        public IList<TestOrder> ForShipment()
        {
            return _uow.TestOrdersRepository.Entities.ToList();
        }
    }
}
