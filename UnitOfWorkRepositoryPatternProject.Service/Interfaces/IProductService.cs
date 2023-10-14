using UnitOfWorkRepositoryPatternProject.Core.Entities;
namespace UnitOfWorkRepositoryPatternProject.Service.Interface
{
    public interface IProductService
    {
        Task<List<ProductDetailsDto>> GetAllProduct();
        Task<IEnumerable<ProductDetailsDto>> GetAllProductWithPagination(PaginationDto pagination);
        Task<IEnumerable<ProductDetailsDto>> GetProductWithCategory();
    }
}
