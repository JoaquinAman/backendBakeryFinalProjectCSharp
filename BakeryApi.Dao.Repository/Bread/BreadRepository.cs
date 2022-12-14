using BakeryApi.Dao.Model;
using BakeryApi.Dao.Model.Data;
using Microsoft.EntityFrameworkCore;

namespace BakeryApi.Dao.Repository.Bread
{
    public class BreadRepository : IBreadRepository
    {
        private readonly BakeryContext _context;
        public BreadRepository(BakeryContext context)
        {
            _context = context;
        }
        public List<BreadDao> GetAll()
        {
          return _context.Breads.ToList();
        }
        public BreadDao CreateBreadDao(BreadDao breadDao)
        {
            _context.Add(breadDao);
            _context.SaveChanges();
            return breadDao;
        }

        public void RemoveBreadDao(int id)
        {
            var itemToRemove = _context.Breads.SingleOrDefault(x => x.BreadDaoId == id); //returns a single item.if (itemToRemove != null) {
            _context.Breads.Remove(itemToRemove);
            _context.SaveChanges();
        }
    }
}
