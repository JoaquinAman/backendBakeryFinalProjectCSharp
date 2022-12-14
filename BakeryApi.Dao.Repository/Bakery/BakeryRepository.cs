using BakeryApi.Dao.Model;
using BakeryApi.Dao.Model.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApi.Dao.Repository.Bakery
{
    public class BakeryRepository : IBakeryRepository
    {
        private readonly BakeryContext _context;
        public BakeryRepository(BakeryContext context)
        {
            _context = context;
        }
        public BakeryDao CreateBakeryDao(BakeryDao bakeryDao)
        {
            _context.Add(bakeryDao);
            _context.SaveChanges();
            return bakeryDao;
        }

        public List<BakeryDao> GetAll()
        {
            return _context.Bakerys.Include(x => x.OrderList).ToList();
        }

        public BakeryDao GetById(int id)
        {
            return _context.Bakerys.Include(x => x.OrderList).SingleOrDefault(x => x.BakeryId == id); //returns a single item.if (itemToRemove != null) {
        }

        public void RemoveBakeryDao(int id)
        {
            var itemToRemove = _context.Bakerys.SingleOrDefault(x => x.BakeryId == id); //returns a single item.if (itemToRemove != null) {
            _context.Bakerys.Remove(itemToRemove);
            _context.SaveChanges();
        }

        public BakeryDao UpdateBakeryDaoOrderList(int bakeryId, BakeryDao bakeryDao)
        {
            var itemToUpdate = _context.Bakerys.Include(x => x.OrderList).SingleOrDefault(x => x.BakeryId == bakeryId); //returns a single item.if (itemToRemove != null) {
            //first.AddRange(second);
            itemToUpdate.OrderList = bakeryDao.OrderList;
            _context.SaveChanges();
            return itemToUpdate;
        }
    }
}
