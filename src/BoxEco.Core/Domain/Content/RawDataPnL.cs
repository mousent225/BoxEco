using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxEco.Core.Domain.Content
{
    [Table("RawDataPnL")]
    public class RawDataPnL
    {
        [Key]
        public Guid Id { get; set; }
        public int AccountNumber { get; set; }
        [MaxLength(50)]
        public string? AccountName { get; set; }
        [MaxLength(20)]
        public string? Type { get; set; }
        [MaxLength(250)]
        public string? Split { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(20)]
        public string? TransactionNo { get; set; }
        [MaxLength(20)]
        public string? OtherDocNo { get; set; }
        [MaxLength(50)]
        public string? RedInvoiceNo{ get; set; }
        [MaxLength(150)]
        public string? Name { get; set; }
        [MaxLength(300)]
        public string? MemoInVN { get; set; }
        [MaxLength(300)]
        public string? MemoInEN { get; set; }
        [MaxLength(400)]
        public string? Description1 { get; set; }
        [MaxLength(400)]
        public string? Description2 { get; set; }
        [MaxLength(400)]
        public string? Description3 { get; set; }
        [MaxLength(400)]
        public string? Description4 { get; set; }
        public float Debit { get; set; }
        public float Credit { get; set; }
        public float Balance { get; set; }
        [MaxLength(50)]
        public string? DepartmentName { get; set; }
        [MaxLength(100)]
        public string? LocationName { get; set; }
        [MaxLength(400)]
        public string? DescEN { get; set; }
        [MaxLength(100)]
        public string? AccountType { get; set; }
        [MaxLength(20)]
        public string? TransactionNumber { get; set; }
        [MaxLength(20)]
        public string? BaseStatus { get; set; }
        [MaxLength(20)]
        public string? MeiRef { get; set; }
        [MaxLength(200)]
        public string? Name1 { get; set; }
        [MaxLength(20)]
        public string? MemoJE { get; set; }
        public float Amount { get; set; }
        [MaxLength(5)]
        public string? StoreCode { get; set; }
        [MaxLength(20)]
        public string? SAndD { get; set; }
        public bool ThirdPartyJeds { get; set; }

        public Guid CreateUid { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid? DeleteUid { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Guid? UpdateUid { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
 