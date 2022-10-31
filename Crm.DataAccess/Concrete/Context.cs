using Crm.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Crm.DataAccess.Concrete
{
    public class Context : DbContext
    {
        private readonly IConfiguration _configuration; 
        public Context(DbContextOptions<Context> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new { Id = 1, Name = "Jane", Surname = "Joe", Phone = "5553337788", Mail = "jj@mail.com" },
                new { Id = 2, Name = "Chris", Surname = "Cor", Phone = "4442226677", Mail = "cc@mail.com" });


            modelBuilder.Entity<Category>().HasData(
                new { Id = 1, Name = "Technology", Description = "Engineering" },
                new { Id = 2, Name = "Art", Description = "Picture" }
                );  
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
