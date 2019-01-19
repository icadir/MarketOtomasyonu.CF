using Market.BLL.Repository;
using Market.Models.ViewModels;
using System.Linq;

namespace Market.BLL.Helper
{
    public class MultiProductHelper
    {
        public static MultiProductViewModel barkodAra(string barkod)
        {
            return new MultiProductRepo().GetAll(x => x.MPBarkod == barkod).Select(x => new MultiProductViewModel
            {
                  MultiProductId=x.Id,
                MPBarkod = x.MPBarkod,
                MPPicture = x.MPPicture,
                MPPiece = x.MPPiece,
                MPPrice = x.MPPiece,
                Product = x.Product,
                MPExplanation = x.MPExplanation,
                UrunId = x.UrunId,

            }).First();

        }
    }
}
