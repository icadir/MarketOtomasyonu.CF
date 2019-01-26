using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.BLL.Repository;
using Market.Models.Entities;

namespace Market.WFA.SatısIslemleri
{
    public partial class SatısForm : Form
    {
        public SatısForm()
        {
            InitializeComponent();
        }
        private List<BasketViewModel> sepet = new List<BasketViewModel>();
        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            var a = txtBarkod.Text;

            if (e.KeyCode == Keys.Enter)
            {
                switch (a.Length)
                {
                    case 5:
                        {
                            var bulunan = new ProductRepo().GetAll(x => x.Barkod == a).FirstOrDefault();
                            if (bulunan == null)
                            {
                                MessageBox.Show("Hatalı giris Yaptınız");
                            }
                            else
                            {
                                sepet.Add(new BasketViewModel
                                {

                                    UrunId = bulunan.Id,
                                    MultiUrunId = 1,
                                    BPiece = bulunan.PPiece,
                                    BPrice = bulunan.UBPrice,
                                    Explanation = bulunan.PExplanation,
                                    GPiece = nuAdet.Value,
                                    ProductName = bulunan.PName,
                                });

                            }

                            SepetHesapla();
                            break;
                        }
                    case 11:
                        {
                            var bulunancok = new MultiProductRepo().GetAll(x => x.MPBarkod == a).FirstOrDefault();
                            if (bulunancok == null)
                            {
                                MessageBox.Show("Hatalı giris Yaptınız");
                            }
                            else
                            {
                                sepet.Add(new BasketViewModel
                                {
                                    UrunId = bulunancok.Product.Id,
                                    MultiUrunId = bulunancok.Id,
                                    BPiece = bulunancok.MPPiece,
                                    BPrice = bulunancok.MPPiece,
                                    Explanation = bulunancok.MPExplanation,
                                    GPiece = nuAdet.Value,
                                    ProductName = bulunancok.Product.PName,
                                });

                            }

                            SepetHesapla();
                            break;
                        }
                    default:
                        MessageBox.Show("Yanlıs Giris Yaptınız Tekrar Deneyin.");
                        break;
                }
            }
        }

        private void SepetHesapla()
        {
            lstSatılacakurunler.Items.Clear();
            foreach (var item in sepet)
            {
                lstSatılacakurunler.Items.Add(item);
            }

            var tutar = sepet.Sum(x => x.BPrice * x.GPiece);
            lblToplamFiyat.Text = $"Toplam Fiyat : {tutar:c2}";
        }
    }
}
