using Business.TrueMoney.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.TrueMoney.Core.Interface
{
    public interface ICommonServices
    {
        IQueryable<WalletDetails> GetAllWalletDetails();
    }
}
