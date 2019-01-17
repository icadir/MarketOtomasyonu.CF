using Market.Models.Abstracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace Market.Models.Entities
{
    public class AcceptanceDetail : BaseEntity2<int, int>
    {
        public decimal Numberofpieces { get; set; }
        public decimal TotalPrice { get; set; }
       

        [ForeignKey("Id")]
        public virtual MultiProduct MultiProduct { get; set; }
        [ForeignKey("Id2")]
        public virtual Acceptance Acceptance { get; set; }
    }
}
