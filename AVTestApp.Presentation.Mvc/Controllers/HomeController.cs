using AVTestApp.Business.Model.Services.Interfaces;
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

        public HomeController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public ActionResult Index()
        {
            ViewBag.Orders = orderService.ForShipment();
            return View();
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
    }
}