using BakeryApi.Dao.Model;
using BakeryApi.Dao.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace BakeryApi.Dao.Repository.Order
{
    public class OrderRepository : IOrderRepository
    {
        private readonly BakeryContext _context;
        public OrderRepository(BakeryContext context)
        {
            _context = context;
        }
        public OrderDao CreateOrderDao(OrderDao orderDao)
        {
            _context.Add(orderDao);
            _context.SaveChanges();
            return orderDao;
        }

        public List<OrderDao> GetAll()
        {
            return _context.Orders.Include(x => x.BreadDaoList).ToList();
        }

        public OrderDao GetOrderDaoById(int id)
        {
            return _context.Orders.SingleOrDefault(x => x.OrderId == id); //returns a single item.if (itemToRemove != null) {
        }

        public void RemoveOrderDao(int id)
        {
            var itemToRemove = _context.Orders.SingleOrDefault(x => x.OrderId == id); //returns a single item.if (itemToRemove != null) {
            _context.Orders.Remove(itemToRemove);
            _context.SaveChanges();
        }
    }
}
