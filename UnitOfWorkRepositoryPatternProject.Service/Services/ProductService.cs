using AutoMapper;
using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Interface;
using UnitOfWorkRepositoryPatternProject.Core.Models;
using UnitOfWorkRepositoryPatternProject.Service.Interface;

namespace UnitOfWorkRepositoryPatternProject.Service.Services
{
    public class ProductService :IProductService
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork,IMapper mapper) {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<Product>> GetAllProduct()
        {
            return await _unitOfWork.repository<Product>().GetAll();
        }
        public async Task<List<Product>> GetAllProductWithPagination(PaginationDto pagination)
        {
            return await _unitOfWork.repository<Product>().GetAllWithPagination(pagination);
        }
        public async Task<IEnumerable<ProductDetailsDto>> GetProductWithCategory()
        {
            var data = await _unitOfWork.Product.GetProductWithCategory();
            return _mapper.Map<IEnumerable<ProductDetailsDto>>(data);
        }
    }
}
