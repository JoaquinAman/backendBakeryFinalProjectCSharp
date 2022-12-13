namespace BakeryApi.Dao.Interface
{
    public interface IDatabase<TEntity>
    {
        List<TEntity> GetList();
        TEntity Create(TEntity entityDao);
        TEntity GetById(int id);
        TEntity Update(int id, TEntity entityDao);
        void DeleteById(int id);
    }
}