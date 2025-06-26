using EchoCart_Backend.DBContexts;
using EchoCart_Backend.Models.Responses;
using Microsoft.Extensions.Configuration;

namespace EchoCart_Backend.Repositories.impl
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CompanyDBContext _dbContext;

        public CompanyRepository(CompanyDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public GetAllCompaniesResponse GetCompanies(int TenantID)
        { 
            GetAllCompaniesResponse response = new GetAllCompaniesResponse();
            try
            {
                var CompaniesList = _dbContext.CompanyMasterData.Where(a => a.tenantID == TenantID
                                                                         && a.isDel == 0).ToList();

                response.code = 200;
                response.message = "Sucess";
                response.companyMasterData = CompaniesList;
            }
            catch (Exception ex)
            { 
                response.code = 500;
                response.message = ex.Message;
            }
            return response;
         
        }
    }
}
