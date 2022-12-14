using BakeryApi.Dao.Model;
using BakeryApi.Dao.Model.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Repository.OrderBread
{
    public class OrderBreadRepository : IOrderBreadRepository
    {
        private readonly BakeryContext _context;
        public OrderBreadRepository(BakeryContext context)
        {
            _context = context;
        }
        public OrderBreadDao CreateOrderBreadDao(OrderBreadDao orderBreadDao)
        {
            _context.Add(orderBreadDao);
            _context.SaveChanges();
            return orderBreadDao;
        }

        public List<OrderBreadDao> GetAll()
        {
            return _context.OrderBreads.ToList();
        }

        public void RemoveOrderBreadDao(int id)
        {
            var itemToRemove = _context.OrderBreads.SingleOrDefault(x => x.OrderBreadId == id); //returns a single item.if (itemToRemove != null) {
            _context.OrderBreads.Remove(itemToRemove);
            _context.SaveChanges();
        }
    }
}
