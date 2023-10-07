using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Interface;
using UnitOfWorkRepositoryPatternProject.Core.Models;
using UnitOfWorkRepositoryPatternProject.Service.Interface;

namespace UnitOfWorkRepositoryPatternProject.Service.Services
{
    public class ProductService :IProductService
    {
        public readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork) {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Product>> GetAllProduct()
        {
            return await _unitOfWork.repository<Product>().GetAll();
        }
        public async Task<List<Product>> GetAllProductWithPagination(PaginationDto pagination)
        {
            return await _unitOfWork.repository<Product>().GetAllWithPagination(pagination);
        }
    }
}
