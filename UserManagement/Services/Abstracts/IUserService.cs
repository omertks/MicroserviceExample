using Entity.Models;

namespace UserManagement.Services.Abstracts
{
    public interface IUserService
    {

        public void CreateUser(User user);

        public List<User> GetUserList();
    }
}
