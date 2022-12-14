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
    public class BakeryDbService : IDatabase<BakeryDao>, IBakery<OrderDao>
    {
        private readonly IBakeryRepository _bakeryRepository;
        
        public BakeryDbService(IBakeryRepository bakeryRepository)
        {
            _bakeryRepository = bakeryRepository;
        }

        public BakeryDao GetById(int id)
        {
            return _bakeryRepository.GetById(id);
        }

        public BakeryDao AddOrderToOrderList(int bakeryId, OrderDao orderDao)
        {
            BakeryDao bakeryDao = _bakeryRepository.GetById(bakeryId);
            bakeryDao.OrderList.Add(orderDao);
            BakeryDao returnBakeryDao = _bakeryRepository.UpdateBakeryDaoOrderList(bakeryId, bakeryDao);
            return returnBakeryDao;
        }

        public BakeryDao Create(BakeryDao bakeryDao)
        {
            return _bakeryRepository.CreateBakeryDao(bakeryDao);
        }

        public void DeleteById(int id)
        {
            _bakeryRepository.RemoveBakeryDao(id);
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
