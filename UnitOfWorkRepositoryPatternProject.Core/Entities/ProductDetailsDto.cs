using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkRepositoryPatternProject.Core.Models;

namespace UnitOfWorkRepositoryPatternProject.Core.Entities
{
    public class ProductDetailsDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Cat_id { get; set; }
        public CategoryDto Category { get; set; }
    }
}
