using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.TrueMoney.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("EDC/EDC.svc/Restful")]
    public class EDCLoginController : Controller
    {
        private IPortalAdminUserServices _portalAdminUserServices;

        public EDCLoginController(IPortalAdminUserServices portalAdminUserServices)
        {
            this._portalAdminUserServices = portalAdminUserServices;
        }

        [Route("loginV2")]
        public IActionResult Index()
        {
            var jsonResult = new
            {
                abc = "abc",
                def = "def"
            };

            return Ok(jsonResult);
        }
    }
}