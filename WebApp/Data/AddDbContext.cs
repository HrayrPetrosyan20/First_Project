using Microsoft.EntityFrameworkCore;
using WebApp.Models;
namespace WebApp.Data

{
    public class AddDbContext:DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext> options) : base(options) { }
        public DbSet<Car> Cars { get; set; }
    }
}
