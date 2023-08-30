using UnitOfWorkRepositoryPatternProject.Entities;
using UnitOfWorkRepositoryPatternProject.Models;

namespace UnitOfWorkRepositoryPatternProject.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProduct();
        Task<List<Product>> GetAllProductWithPagination(PaginationDto pagination);
    }
}
