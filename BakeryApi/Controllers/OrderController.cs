using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Repository.Bread;
using BakeryApi.Dao.Repository.Order;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApi.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        private readonly IDatabase<OrderDao> _orderDbService;
        //private readonly IOrderRepository _orderRepository;
        public OrderController(IDatabase<OrderDao> orderDbService)
        {
            _orderDbService = orderDbService;
        }
        [HttpGet]
        public List<OrderDao> GetOrders()
        {
            return _orderDbService.GetList();
        }
        [HttpPost]
        public OrderDao CreateOrder(OrderDao orderDao)
        {
            //return _breadDbService.Create(breadDao);
            return _orderDbService.Create(orderDao);
        }
        [HttpDelete]
        public void DeleteOrder(int id)
        {
            //_breadDbService.RemoveBreadDao(id);
            _orderDbService.DeleteById(id);
        }
    }
}
