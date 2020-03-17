using AVTestApp.Business.Model.DTO;
using AVTestApp.Data.Context.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Business.Model.Services.Interfaces
{
    public interface IOrderService
    {
        /// <summary>
        /// Get list of orders ready for groupping for shipment
        /// </summary>
        /// <returns></returns>
        IList<OrderDTO> ForShipment();
    }
}
