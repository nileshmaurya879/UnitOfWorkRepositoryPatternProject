namespace UnitOfWorkRepositoryPatternProject.Interface
{
    public interface IUnitOfWork:IDisposable
    {
        IGenericRepository<TEntity> repository<TEntity>() where TEntity : class;
        Task<int> Complete();
    }
}
