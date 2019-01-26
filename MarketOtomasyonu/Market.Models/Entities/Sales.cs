using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using Market.Models.Enums;

namespace Market.Models.Entities
{
    public class Sales: BaseEntity<int>
    {
        public DateTime SaledTime { get; set; } = DateTime.Now;
        public OdemeTipi PaymentType { get; set; }
        public virtual ICollection<Sales_Detail> SalesDetails { get; set; }=new HashSet<Sales_Detail>();
    }
}
