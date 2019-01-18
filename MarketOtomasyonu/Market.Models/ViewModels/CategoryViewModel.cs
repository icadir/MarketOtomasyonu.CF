using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal KDV { get; set; }

        public override string ToString() => $"{CategoryName} -- KDV : {KDV}";
      
    }
}
