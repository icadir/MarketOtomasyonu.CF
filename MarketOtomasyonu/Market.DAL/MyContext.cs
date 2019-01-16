using System;
using System.Collections.Generic;
using System.Data.Entity;
using Market.Models.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.DAL
{
    public class MyContext:DbContext
    {
        public MyContext()
            :base("name=MarketCon")
        {
            
        }
     }
    }
}
