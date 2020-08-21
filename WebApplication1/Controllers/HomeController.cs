using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Business.TrueMoney.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.GenericClassImplementation;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        IPortalAdminUserServices _portalAdminUserServices;
        ICommonServices _commonServices;
        public HomeController(
            IPortalAdminUserServices portalAdminUserServices,
            ICommonServices commonServices)
        {
            this._portalAdminUserServices = portalAdminUserServices;
            this._commonServices = commonServices;
        }

        public IActionResult Index()
        {
            //var result = _portalAdminUserServices.GetAllAdminUsers();
            //SampleClass sc = new SampleClass();
            //sc.error = "aaaa";
            //sc.errorssss = "aaaa";
            //sc.errir = 1;


            //foreach (PropertyInfo propertyInfo in typeof(SampleClass).GetProperties())
            //{
            //    if (propertyInfo.CanRead)
            //    {
            //        if (propertyInfo != null)
            //        {
            //            var x = propertyInfo.GetValue(sc);
            //        }
            //    }
            //}


            //GenericImplemClass<SampleClass> gic = new GenericImplemClass<SampleClass>();
            //gic.ValidateData(sc);

            var result = _commonServices.GetAllWalletDetails().FirstOrDefault();

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
