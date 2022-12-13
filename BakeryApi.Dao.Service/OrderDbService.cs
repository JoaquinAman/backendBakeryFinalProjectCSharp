using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Repository.Bread;
using BakeryApi.Dao.Repository.Order;
using BakeryApi.Dao.Repository.OrderBread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Service
{
    public class OrderDbService : IDatabase<OrderDao>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderBreadRepository _orderBreadRepository;

        public OrderDbService(IOrderRepository orderRepository, IOrderBreadRepository orderBreadRepository)
        {
            _orderRepository = orderRepository;
            _orderBreadRepository = orderBreadRepository;
        }
        public OrderDao Create(OrderDao entityDao)
        {
            return _orderRepository.CreateOrderDao(entityDao);
            //OrderBreadDao orderBreadDao = new OrderBreadDao
            //{
            //    BreadDaoId = returnOrderDao.BreadDaoList.ToArray()[0].BreadDaoId,
            //    OrderDaoId = returnOrderDao.OrderId,
            //    Quantity = returnOrderDao.BreadDaoList.ToArray()[0].Quantity
            //};
            
            //_orderBreadRepository.CreateOrderBreadDao(orderBreadDao);
            
            //return returnOrderDao;

        }

        public void DeleteById(int id)
        {
            _orderRepository.RemoveOrderDao(id);
        }

        public OrderDao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<OrderDao> GetList()
        {
            return _orderRepository.GetAll();
        }

        public OrderDao Update(int id, OrderDao entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
