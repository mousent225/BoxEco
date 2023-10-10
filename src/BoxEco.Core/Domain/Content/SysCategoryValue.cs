using BoxEco.Core.Domain.Enum;

namespace BoxEco.Core.Domain.Content
{
    public class SysCategoryValue
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Seq { get; set; }
        public Status Status { get; set; }
        public string? SubCode { get; set; }
        public int? ParentId { get; set; }

        public DateTime CreateDate { get; set; }
        public Guid CreateUid { get; set; }
        //public AppUser CreateUser { get; set; }

        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateUid { get; set; }

        public DateTime? DeleteDate { get; set; }
        public Guid? DeleteUid { get; set; }
        
    }
}
