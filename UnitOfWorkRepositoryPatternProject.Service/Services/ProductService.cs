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
        public async Task<List<ProductDetailsDto>> GetAllProduct()
        {
            var data = await _unitOfWork.repository<Product>().GetAll();
            return _mapper.Map<List<ProductDetailsDto>>(data);
        }
        public async Task<IEnumerable<ProductDetailsDto>> GetAllProductWithPagination(PaginationDto pagination)
        {
            var product = await _unitOfWork.repository<Product>().GetAllWithPagination(pagination);
            return _mapper.Map<IEnumerable<ProductDetailsDto>>(product);
        }
        public async Task<IEnumerable<ProductDetailsDto>> GetProductWithCategory()
        {
            var data = await _unitOfWork.Product.GetProductWithCategory();
            return _mapper.Map<IEnumerable<ProductDetailsDto>>(data);
        }
    }
}
