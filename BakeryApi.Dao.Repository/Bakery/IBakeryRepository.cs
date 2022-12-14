using BakeryApi.Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Repository.Bakery
{
    public interface IBakeryRepository
    {
        List<BakeryDao> GetAll();
        BakeryDao CreateBakeryDao(BakeryDao bakeryDao);
        BakeryDao AddOrderToOrderList(int id, OrderDao orderDao);
        void RemoveBakeryDao(int id);
        BakeryDao GetById(int id);
    }
}
