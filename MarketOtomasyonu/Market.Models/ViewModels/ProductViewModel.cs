using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class ProductViewModel
    {
       
        public int CategoryId { get; set; }
        public int ProdcutId { get; set; }

        public string PName { get; set; }
        public string Barkod { get; set; }
        public decimal UBPrice { get; set; }
        public byte[] UPicture { get; set; }
        public decimal Stock { get; set; }
        public decimal PPiece { get; set; } = 1;
       

        
        public virtual Category Category { get; set; }
    }
}
