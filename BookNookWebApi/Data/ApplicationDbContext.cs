using Microsoft.EntityFrameworkCore;

namespace BookNookWebApi.Data
{
    public class ApplicationDbContext :DbContext


    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { 
        }
    }
}
