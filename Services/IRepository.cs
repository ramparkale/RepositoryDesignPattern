namespace RepositoryDesignPattern.Services
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);

        void Delete(int id);

        List<TEntity> GetAll();

        TEntity GetById(int id);


    }
}
