using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Models.ViewModels
{
    public class MultiProductAcceptViewModel
    {
        public int MultiProdcutId { get; set; }
        public int UrunId { get; set; }
     
        public decimal MPPiece { get; set; }
        public decimal MPPrice { get; set; }
        public decimal EnteredPieces { get; set; }
     

        public decimal NumberoFPieces { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Createdate { get; set; }



        public virtual Product Product { get; set; }
    }
}
