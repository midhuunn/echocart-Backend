using Microsoft.EntityFrameworkCore;

namespace EchoCart_Backend.DBContexts
{
    public class CustomerDBContext : DbContext
    {

        public CustomerDBContext(DbContextOptions<CustomerDBContext> options) : base(options)
        { 

        }
    }
}
