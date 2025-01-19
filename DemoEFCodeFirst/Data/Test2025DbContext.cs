using DemoEFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoEFCodeFirst.Data
{
    public class Test2025DbContext : DbContext
    {
        public Test2025DbContext(DbContextOptions<Test2025DbContext> options) 
            : base(options) 
        { 
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserProfile> UserProfiles { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
