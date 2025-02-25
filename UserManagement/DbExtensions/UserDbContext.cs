using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace UserManagement.DbExtensions
{
    public class UserDbContext : DbContext
    {

        private string connectionString = "";

        private readonly IConfiguration _configuration;

        public UserDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (_configuration != null)
            {
                connectionString = $"Server={_configuration["Database:Host"]};Database={_configuration["Database:DbName"]};User Id={_configuration["Database:Username"]};Password={_configuration["Database:Password"]};";

                optionsBuilder.UseSqlServer(connectionString); // sql server sunucu adresi
            }
        }
    }
}
