﻿using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Models;

namespace UnitOfWorkRepositoryPatternProject.Service.Interface
{
    public interface IProductService
    {
        Task<List<ProductDetailsDto>> GetAllProduct();
        Task<IEnumerable<ProductDetailsDto>> GetAllProductWithPagination(PaginationDto pagination);
        Task<IEnumerable<ProductDetailsDto>> GetProductWithCategory();
    }
}
