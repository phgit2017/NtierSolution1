using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.LogsValidationImplementation
{
    public class WalletDetails
    {
        public long WalletId { get; set; }
        public string WalletName { get; set; }
        public bool? IsMaster { get; set; }
        public long? ModelTypeId { get; set; }
    }
}
