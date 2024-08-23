using WebApp.Common.Enums;

namespace WebApp.BLL.Interfaces
{
    public interface IPermissionService
    {
        void GrantPermission(int userId, string entityName, Role role);
        bool HasPermission(int userId, string entityName, Role role);
    }
}
