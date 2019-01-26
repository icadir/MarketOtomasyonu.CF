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

namespace Market.WFA.SatısIslemleri
{
    public partial class SatısForm : Form
    {
        public SatısForm()
        {
            InitializeComponent();
        }

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
                        break;
                    }
                    case 11:
                    {
                        var bulunancok = new MultiProductRepo().GetAll(x => x.MPBarkod == a).FirstOrDefault();
                        break;
                    }
                    default:
                        MessageBox.Show("Yanlıs Giris Yaptınız Tekrar Deneyin.");
                        break;
                }
            }
        }
    }
}
