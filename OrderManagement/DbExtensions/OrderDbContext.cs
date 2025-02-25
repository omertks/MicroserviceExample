using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.DbExtensions
{
    public class OrderDbContext : DbContext
    {

        private string connectionString = "";

        private readonly IConfiguration _configuration;

        public OrderDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (_configuration != null)
            {
                connectionString = $"Server={_configuration["Database:Host"]};Port={_configuration["Database:Port"]};Database={_configuration["Database:DbName"]};User Id={_configuration["Database:Username"]};Password={_configuration["Database:Password"]};";

                optionsBuilder.UseNpgsql(connectionString); // postgresql sunucu adresi

            }
        }

    }
}
