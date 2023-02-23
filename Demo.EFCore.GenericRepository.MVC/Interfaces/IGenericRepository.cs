namespace Demo.EFCore.GenericRepository.MVC.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IQueryable<TEntity>> GetAll();
        Task<bool> AddEntity(TEntity entity);
        Task<bool> AddRangeofEntities(IEnumerable<TEntity> entities);
        Task<bool> UpdateEntities(TEntity entity);
        Task<bool> DeleteEntities(TEntity entity);
        TEntity GetById(int Id);
    }
}
