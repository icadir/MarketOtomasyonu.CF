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
using Market.Models.Enums;
using Market.Models.ViewModels;

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
                bool varmi = false;
                var sepettekiVarOlanurunler = new BasketViewModel();
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
                                 varmi = false;
                               
                                foreach (var sepetViewModel in sepet)
                                {
                                    if (bulunan.Barkod == sepetViewModel.Barkod)
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
                                        BPiece = bulunan.PPiece,
                                        BPrice = bulunan.UBPrice,
                                        Explanation = bulunan.PExplanation,
                                        GPiece = nuAdet.Value,
                                        ProductName = bulunan.PName,
                                    });
                                }
                            }
                            SepetHesapla();
                            txtBarkod.Focus();
                            break;
                        }
                    case 11:
                    {
                        varmi = false;
                            var bulunancok = new MultiProductRepo().GetAll(x => x.MPBarkod == a).FirstOrDefault();
                            if (bulunancok == null)
                            {
                                MessageBox.Show("Hatalı giris Yaptınız");
                            }
                            else
                            {
                                //bool varmi = false;
                                //var sepettekiVarOlanurunler = new BasketViewModel();
                                foreach (var sepetViewModel in sepet)
                                {
                                    if (bulunancok.MPBarkod== sepetViewModel.Barkod)
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
                            txtBarkod.Focus();
                            break;
                        }
                    default:
                        MessageBox.Show("Yanlıs Barkod Girisi Yaptınız Tekrar Deneyin.");
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

            anatoplam = sepet.Sum(x => x.BPrice * x.GPiece);
            lblToplamFiyat.Text = $"Toplam Fiyat : {anatoplam:c2}";

        }

        private void btnOde_Click(object sender, EventArgs e)
        {
          
            pnlBarkod.Visible = false;
            lstSatılacakurunler.Visible = false;
            pnlPoset.Visible = false;
            pnlOdemeTip.Visible = true;

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

        private bool odeme = true;

        private void btnTamamla_Click(object sender, EventArgs e)
        {
           

            var rbuttonlar = pnlOdemeTip.Controls.OfType<RadioButton>().ToArray();
            var odemeIndex = Array.IndexOf(rbuttonlar, rbuttonlar.Single(rb => rb.Checked));

            if (odeme)
            {
                if (rbNakit.Checked == true || rbKkartı.Checked == true)
                {
                    try
                    {
                        var doit = new SalesRepo();
                        var saless = new MakeSalesViewModel
                        {
                            BasketModel = sepet,
                            PaymentType = (OdemeTipi)odemeIndex,

                        };

                        var finishim = doit.MakeSales(saless);
                        MessageBox.Show($"{finishim} nolu satış yapıldı.");


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Satıs Yaparken Bir hata olustu" + ex.Message);

                    }
                }
            }
           



        }

        private void rbNakit_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNakit.Checked)
            {
                pnlOdemeAl.Visible = true;
                pnlPesinpanel.Visible = true;
                btnTamamla.Visible = false ;

            }
        }

        private void rbKkartı_CheckedChanged(object sender, EventArgs e)
        {
            pnlPesinpanel.Visible = false;
            pnlOdemeAl.Visible = true;
            btnTamamla.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            if (txtNakit == null || txtNakit.Text == "")
            {
                MessageBox.Show("Lütfen Nakit Girisi Yapınız.");
            }
            else
            {
                var GirilenNakit = Convert.ToDecimal(txtNakit.Text);
                if (GirilenNakit >= anatoplam)
                {
                    lblParaüstü.Visible = true;
                    lblParaüstü.Text = $"Para Üstü:{(GirilenNakit - anatoplam):c2}";
                    odeme = true;
                    btnTamamla.Visible = true;
                }
                else
                {
                    odeme = false;
                    MessageBox.Show("Girilen Para Yeterli degil. Tekrar Giiriniz");
                    txtNakit.Focus();
                }
            }
        }
    }
}
