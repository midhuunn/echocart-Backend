using EchoCart_Backend.Models.Responses;

namespace EchoCart_Backend.Repositories
{
    public interface ICompanyRepository 
    {
        GetAllCompaniesResponse GetCompanies(int TenantID); 
    }
}
