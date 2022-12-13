using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Repository.Bakery;
using BakeryApi.Dao.Repository.Bread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Service
{
    public class BakeryDbService : IDatabase<BakeryDao>
    {
        private readonly IBakeryRepository _bakeryRepository;

        public BakeryDbService(IBakeryRepository bakeryRepository)
        {
            _bakeryRepository = bakeryRepository;
        }
        public BakeryDao Create(BakeryDao entityDao)
        {
            return _bakeryRepository.CreateBakeryDao(entityDao);
        }

        public void DeleteById(int id)
        {
            _bakeryRepository.RemoveBakeryDao(id);
        }

        public BakeryDao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BakeryDao> GetList()
        {
            return _bakeryRepository.GetAll();
        }

        public BakeryDao Update(int id, BakeryDao entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
