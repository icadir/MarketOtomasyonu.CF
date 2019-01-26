using Market.Models.Abstracts;
using System;
using System.Collections.Generic;

namespace Market.Models.Entities
{
    public class Sales: BaseEntity<int>
    {
        public DateTime SaledTime { get; set; } = DateTime.Now;

        public virtual ICollection<Sales_Detail> SalesDetails { get; set; }=new HashSet<Sales_Detail>();
    }
}
