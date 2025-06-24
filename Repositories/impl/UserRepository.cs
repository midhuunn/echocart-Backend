using EchoCart_Backend.DBContexts;
using Microsoft.Extensions.Configuration;

namespace EchoCart_Backend.Repositories.impl
{
    public class UserRepository : IUserRepository
    {
        private readonly CustomerDBContext _dbContext;

        public UserRepository(CustomerDBContext dbContext)
        {
            _dbContext = dbContext;
           
        }
    }
}
