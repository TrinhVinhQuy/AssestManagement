using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Api.DTOs;
using WebApp.BLL.Interfaces;
using WebApp.Common.Enums;

namespace WebApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionsController : ControllerBase
    {
        private readonly IPermissionService _permissionService;

        public PermissionsController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [HttpPost("grant")]
        public IActionResult GrantPermission([FromBody] GrantPermissionRequest request)
        {
            _permissionService.GrantPermission(request.UserId, request.EntityName, request.Role);
            return Ok("Permission granted successfully.");
        }

        [HttpGet("check")]
        public IActionResult CheckPermission(int userId, string entityName, Role role)
        {
            var hasPermission = _permissionService.HasPermission(userId, entityName, role);
            return Ok(hasPermission);
        }
    }
}
