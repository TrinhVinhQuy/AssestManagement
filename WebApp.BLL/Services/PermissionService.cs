using System;
using WebApp.BLL.Interfaces;
using WebApp.Common.Enums;
using WebApp.DAL.Data;
using WebApp.DAL.Entities;
using WebApp.DAL.Interfaces;

namespace WebApp.BLL.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly ApplicationDbContext _context;

        public PermissionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void GrantPermission(int userId, string entityName, Role role)
        {
            // Logic để cấp quyền cho user
            var user = _context.Users.Find(userId);
            var folder = _context.Folders.FirstOrDefault(f => f.FolderName == entityName);
            if (user != null && folder != null)
            {
                _context.Permissions.Add(new Permissions
                {
                    UserId = userId,
                    FolderId = folder.Id,
                    Role = role
                });
                _context.SaveChanges();
            }
        }

        public bool HasPermission(int userId, string entityName, Role role)
        {
            // Logic để kiểm tra quyền của user
            var folder = _context.Folders.FirstOrDefault(f => f.FolderName == entityName);
            if (folder == null) return false;

            var permission = _context.Permissions.FirstOrDefault(p => p.UserId == userId && p.FolderId == folder.Id && p.Role == role);
            return permission != null;
        }
    }
}
