using Business.TrueMoney.Core.Dto;
using Business.TrueMoney.Core.Interface;
using DataAccess.Database.TRUEMONEY;
using DataAccess.Repository.TrueMoney.Interface;
using System;
using System.Linq;

namespace Business.TrueMoney.Core
{
    public class PortalAdminUserServices : IPortalAdminUserServices
    {
        ITrueMoneyRepository<S_AdminUsers> _adminUsers;

        public PortalAdminUserServices(ITrueMoneyRepository<S_AdminUsers> adminUsers)
        {
            this._adminUsers = adminUsers;
        }

        public AdminUsers GetAllAdminUsers()
        {
            var entityResult = _adminUsers.GetAll().FirstOrDefault();
            var result = new AdminUsers()
            {
                FirstName = entityResult.FirstName,
                AdminUserId = entityResult.AdminUserId
            };
                
            return result;
        }
    }
}
