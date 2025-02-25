using Entity.Models;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Services.Abstracts;
using OrderManagement.Services.Concrate;

namespace OrderManagement.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {

        private readonly IOrderService _orderService;

        public OrderController()
        {
            _orderService = new OrderService();
        }

        [HttpGet]
        public IActionResult GetOrder()
        {
            return Ok(_orderService.GetOrderList());
        }
    }
}
