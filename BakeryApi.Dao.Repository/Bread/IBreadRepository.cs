using BakeryApi.Dao.Model;

namespace BakeryApi.Dao.Repository.Bread
{
    public interface IBreadRepository
    {
        List<BreadDao> GetAll();
        BreadDao CreateBreadDao(BreadDao breadDao);
        void RemoveBreadDao(int id);
    }
}
