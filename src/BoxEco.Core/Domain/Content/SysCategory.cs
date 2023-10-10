using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxEco.Core.Domain.Content
{
    [Table("SysCategory")]
    public class SysCategory
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }
        public int Seq { get; set; }
        //public Status Status { get; set; }

        public DateTime CreateDate { get; set; }
        public Guid CreateUid { get; set; }

        public DateTime? UpdateDate { get; set; }
        public Guid? UpdateUid { get; set; }

        public DateTime? DeleteDate { get; set; }
        public Guid? DeleteUid { get; set; }

    }
}
