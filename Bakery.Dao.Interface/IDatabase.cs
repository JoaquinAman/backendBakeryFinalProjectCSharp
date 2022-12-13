namespace Bakery.Dao.Interface
{
    public interface IDatabase<TEntity>
    {
        Task<List<TEntity>> GetList();
        Task<TEntity> Create(TEntity entityDao);
        Task<TEntity> GetById(string id);
        Task<TEntity> Update(string id, TEntity entityDao);
        Task<TEntity> DeleteById(string id);
    }
}