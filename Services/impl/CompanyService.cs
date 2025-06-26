using EchoCart_Backend.Models.Responses;
using EchoCart_Backend.Repositories;
using System.Net.Http;

namespace EchoCart_Backend.Services.impl
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public GetAllCompaniesResponse GetCompanies(int TenantID)
        { 
        
            return _companyRepository.GetCompanies(TenantID);
        }

    }

}
