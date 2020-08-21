using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.BillsPayImplementation.Response
{
    public partial class BillsPayResponse
    {
        public String Status { get; set; } = String.Empty;
        public String Message { get; set; } = String.Empty;
        public String OriginalStatus { get; set; } = String.Empty;

        public String PartnerRefNo { get; set; } = String.Empty;
        public String ReceiptValidationNo { get; set; } = String.Empty;
        public String TPAId { get; set; } = String.Empty;
        public String TransactionNo { get; set; } = String.Empty;
        public String BillerTransactionNo { get; set; } = String.Empty;

        public decimal CorrectAmount { get; set; } = 0.00m;
    }
}
