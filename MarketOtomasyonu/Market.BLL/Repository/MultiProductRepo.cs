using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Data.Entity.Validation;

namespace Market.BLL.Repository
{
    public class MultiProductRepo : RepositoryBase<MultiProduct, int>
    {
        public decimal AcceptProduct(MultiProductAcceptViewModel model)
        {

            using (var tran = db.Database.BeginTransaction())
            {
                try
                {
                    var AccepTime = new Acceptance
                    {
                        CreateDate = model.Createdate,
                    };
                    db.Acceptances.Add(AccepTime);
                    db.SaveChanges();

                    var product = db.Products.Find(model.UrunId);
                    product.Stock = product.Stock + (model.NumberoFPieces * model.MPPiece);
                    db.SaveChanges();

                    var detailsAdd = new AcceptanceDetail
                    {
                        Id = model.MultiProdcutId,
                        Id2 = AccepTime.Id,
                        Numberofpieces = model.MPPiece * model.NumberoFPieces,
                        TotalPrice = model.MPPrice * model.NumberoFPieces,
                    };
                    db.AcceptanceDetails.Add(detailsAdd);
                    db.SaveChanges();


                    tran.Commit();
                    db.SaveChanges();
                    return model.NumberoFPieces * model.MPPiece;
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



