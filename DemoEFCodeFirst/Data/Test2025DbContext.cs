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
    }
}
