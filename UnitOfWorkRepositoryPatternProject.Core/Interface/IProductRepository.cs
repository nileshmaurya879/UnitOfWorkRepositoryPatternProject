using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Models;

namespace UnitOfWorkRepositoryPatternProject.Core.Interface
{
    public interface IProductRepository 
    {
        Task<IEnumerable<ProductDetailsDto>> GetProductWithCategory();
    }
}
