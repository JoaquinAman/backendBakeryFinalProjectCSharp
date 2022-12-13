using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApi.Controllers
{
    [ApiController]
    [Route("orderBreads")]
    public class OrderBreadController : ControllerBase
    {
        private readonly IDatabase<OrderBreadDao> _orderBreadDbService;
        public OrderBreadController(IDatabase<OrderBreadDao> orderBreadDbService)
        {
            _orderBreadDbService = orderBreadDbService;
        }
        //private readonly IBreadRepository _breadRepository;
        //public BreadController(IBreadRepository breadRepository)
        //{
        //    _breadRepository= breadRepository;
        //}
        [HttpGet]
        public List<OrderBreadDao> GetOrderBreads()
        {
            //return _breadRepository.GetAll();
            return _orderBreadDbService.GetList();
        }
        [HttpPost]
        public OrderBreadDao CreateOrderBread(OrderBreadDao orderBreadDao)
        {
            //return _breadRepository.CreateBreadDao(breadDao);
            return _orderBreadDbService.Create(orderBreadDao);

        }
        [HttpDelete]
        public void DeleteOrderBread(int id)
        {
            //_breadRepository.RemoveBreadDao(id);
            _orderBreadDbService.DeleteById(id);
        }
    }
}
