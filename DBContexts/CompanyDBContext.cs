using EchoCart_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace EchoCart_Backend.DBContexts
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options)
        {
        }

        public DbSet<CompanyMasterData> CompanyMasterData { get; set; }
    }
}
