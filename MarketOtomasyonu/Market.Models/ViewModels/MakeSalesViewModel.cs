using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Entities;
using Market.Models.Enums;

namespace Market.Models.ViewModels
{
    public class MakeSalesViewModel
    {
        public List<BasketViewModel> BasketModel { get; set; }
        public DateTime SalesDate { get; set; } = DateTime.Now;
        public OdemeTipi PaymentType { get; set; }
    }
}
