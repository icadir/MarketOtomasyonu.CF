using Market.BLL.Repository;
using Market.Models.ViewModels;
using System.Linq;

namespace Market.BLL.Helper
{
    public class ProductHelper
    {
        public static object GetAllProduct()
        {
            return new ProductRepo().GetAll().Select(x => new ProductViewModel
            {
                Barkod = x.Barkod,
                Category = x.Category,
                CategoryId = x.CategoryId,
                PName = x.PName,
                PPiece = x.PPiece,
                Stock = x.Stock,
                UBPrice = x.UBPrice,
                UPicture = x.UPicture,
            }).ToList();
        }
        public static object ProductBroughtBySelectedCategory(CategoryViewModel model)
        {
           return new ProductRepo().GetAll()
               .Where(x => x.Id == model.CategoryId)
               .Select(x => new ProductViewModel
               {
                   Barkod = x.Barkod,
                   Category = x.Category,
                   CategoryId = x.CategoryId,
                   PName = x.PName,
                   PPiece = x.PPiece,
                   Stock = x.Stock,
                   UBPrice = x.UBPrice,
                   UPicture = x.UPicture,
               }).ToList();
        }
    }
}
