using Market.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    public class MultiProduct:BaseEntity<int>
    {
        [Index("IX_MPUQ",IsUnique =true)]
        [Required]
        [StringLength(11), MinLength(11), MaxLength(11)]
        public string MPBarkod { get; set; }
        [Required]
        public decimal MPPiece { get; set; }
        [Required]
        public decimal MPPrice { get; set; }
        [Required]
        public string MPExplanation { get; set; }
        public byte[] MPPicture { get; set; }

        public int UrunId { get; set; }

        [ForeignKey("UrunId")]
        public virtual Product Product { get; set; }

        public virtual ICollection<AcceptanceDetail> AcceptanceDetails { get; set; } = new HashSet<AcceptanceDetail>();

     
    }
}
