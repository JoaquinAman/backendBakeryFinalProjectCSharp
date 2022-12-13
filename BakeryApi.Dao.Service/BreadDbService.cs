using BakeryApi.Dao.Interface;
using BakeryApi.Dao.Model;
using BakeryApi.Dao.Repository.Bread;

namespace BakeryApi.Dao.Service
{
    public class BreadDbService : IDatabase<BreadDao>
    {
        private readonly IBreadRepository _breadRepository;

        public BreadDbService(IBreadRepository breadRepository)
        {
            _breadRepository = breadRepository;
        }
        public BreadDao Create(BreadDao entityDao)
        {
            return _breadRepository.CreateBreadDao(entityDao);
        }

        public void DeleteById(int id)
        {
            _breadRepository.RemoveBreadDao(id);
        }

        public BreadDao GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<BreadDao> GetList()
        {
            return _breadRepository.GetAll();
        }

        public BreadDao Update(int id, BreadDao entityDao)
        {
            throw new NotImplementedException();
        }
    }
}
