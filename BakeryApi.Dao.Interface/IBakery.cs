using BakeryApi.Dao.Model;
namespace BakeryApi.Dao.Interface
{
    public interface IBakery<TEntity>
    {
        BakeryDao AddOrderToOrderList(int bakeryId, TEntity entityDao);
    }
}
