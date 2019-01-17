using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    public class Acceptance: BaseEntity<int>
    {
        public DateTime CreateDate { get; set; }

        public virtual ICollection<AcceptanceDetail> AcceptanceDetails { get; set; } = new HashSet<AcceptanceDetail>();
    }
}
