using AutoMapper;
using AVTestApp.Business.Model.DTO;
using AVTestApp.Presentation.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AVTestApp.Presentation.Mvc.Mappings.Order
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDTO, OrdersVM.OrderItem>()
                .ReverseMap();
        }
    }
}