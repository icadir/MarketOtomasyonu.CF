using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.DAL;
using Market.Models.Entities;

namespace Market.BLL.Helper
{
   public  class SalesDetailHelper
    {
        public static List<Sales_Detail> GetAllSalesDetails()
        {
            MyContext db = new MyContext();

            return db.SalesDetails.ToList();
        }
    }
}
