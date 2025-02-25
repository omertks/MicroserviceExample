using Entity.Models;

namespace OrderManagement.Services.Abstracts
{
    public interface IOrderService
    {

        public void CreateOrderAsync(Order order);

        public List<Order> GetOrderList();
    }
}
