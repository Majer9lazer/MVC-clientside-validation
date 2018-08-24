using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_clientside_validation.Models;

namespace MVC_clientside_validation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult CheckInvoiceNumber()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckInvoiceNumber(InvoiceNumber invoiceNumber)
        {
            ViewBag.Message = "Ну вот и всё , всё прошло успешно. Данное поле валидно";
            return View();
        }

    }
}