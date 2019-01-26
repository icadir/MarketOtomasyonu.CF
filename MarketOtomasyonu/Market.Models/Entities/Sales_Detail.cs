using Market.Models.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    public class Sales_Detail:BaseEntity2<int,int>
    {
        public decimal SPiece { get; set; }
        public decimal STotalPrice { get; set; }

        [ForeignKey("Id")]
        public virtual MultiProduct MultiProduct { get; set; }

        [ForeignKey("Id2")]
        public virtual Sales Sales { get; set; }
        

    }
}
