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
        public BakeryController(IDatabase<BakeryDao> bakeryDbService)
        {
            _bakeryDbService = bakeryDbService;
        }
        //private readonly IBakeryRepository _bakeryRepository;
        //public BakeryController(IBakeryRepository bakeryRepository)
        //{
        //    _bakeryRepository = bakeryRepository;
        //}
        [HttpGet]
        public List<BakeryDao> GetBakery()
        {
            return _bakeryDbService.GetList();
        }
        [HttpPost]
        public BakeryDao CreateBread(BakeryDao bakeryDao)
        {
            //return _bakeryRepository.CreateBakeryDao(bakeryDao);
            return _bakeryDbService.Create(bakeryDao);

        }
        [HttpDelete]
        public void DeleteBakery(int id)
        {
            //_bakeryRepository.RemoveBakeryDao(id);
            _bakeryDbService.DeleteById(id);

        }
    }
}
