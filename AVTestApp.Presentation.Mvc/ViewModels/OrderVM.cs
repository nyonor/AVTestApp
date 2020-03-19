using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AVTestApp.Presentation.Mvc.ViewModels
{
    public class OrdersVM
    {
        public string FulfilmentJson { get; set; }

        public List<OrderItem> OrdersToShipment { get; set; }

        public class OrderItem
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
        }
    }
}