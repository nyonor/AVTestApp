using AutoMapper;
using AVTestApp.Business.Model.Services.Interfaces;
using AVTestApp.Presentation.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AVTestApp.Presentation.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IOrderService orderService { get; private set; }
        public IMapper mapper { get; private set; }

        public HomeController(IOrderService orderService, IMapper mapper)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }

        public ActionResult Index()
        {
            return View(new OrdersVM()
            {
                OrdersToShipment = mapper.Map<List<OrdersVM.OrderItem>>(orderService.ForShipment().ToList())
            });
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //protected override void Dispose(bool disposing)
        //{
        //    orderService.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}