using Market.BLL.Repository;
using Market.WFA.IşlemFormları;
using Market.WFA.KayıtFormları;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA.UrunAlısİslemleri
{
    public partial class BarkodOkuForm : Form
    {
        public BarkodOkuForm()
        {
            InitializeComponent();
        }

        private void txtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string ara = txtBarkod.Text;
             
                if (txtBarkod.Text.Length == 11)
                {
                    var sonuc = new MultiProductRepo().GetAll(x => x.MPBarkod == ara).FirstOrDefault();
                  
                    if (sonuc==null)
                    {
                        CokluUrunEkle cke = new CokluUrunEkle();
                        cke.txtBarkod.Text = ara;
                        cke.Show();
                    }
                    else
                    {
                        UrunKabulForm ukf = new UrunKabulForm();
                        ukf.txtBarkodNoDef.Text = ara;
                        ukf.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giris Yaptınız..\nTekrar Deneyiniz.");
                }
            }
        }

       
    }
}
