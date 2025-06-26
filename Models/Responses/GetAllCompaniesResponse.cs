namespace EchoCart_Backend.Models.Responses
{
    public class GetAllCompaniesResponse
    {
        public int? code { get; set; }
        public string? message { get; set; }
        public List<CompanyMasterData> companyMasterData { get; set; } = new List<CompanyMasterData>();
    }
}
