using System;
using System.Collections.Generic;
using System.Text;

namespace Business.TrueMoney.Core.Dto
{
    public class TransactionResponse
    {
        public long? TransactionId { get; set; }
        public decimal? TransactionAmount { get; set; }
        public DateTime? TransactionDateTime { get; set; }
        public string TransactionType { get; set; }
        public string TransactionStatus { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal? CashoutFee { get; set; }
        public string ResponseCode { get; set; }
        public string RemittanceCode { get; set; }
        public string ProfileId { get; set; }
        public string SenderMobileNumber { get; set; }
        public decimal? AvailableBalance { get; set; }
        public decimal? PromoAmount { get; set; }
        public decimal? MinMaxAmount { get; set; }
        public bool? isAWinner { get; set; }
        public decimal? RewardAmount { get; set; }
        public decimal? RewardsPointEarned { get; set; }
        public decimal? PreviousBalance { get; set; } = 0;
        public decimal? Discount { get; set; }
        public decimal? TotalAmount { get; set; }
        public long? TMNCenterId { get; set; }
        public decimal? MaintainingBalance { get; set; }
        public decimal? SourceNewBalance { get; set; } = 0;
        public decimal? AdditionalPromoAmount { get; set; }
        public decimal? CommissionAmount { get; set; } = 0;
        public decimal? SourceOldBalance { get; set; } = 0;

        public TransactionResponse()
        {
            MaintainingBalance = 0;
            TransactionId = 0;
            TransactionAmount = 0;
            TransactionType = "";
            TransactionStatus = "";
            ReferenceNumber = "";
            CashoutFee = 0;
            ResponseCode = "";
            RemittanceCode = "";
            ProfileId = "";
            SenderMobileNumber = "";
            PromoAmount = 0;
            AvailableBalance = 0;
            MinMaxAmount = 0;
            isAWinner = false;
            RewardAmount = 0;
            Discount = 0;
            TotalAmount = 0;
            TMNCenterId = 0;
            SourceNewBalance = 0;
            TransactionDateTime = DateTime.Now;
            AdditionalPromoAmount = 0;
        }
    }
}
