using Market.BLL.Repository;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.BLL.Helper
{
    public class CategoryHelper
    {
        public static object GetAllCategories()
        {
            return new CategoryRepo().GetAll().Select(x => new CategoryViewModel
            {
                CategoryId = x.Id,
                CategoryName = x.CName,
                KDV = x.KDV
            }).ToList();
        }
    }
}
