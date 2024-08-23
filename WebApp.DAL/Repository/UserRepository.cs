using Microsoft.EntityFrameworkCore;
using WebApp.DAL.Data;
using WebApp.DAL.Entities;

namespace WebApp.DAL.Repository
{
    public class UserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Users GetUserById(int userId)
        {
            return _context.Users.Include(u => u.Drives).Include(u => u.Permissions).FirstOrDefault(u => u.Id == userId);
        }

        public void SaveUser(Users user)
        {
            if (user.Id == 0)
            {
                _context.Users.Add(user);
            }
            else
            {
                _context.Users.Update(user);
            }
            _context.SaveChanges();
        }
    }
}
