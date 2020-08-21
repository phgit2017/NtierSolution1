using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.BillsPayImplementation.Request;
using WebApplication1.BillsPayImplementation.Response;

namespace WebApplication1.BillsPayImplementation.Interface
{
    public interface IBillsPay
    {
        BillsPayResponse BillsPayServices(BillsPayRequest request);
    }
}
