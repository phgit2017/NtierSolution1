using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.BillsPayImplementation.Interface;
using WebApplication1.BillsPayImplementation.Request;
using WebApplication1.BillsPayImplementation.Response;

namespace WebApplication1.BillsPayImplementation.BillsPay
{
    public class PANELCO1 : IBillsPay
    {
        public BillsPayResponse BillsPayServices(BillsPayRequest request)
        {
            var result = new BillsPayResponse();
            return result;
        }
    }
}
