using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.TrueMoney.Core.Interface;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.BillsPayImplementation.Interface;
using WebApplication1.BillsPayImplementation.Request;
using WebApplication1.BillsPayImplementation.Response;

namespace WebApplication1.Controllers
{
    [Route("EDC/EDC.svc/Restful")]
    public class EDCTransactionalController : Controller
    {
        private IPortalAdminUserServices _portalAdminUserServices;

        public EDCTransactionalController(IPortalAdminUserServices portalAdminUserServices)
        {
            this._portalAdminUserServices = portalAdminUserServices;
        }
        
        [Route("loginV3")]
        public IActionResult Index()
        {
            string biller = "APEC";
            //string biller = "PANELCO1";
            BillsPayRequest request = new BillsPayRequest()
            {
                BillerCode = "aa",
                ServiceCode = "bb"
            };

            var type = Type.GetType(string.Format("{0}.{1}", "WebApplication1.BillsPayImplementation.BillsPay", biller));
            IBillsPay returnRule = (IBillsPay)Activator.CreateInstance(type);
            BillsPayResponse result = returnRule.BillsPayServices(request);


            var jsonResult = new
            {
                asdasd = "asd",
                were = "qwweg"
            };
            return Ok(jsonResult);
        }
    }
}