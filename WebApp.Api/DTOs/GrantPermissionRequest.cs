using WebApp.Common.Enums;

namespace WebApp.Api.DTOs
{
    public class GrantPermissionRequest
    {
        public int UserId { get; set; }
        public string EntityName { get; set; }
        public Role Role { get; set; }
    }
}
