using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxEco.Core.Domain.Content
{
    [Table("AccountDefine")]
    public class AccountDefine
    {
        [Key]
        public int AccountNum { get; set; }
        [MaxLength(100)]
        public required string AcctName { get; set; }
        [MaxLength(100)]
        public required string FinanceRow1 { get; set; }
        [MaxLength(100)]
        public string? FinanceRow2 { get; set; }
        [MaxLength(100)]
        public string? CostType { get; set; }

    }
}
