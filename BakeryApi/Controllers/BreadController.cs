using Microsoft.AspNetCore.Mvc;
using BakeryApi.Dao.Repository.Bread;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Service;
using BakeryApi.Dao.Interface;

using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;

namespace BakeryApi.Controllers
{
    [ApiController]
    [Route("breads")]
    public class BreadController : ControllerBase
    {
        private readonly IDatabase<BreadDao> _breadDbService;
        public BreadController(IDatabase<BreadDao> breadDbService)
        {
            _breadDbService = breadDbService;
        }
        //private readonly IBreadRepository _breadRepository;
        //public BreadController(IBreadRepository breadRepository)
        //{
        //    _breadRepository= breadRepository;
        //}
        [HttpGet]
        public List<BreadDao> GetBreads()
        {
            //return _breadRepository.GetAll();
            return _breadDbService.GetList();
        }
        [HttpPost]
        public BreadDao CreateBread(BreadDao breadDao)
        {
            //return _breadRepository.CreateBreadDao(breadDao);
            return _breadDbService.Create(breadDao);

        }
        [HttpDelete]
        public void DeleteBread(int id)
        {
            //_breadRepository.RemoveBreadDao(id);
            _breadDbService.DeleteById(id);
        }
    }
}
