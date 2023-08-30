using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPatternProject.Interface;
using UnitOfWorkRepositoryPatternProject.Models;

namespace UnitOfWorkRepositoryPatternProject.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContextClass _dbContextClass;

        public GenericRepository(DbContextClass dbContextClass) { 
            _dbContextClass = dbContextClass;
        }
        public async Task Add(T entity)
        {
            await _dbContextClass.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbContextClass.Set<T>().Remove(entity);
        }

        public Task<List<T>> GetAll()
        {
           return _dbContextClass.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbContextClass.Set<T>().FindAsync(id);

        }
        public void Update(T entity)
        {
           _dbContextClass.Set<T>().Update(entity);
        }
    }
}
