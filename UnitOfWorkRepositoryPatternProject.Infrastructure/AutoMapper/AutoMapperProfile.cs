using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRepositoryPatternProject.Core.Entities;
using UnitOfWorkRepositoryPatternProject.Core.Models;

namespace UnitOfWorkRepositoryPatternProject.Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() {

            #region Product

            CreateMap<Product, ProductDetailsDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            #endregion

        }
    }
}
