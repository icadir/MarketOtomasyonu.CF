using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Abstracts;

namespace Market.Models.Entities
{
    public class Sales: BaseEntity<int>
    {
        public DateTime SaledTime { get; set; }

        public virtual ICollection<Sales_Detail> SalesDetails { get; set; }=new HashSet<Sales_Detail>();
    }
}
