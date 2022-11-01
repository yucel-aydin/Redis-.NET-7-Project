using Microsoft.EntityFrameworkCore;

namespace RedisExampleApp.API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(

                new Products()
                {
                    Id = 1,
                    Name = "Kitap 1",
                    Price = 10
                },

                new Products()
                {
                    Id = 2,
                    Name = "Kitap 2",
                    Price = 20
                },


                new Products()
                {
                    Id = 3,
                    Name = "Kitap 3",
                    Price = 30
                }

                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
