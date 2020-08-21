using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.BillsPayImplementation.Request
{
    //APEC
    public partial class BillsPayRequest : BillsPayCommon
    {
        public string AccountName { get; set; } = string.Empty;
        public string InvoiceNo { get; set; } = string.Empty;
        public decimal BillAmount { get; set; } = 0.00m;
        public DateTime? DeliveryDate { get; set; } = null;
        public string BillMonth { get; set; } = string.Empty;
        public string BillYear { get; set; } = string.Empty;
        public string SOA { get; set; } = string.Empty;
    }

    //PANELCO1
    public partial class BillsPayRequest : BillsPayCommon
    {
        public string MeterNo { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public DateTime? ExpirationDate { get; set; } = null;
        public DateTime? DueDate { get; set; } = null;
    }

    public class BillsPayCommon
    {
        public string BillerCode { get; set; } = string.Empty;
        public string ServiceCode { get; set; } = string.Empty;

        public string AccountNo { get; set; } = string.Empty;
        public decimal AmountDue { get; set; } = 0.00m;
        public decimal OtherCharges { get; set; } = 0.00m;
    }
}
