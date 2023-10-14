
using UnitOfWorkRepositoryPatternProject.Core.Entities;

namespace UnitOfWorkRepositoryPatternProject.Core.Interface
{
    public interface IProductRepository 
    {
        Task<IEnumerable<ProductDetailsDto>> GetProductWithCategory();
    }
}
