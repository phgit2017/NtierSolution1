using System;
using System.Collections.Generic;
using System.Text;

namespace Business.TrueMoney.Core.Dto
{
    public class GeneralBaseClass
    {
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
    }
}
