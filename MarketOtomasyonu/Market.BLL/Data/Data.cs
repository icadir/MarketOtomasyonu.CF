using System;
using System.Linq;
using Market.BLL.Repository;
using Market.Models.Entities;

namespace Market.BLL.Data
{
    public class Data
    {
        public void GenerateData()
        {
            if (new CategoryRepo().GetAll().Any() || new ProductRepo().GetAll().Any()) return;

            produce_Category();

            produce_product();
            prodecu_MultiProduct();

        }


        private void produce_Category()
        {
            Category category = null;
            try
            {
                for (int i = 1; i < 6; i++)
                {
                    switch (i)
                    {
                      
                        case 1:
                            category = new Category()
                            {
                                CName = "Tatlılar",
                                KDV = 0.2m,
                            };
                            break;
                        case 2:
                            category = new Category()
                            {
                                CName = "Şekerleme",
                                KDV = 0.2m,
                            };
                            break;
                        case 3:
                            category = new Category()
                            {
                                CName = "Temizlik",
                                KDV = 0.3m,
                            };
                            break;
                        case 4:
                            category = new Category()
                            {
                                CName = "Yemekler",
                                KDV = 0.1m,
                            };
                            break;
                        case 5:
                            category = new Category()
                            {
                                CName = "İçecekler",
                                KDV = 0.3m,
                            };
                            break;
                    }

                    new CategoryRepo().Insert(category);
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        private void produce_product()
        {

            Product product = null;
            try
            {
                for (int i = 1; i < 11; i++)
                {
                    switch (i)
                    {
                        case 1:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Cola",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 5,
                                Barkod = "12345",
                                Stock = 1000,

                            };
                            break;
                        case 2:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Fanta",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 5,
                                Barkod = "22222",
                                Stock = 1000,
                            };

                            break;
                        case 3:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Ayran",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 5,
                                Barkod = "33333",
                                Stock = 1000,
                            };
                            break;
                        case 4:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Sütlac",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 1,
                                Barkod = "44444",
                                Stock = 1000,
                            };
                            break;
                        case 5:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Puding",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 1,
                                Barkod = "66666",
                                Stock = 1000,
                            };
                            break;
                        case 6:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Eldiven",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 3,
                                Barkod = "77777",
                                Stock = 1000,
                            };
                            break;
                        case 7:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Sabun",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 3,
                                Barkod = "88888",
                                Stock = 1000,
                            };
                            break;
                        case 8:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Bayram Şekeri",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 2,
                                Barkod = "99999",
                                Stock = 1000,
                            };
                            break;
                        case 9:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Kurabiye",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 2,
                                Barkod = "01011",
                                Stock = 1000,
                            };
                            break;
                        case 10:
                            product = new Product()
                            {
                                PPiece = 1m,
                                PName = "Tavuk",
                                PExplanation = "Tane Urun ",
                                UBPrice = 1m,
                                UPicture = null,
                                CategoryId = 4,
                                Barkod = "02022",
                                Stock = 1000,
                            };
                            break;

                    }

                    new ProductRepo().Insert(product);

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void prodecu_MultiProduct()
        {
            Random rnd = new Random();
            
            try
            {
                MultiProduct multiProduct = null;
                for (int i = 1; i < 6; i++)
                {
                    switch (i)
                    {
                        case 1:
                            multiProduct = new MultiProduct()
                            {
                                MPBarkod = "11111111111",
                                MPPiece = 12m,
                                MPPrice = 29m,
                                MPExplanation = "4x3 = 12 adet ",
                                MPPicture = null,
                                UrunId = rnd.Next(1,11),
                            };
                            break;
                        case 2:
                            multiProduct = new MultiProduct()
                            {
                                MPBarkod = "11111111112",
                                MPPiece = 15m,
                                MPPrice = 14m,
                                MPExplanation = "5x3 = 15 adet ",
                                MPPicture = null,
                                UrunId = rnd.Next(1, 11),
                            };
                            break;
                        case 3:
                            multiProduct = new MultiProduct()
                            {
                                MPBarkod = "11111111113",
                                MPPiece = 20m,
                                MPPrice = 22m,
                                MPExplanation = "4x5 = 20 adet ",
                                MPPicture = null,
                                UrunId = rnd.Next(1, 11),
                            };
                            break;
                        case 4:
                            multiProduct = new MultiProduct()
                            {
                                MPBarkod = "11111111115",
                                MPPiece = 10m,
                                MPPrice = 15m,
                                MPExplanation = "5x2 = 10 adet ",
                                MPPicture = null,
                                UrunId = rnd.Next(1, 11),
                            };
                            break;
                        case 5:
                            multiProduct = new MultiProduct()
                            {
                                MPBarkod = "11111111115",
                                MPPiece = 30m,
                                MPPrice = 50m,
                                MPExplanation = "6x5 = 30 adet ",
                                MPPicture = null,
                                UrunId = rnd.Next(1, 11),
                            };
                            break;
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
