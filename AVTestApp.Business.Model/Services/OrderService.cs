using AVTestApp.Business.Model.DTO;
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
        private IUnitOfWork _uow;

        public OrderService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        //public void Dispose()
        //{
        //    _uow.Dispose();
        //}

        IList<OrderDTO> IOrderService.ForShipment()
        {
            return _uow.TestOrdersRepository.Entities.Select(e => new OrderDTO() { Id = e.id }).ToList();
        }
    }
}
