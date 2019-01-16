using Market.Models.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.Entities
{
    class Category:BaseEntity<int>
    {
        [Required]
        public string CName { get; set; }
        [Required]
        public decimal KDV { get; set; }
       
    }
}
