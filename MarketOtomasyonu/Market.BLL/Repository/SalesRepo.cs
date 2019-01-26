using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Market.Models.Entities;
using Market.Models.ViewModels;

namespace Market.BLL.Repository
{
    public class SalesRepo : RepositoryBase<Sales, int>
    {
        public int MakeSales(MakeSalesViewModel model)
        {
            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var sale = new Sales()
                    {
                        SaledTime = model.SalesDate,
                        PaymentType = model.PaymentType,
                    };
                    db.Saleses.Add(sale);
                    db.SaveChanges();
                    foreach (var item in model.BasketModel)
                    {
                        var saleddetail=new Sales_Detail()
                        {
                            UrunId = item.UrunId,
                            SaleId = sale.Id,
                            STotalPrice = (item.BPrice * item.GPiece),
                            SPiece = (item.GPiece * item.BPiece),
                        };
                        db.SalesDetails.Add(saleddetail);
                        db.SaveChanges();

                    }
                    foreach (var item in model.BasketModel)
                    {
                        var urun = db.Products.Find(item.UrunId);
                        urun.Stock = urun.Stock - (item.GPiece * item.BPiece);
                        db.SaveChanges();
                    }
                    
                    tran.Commit();
                    return sale.Id;

                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw;
                }

            }

        }
    }
}
