using WebApp.DAL.Entities;

namespace WebApp.DAL.Interfaces
{
    public interface IUserRepository
    {
        Users GetUserById(int userId);
        void SaveUser(Users user);
    }
}
