using Business.TrueMoney.Core.Dto;
using System.Linq;

namespace Business.TrueMoney.Core.Interface
{
    public interface IPortalAdminUserServices
    {
        AdminUsers GetAllAdminUsers();
    }
}