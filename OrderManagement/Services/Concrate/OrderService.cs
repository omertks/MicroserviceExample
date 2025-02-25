using Entity.Models;
using OrderManagement.DbExtensions;
using OrderManagement.Services.Abstracts;

namespace OrderManagement.Services.Concrate
{
    public class OrderService : IOrderService
    {

        private readonly OrderDbContext _context;

        public OrderService(OrderDbContext context)
        {
            _context = context;
        }

        public void CreateOrderAsync(Order order)
        {
            _context.Orders.Add(order); 
        }

        public List<Order> GetOrderList()
        {
            var rs = new List<Order>();
         
            if (_context != null)
            {
                var data = _context.Orders.ToList();

                if (data != null)
                {
                    rs = data;
                }
                else
                {
                    rs.Add(new Order() { Name = "Boş" });
                }
            }
            
            return rs;
        }
    }
}
