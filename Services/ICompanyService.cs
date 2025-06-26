using EchoCart_Backend.Models.Responses;

namespace EchoCart_Backend.Services
{
    public interface ICompanyService
    {
        public GetAllCompaniesResponse GetCompanies(int TenantID);
    }
}
