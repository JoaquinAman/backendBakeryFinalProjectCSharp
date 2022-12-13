using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Repository.Bread;
using BakeryApi.Dao.Repository.OrderBread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Service
{
    public class OrderBreadDbService : IDatabase<OrderBreadDao>
    {
        private readonly IOrderBreadRepository _orderBreadRepository;

        public OrderBreadDbService(IOrderBreadRepository orderBreadRepository)
        {
            _orderBreadRepository = orderBreadRepository;
        }
        public OrderBreadDao Create(OrderBreadDao entityDao)
        {
            return _orderBreadRepository.CreateOrderBreadDao(entityDao);
        }

        public void DeleteById(int id)
        {
            _orderBreadRepository.RemoveOrderBreadDao(id);
        }

        public OrderBreadDao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderBreadDao> GetList()
        {
            return _orderBreadRepository.GetAll();
        }

        public OrderBreadDao Update(int id, OrderBreadDao entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
