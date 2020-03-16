using AVTestApp.Business.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVTestApp.Business.Model.Interfaces
{
    interface IFulfillmentService
    {
        /// <summary>
        /// Group orders and form fulfillment order
        /// </summary>
        /// <param name="orderDTOs"></param>
        /// <returns></returns>
        FulfillmentDTO Create(IList<OrderDTO> orderDTOs);
    }
}
