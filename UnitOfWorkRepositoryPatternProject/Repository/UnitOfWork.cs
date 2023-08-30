using Microsoft.EntityFrameworkCore;
using System.Collections;
using UnitOfWorkRepositoryPatternProject.Interface;
using UnitOfWorkRepositoryPatternProject.Models;

namespace UnitOfWorkRepositoryPatternProject.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        public readonly DbContextClass _dbContext;
        private Hashtable _repositories;

        public UnitOfWork(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Complete()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public IGenericRepository<TEntity> repository<TEntity>() where TEntity : class
        {
            if (_repositories == null) _repositories = new Hashtable();
            var Type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(Type))
            {
                var repositiryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(
                    repositiryType.MakeGenericType(typeof(TEntity)), _dbContext);
                _repositories.Add(Type, repositoryInstance);
            }
            return (IGenericRepository<TEntity>)_repositories[Type];
        }
    }
}
