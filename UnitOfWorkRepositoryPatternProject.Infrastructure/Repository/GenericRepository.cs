using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Interface;

namespace UnitOfWorkRepositoryPatternProject.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContextClass _dbContextClass;
        protected readonly IMapper _mapper;
        public GenericRepository(DbContextClass dbContextClass, IMapper mapper) { 
            _dbContextClass = dbContextClass;
            _mapper = mapper;
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

        public Task<List<T>> GetAllWithPagination(PaginationDto pagination)
        {
            return _dbContextClass.Set<T>().Skip((pagination.PageNumber - 1) * pagination.PageSize).Take(pagination.PageSize).ToListAsync();
        }
    }
}
