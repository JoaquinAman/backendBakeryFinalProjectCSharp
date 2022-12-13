using BakeryApi.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Repository.Order
{
    public interface IOrderRepository
    {
        List<OrderDao> GetAll();
        OrderDao CreateOrderDao(OrderDao orderDao);
        OrderDao GetOrderDaoById(int id);
        void RemoveOrderDao(int id);
    }
}
