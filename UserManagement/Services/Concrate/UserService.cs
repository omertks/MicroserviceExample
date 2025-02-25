using Entity.Models;
using System.Data.Common;
using UserManagement.DbExtensions;
using UserManagement.Services.Abstracts;

namespace UserManagement.Services.Concrate
{
    public class UserService : IUserService
    {

        private readonly UserDbContext _context;

        public UserService(UserDbContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
        }

        public List<User> GetUserList()
        {
            var rs = new List<User>();

            if (_context != null)
            {
                var data = _context.Users.ToList();

                if (data != null)
                {
                    rs = data;  
                }
                else
                {
                    rs.Add(new User() { Name = "Boş" });

                }
            }
            
            return rs;
        }
    }
}
