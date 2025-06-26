using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoCart_Backend.Models
{
    [Table("companies")]
    public class CompanyMasterData
    {
        [Key]
        [Column("companyid")]
        public int companyId { get; set; }
        [Column("name")]
        public string? name { get; set; }
        [Column("email")]
        public string? email { get; set; }
        [Column("address")]
        public string? address { get; set; }
        [Column("createdby")]
        public int createdBy { get; set; }
        [Column("isdel")]
        public int? isDel { get; set; }
        [Column("tenantid")]
        public int tenantID { get; set; }

    }
}
