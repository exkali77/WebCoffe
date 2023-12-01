
using Microsoft.EntityFrameworkCore;

namespace WebCoffe.Models
{
    public class appDbContext:DbContext
    {
      

        public appDbContext(DbContextOptions options) : base(options)
        {
          

        }
        public  DbSet<Product> Coffe { get; set; }
    

    }
}
