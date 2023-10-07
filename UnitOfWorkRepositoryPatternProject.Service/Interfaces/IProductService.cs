using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Models;

namespace UnitOfWorkRepositoryPatternProject.Service.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProduct();
        Task<List<Product>> GetAllProductWithPagination(PaginationDto pagination);
    }
}
