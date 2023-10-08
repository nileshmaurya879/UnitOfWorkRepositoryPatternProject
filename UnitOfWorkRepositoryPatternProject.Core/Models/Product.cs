namespace UnitOfWorkRepositoryPatternProject.Core.Models
{
    public partial class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Cat_id { get; set; }
        public virtual Category Category { get; set; }
    }
}
