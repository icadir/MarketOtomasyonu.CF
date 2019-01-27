using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Market.Models.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    public class Sales_Detail 
    {
        public decimal SPiece { get; set; }
        public decimal STotalPrice { get; set; }

        [Key, Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UrunId { get; set; }
        [Key, Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleId { get; set; }

        [ForeignKey("UrunId")]
        public virtual Product Product { get; set; }
        [ForeignKey("SaleId")]
        public virtual Sales Sales { get; set; }


    }
}
