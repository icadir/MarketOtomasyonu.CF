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
                    var sale = new Sales
                    {
                        SaledTime = model.SalesDate,
                        PaymentType = model.PaymentType,
                    };
                    db.Saleses.Add(sale);
                    db.SaveChanges();
                    foreach (var item in model.BasketModel)
                    {
                        db.SalesDetails.Add(new Sales_Detail
                        {
                            Id = item.MultiUrunId,
                            Id2 = sale.Id,
                            STotalPrice = (item.BPrice * item.GPiece),
                            SPiece = (item.GPiece * item.GPiece),
                        });

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
