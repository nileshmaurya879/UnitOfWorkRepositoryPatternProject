
namespace UnitOfWorkRepositoryPatternProject.Core.Models
{
    public partial class Category
    {
        public Category() { 
            Products = new HashSet<Product>();
        }
        public int Cat_id { get; set; }
        public string Cat_Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
