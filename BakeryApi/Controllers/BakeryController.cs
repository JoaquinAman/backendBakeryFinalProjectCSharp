using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Repository.Bakery;
using BakeryApi.Dao.Repository.Bread;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApi.Controllers
{
    [ApiController]
    [Route("bakerys")]
    public class BakeryController : ControllerBase
    {
        private readonly IDatabase<BakeryDao> _bakeryDbService;
        private readonly IBakery<OrderDao> _bakeryService;
        public BakeryController(IDatabase<BakeryDao> bakeryDbService, IBakery<OrderDao> bakeryService)
        {
            _bakeryDbService = bakeryDbService;
            _bakeryService = bakeryService;
        }

        [HttpGet]
        public List<BakeryDao> GetBakery()
        {
            return _bakeryDbService.GetList();
        }
        [HttpPost]
        public BakeryDao CreateBakery(BakeryDao bakeryDao)
        {
            //return _bakeryRepository.CreateBakeryDao(bakeryDao);
            return _bakeryDbService.Create(bakeryDao);

        }
        [HttpGet]
        [Route("bakery")]
        public BakeryDao GetBakeryById(int bakeryId)
        {
            return _bakeryDbService.GetById(bakeryId);
        }
        [HttpPut]
        [Route("addOrder")]
        public BakeryDao AddOrderToList(int bakeryId, OrderDao order)
        {
            BakeryDao returnedOrder = _bakeryService.AddOrderToOrderList(bakeryId, order);
            return returnedOrder;
        }

        [HttpDelete]
        public void DeleteBakery(int id)
        {
            _bakeryDbService.DeleteById(id);
        }
    }
}
