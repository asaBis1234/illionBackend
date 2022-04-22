using Illion0.Entities;
using Microsoft.EntityFrameworkCore;

namespace Illion0.Context
{
    public class IllionDBContext: DbContext
    {
        public IllionDBContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Accounts> accounts { get; set; }
    }
}
