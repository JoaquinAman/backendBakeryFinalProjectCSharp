using BakeryApi.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Repository.OrderBread
{
    public interface IOrderBreadRepository
    {
        List<OrderBreadDao> GetAll();
        OrderBreadDao CreateOrderBreadDao(OrderBreadDao orderBreadDao);
        void RemoveOrderBreadDao(int id);
    }
}
