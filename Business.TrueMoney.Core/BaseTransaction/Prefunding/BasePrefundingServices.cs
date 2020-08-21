using Business.TrueMoney.Core.Interface.Prefunding;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.TrueMoney.Core.BaseTransaction.Prefunding
{
    public class BasePrefundingServices : IBasePrefundingServices
    {
        public virtual string ValidateTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
