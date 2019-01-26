using Market.Models.Abstracts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    public class Product : BaseEntity<int>
    {
        public string PName { get; set; }
        [Required]
        [Index(IsUnique = true)]
        [StringLength(5),MinLength(5),MaxLength(5)]
        public string Barkod { get; set; }
        public decimal UBPrice { get; set; }
        public byte[] UPicture { get; set; }
        public decimal Stock { get; set; }
        public decimal PPiece { get; set; } = 1;
        public int CategoryId { get; set; }
        public string PExplanation { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<MultiProduct> MultiProducts { get; set; } = new HashSet<MultiProduct>();

    }
}
