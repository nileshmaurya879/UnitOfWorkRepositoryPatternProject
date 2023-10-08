using AutoMapper;
using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Interface;
using UnitOfWorkRepositoryPatternProject.Core.Models;

namespace UnitOfWorkRepositoryPatternProject.Infrastructure.Repository.Products
{
    public class ProductRepository :  IProductRepository
    {
        private readonly DbContextClass _DbContext;
        private readonly IMapper _mapper;
        
        public ProductRepository(DbContextClass contextClass, IMapper mapper) 
        {
            _DbContext = contextClass;
            _mapper = mapper;
        }
        public async Task<IEnumerable<ProductDetailsDto>> GetProductWithCategory()
        {
            var product = await _DbContext.Products.AsNoTracking().Include(x => x.Category).ToListAsync();
            return _mapper.Map<IEnumerable<ProductDetailsDto>>(product);
        }
    }
}
