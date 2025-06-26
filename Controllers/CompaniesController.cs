using EchoCart_Backend.Models.Responses;
using EchoCart_Backend.Repositories;
using EchoCart_Backend.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EchoCart_Backend.Controllers
{
    [Route("echocart/company/companies")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
      private readonly  ICompanyService _companyservice;

        public CompaniesController(ICompanyService companyService)
        {
            _companyservice = companyService;
        }

        [HttpGet("GetAllCompanies")]
        public GetAllCompaniesResponse GetCompanies(int TenantID)
        {

            return _companyservice.GetCompanies(TenantID);
             
        }
    }
}
