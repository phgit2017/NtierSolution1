using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.TrueMoney.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Presentation.TrueMoney.MVC.Models;

namespace Presentation.TrueMoney.MVC.Controllers
{
    public class HomeController : Controller
    {
        IPortalAdminUserServices _adminServices;

        public HomeController(IPortalAdminUserServices adminServices)
        {
            this._adminServices = adminServices;
        }

        public IActionResult Index()
        {
            var x = _adminServices.GetAllAdminUsers();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
