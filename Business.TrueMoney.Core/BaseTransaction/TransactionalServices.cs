using Business.TrueMoney.Core.Dto;
using Business.TrueMoney.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.TrueMoney.Core.BaseTransaction
{
    public class TransactionalServices : ITransactionalServices
    {
        public TransactionResponse ExecuteProcessTransaction(TransactionRequest request)
        {
            TransactionResponse response = new TransactionResponse();

            return response;
        }
    }
}
