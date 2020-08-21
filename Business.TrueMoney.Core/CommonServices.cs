using Business.TrueMoney.Core.Dto;
using Business.TrueMoney.Core.Interface;
using DataAccess.Database.TRUEMONEY;
using DataAccess.Repository.TrueMoney.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.TrueMoney.Core
{
    #region Declarations and constructors
    public partial class CommonServices
    {
        ITrueMoneyRepository<D_Wallets> _wallets;

        public CommonServices(ITrueMoneyRepository<D_Wallets> wallets)
        {
            this._wallets = wallets;
        }
        
    }
    #endregion

    #region Interface implementations
    public partial class CommonServices : ICommonServices
    {
        public IQueryable<WalletDetails> GetAllWalletDetails()
        {
            IQueryable<WalletDetails> result = null;
            try
            {
                result = (from model in _wallets.GetAll()
                          select new WalletDetails
                          {
                              AvailableBalance = model.AvailableBalance,
                              CapsetLimit = model.CapsetLimit,
                              CurrencyId = model.CurrencyId,
                              CurrentBalance = model.CurrentBalance,
                              DesignatedTdWalletId = model.DesignatedTdWalletId,
                              Frequency = model.Frequency,
                              InitialWalletBalance = model.InitialWalletBalance,
                              IsActive = model.IsActive,
                              IsBlacklisted = model.IsBlacklisted,
                              IsDeleted = model.IsDeleted,
                              IsKYC = model.IsKYC,
                              IsMaster = model.IsMaster,
                              IsRegistered = model.IsRegistered,
                              IsSuspended = model.IsSuspended,
                              LowerLimit = model.LowerLimit,
                              MasterWalletId = model.MasterWalletID,
                              ModelTypeId = model.ModelTypeId,
                              CreatedBy = model.CreatedBy,
                              CreatedTime = model.CreatedTime,
                              ModifiedBy = model.ModifiedBy,
                              ModifiedTime = model.ModifiedTime,
                              Name = model.Name,
                              NotificationThreshold = model.NotificationThreshold,
                              PinCode = model.PinCode,
                              RewardMasterWalletId = model.RewardMasterWalletId,
                              UpperLimit = model.UpperLimit,
                              WalletTypeId = model.WalletTypeId,
                              WalletId = model.WalletId
                          });
            }
            catch (Exception)
            {

                throw;
            }
            

            return result;
        }
    }
    #endregion
}
