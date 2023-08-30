using UnitOfWorkRepositoryPatternProject.Models;

namespace UnitOfWorkRepositoryPatternProject.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProduct();
    }
}
