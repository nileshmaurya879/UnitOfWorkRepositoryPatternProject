using Microsoft.EntityFrameworkCore;
using UnitOfWorkRepositoryPatternProject.Core.Models;

namespace UnitOfWorkRepositoryPatternProject.Infrastructure
{
    public class DbContextClass : DbContext
    {

        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.HasOne(x => x.Category).WithMany(y => y.Products).HasForeignKey(z => z.Cat_id).HasConstraintName("fk_Product_cat_id");
            });
            modelBuilder.Entity<Category>().ToTable("Category").HasKey(x=> x.Cat_id);
        }
    }
}
