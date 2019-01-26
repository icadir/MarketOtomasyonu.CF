using Market.BLL.Repository;
using Market.Models.ViewModels;
using System.Linq;

namespace Market.BLL.Helper
{
    public static class ProductHelper
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
               .Where(x => x.CategoryId == model.CategoryId)
               .Select(x => new ProductViewModel
               {
                   ProdcutId = x.Id,
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
