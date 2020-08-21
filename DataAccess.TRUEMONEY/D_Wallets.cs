﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Database.TRUEMONEY
{
    public class D_Wallets
    {
        [Key]
        public long WalletId { get; set; }
        public int? CurrencyId { get; set; }
        public decimal? CurrentBalance { get; set; }
        public decimal? AvailableBalance { get; set; }
        public string PinCode { get; set; }
        public int? WalletTypeId { get; set; }
        public decimal? NotificationThreshold { get; set; }
        public decimal? UpperLimit { get; set; }
        public decimal? LowerLimit { get; set; }
        public bool? IsRegistered { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsKYC { get; set; }
        public bool? IsSuspended { get; set; }
        public bool? IsBlacklisted { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsMaster { get; set; }
        public long? MasterWalletID { get; set; }
        public decimal? CapsetLimit { get; set; }
        public int? Frequency { get; set; }
        public string Name { get; set; }
        public int? ModelTypeId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedTime { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public long? DesignatedTdWalletId { get; set; }
        public long? RewardMasterWalletId { get; set; }
        public decimal? InitialWalletBalance { get; set; }
    }
}
