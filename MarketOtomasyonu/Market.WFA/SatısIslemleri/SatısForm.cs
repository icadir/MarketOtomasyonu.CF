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
                                bool varmi = false;
                                var sepettekiVarOlanurunler = new BasketViewModel();
                                foreach (var sepetViewModel in sepet)
                                {
                                    if (bulunan.Id == sepetViewModel.UrunId)
                                    {
                                        varmi = true;
                                        sepettekiVarOlanurunler = sepetViewModel;
                                        break;
                                    }
                                }

                                if (varmi)
                                {
                                    sepettekiVarOlanurunler.GPiece += nuAdet.Value;
                                }
                                else
                                {
                                    sepet.Add(new BasketViewModel
                                    {

                                        UrunId = bulunan.Id,
                                        MultiUrunId = 0,
                                        BPiece = bulunan.PPiece,
                                        BPrice = bulunan.UBPrice,
                                        Explanation = bulunan.PExplanation,
                                        GPiece = nuAdet.Value,
                                        ProductName = bulunan.PName,
                                    });
                                }
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
                                bool varmi = false;
                                var sepettekiVarOlanurunler = new BasketViewModel();
                                foreach (var sepetViewModel in sepet)
                                {
                                    if (bulunancok.Id == sepetViewModel.MultiUrunId)
                                    {
                                        varmi = true;
                                        sepettekiVarOlanurunler = sepetViewModel;
                                        break;
                                    }
                                }

                                if (varmi)
                                {
                                    sepettekiVarOlanurunler.GPiece += nuAdet.Value;
                                }
                                else
                                {
                                    sepet.Add(new BasketViewModel
                                    {
                                        UrunId = bulunancok.Product.Id,
                                        MultiUrunId = bulunancok.Id,
                                        BPiece = bulunancok.MPPiece,
                                        BPrice = bulunancok.MPPrice,
                                        Explanation = bulunancok.MPExplanation,
                                        GPiece = nuAdet.Value,
                                        ProductName = bulunancok.Product.PName,
                                    });

                                }


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

        private decimal anatoplam;
        private void SepetHesapla()
        {
            lstSatılacakurunler.Items.Clear();
            foreach (var item in sepet)
            {
                lstSatılacakurunler.Items.Add(item);
            }

            var tutar = sepet.Sum(x => x.BPrice * x.GPiece);
            lblToplamFiyat.Text = $"Toplam Fiyat : {tutar:c2}";
            anatoplam = tutar;
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            pnlOdemeAl.Visible = true;
            pnlBarkod.Visible = false;
            lstSatılacakurunler.Visible = false;
            pnlPoset.Visible = false;

        }
        private int posetSayisi = 0;
        private decimal posetFiyat;
     
        private void cbPoset_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPoset.Checked == true)
            {
                nuPoset.Visible = true;
            }
            else if (cbPoset.CheckState == CheckState.Unchecked)
                posetSayisi = 0;
        }

        private void nuPoset_KeyUp(object sender, KeyEventArgs e)
        {
            posetSayisi = (int)nuPoset.Value;
            posetFiyat = Convert.ToDecimal(posetSayisi * 0.25);
            anatoplam = anatoplam + posetFiyat;
            lblToplamFiyat.Text = $"Toplam: {anatoplam:c2}";
        }

        private void nuPoset_ValueChanged(object sender, EventArgs e)
        {
            posetSayisi = (int)nuPoset.Value;
            posetFiyat = Convert.ToDecimal(posetSayisi * 0.25);
            anatoplam = anatoplam + posetFiyat;
            lblToplamFiyat.Text = $"Toplam: {anatoplam:c2}";
        }

        
    }
}
