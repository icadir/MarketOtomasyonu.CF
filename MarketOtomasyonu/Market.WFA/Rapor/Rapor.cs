using Market.BLL.Helper;
using Market.BLL.Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Market.WFA.Rapor
{
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpTarihSec.Value;
            GunlukRapor(tarih);
        }

        private void GunlukRapor(DateTime selectedDate)
        {
            var product = new ProductRepo().GetAll();
            var MultiProduct = new MultiProductRepo().GetAll();
            var Category = new CategoryRepo().GetAll();
            var sales = new SalesRepo().GetAll();
            var salesDetail = SalesDetailHelper.GetAllSalesDetails();

            var gunluk = from p in product
                join mp in MultiProduct on p.Id equals mp.UrunId
                join c in Category on p.CategoryId equals c.Id
                join sd in salesDetail on p.Id equals sd.UrunId
                join s in sales on sd.SaleId equals s.Id
                where s.SaledTime.Day == selectedDate.Date.Day
                group new
                {
                    p,
                    mp,
                    c,
                    sd,
                    s,

                } by new
                {
                    s.Id,
                    s.SaledTime,
                    p.PName,
                    c.CName,
                    sd.SPiece,
                    p.UBPrice,
                    sd.STotalPrice,
                    s.PaymentType,
                }
                into gp
                orderby gp.Key.Id
                orderby gp.Key.CName
                select new
                {
                    gp.Key.Id,
                    gp.Key.SaledTime,
                    gp.Key.PName,
                    gp.Key.CName,
                    ToplamAdet = gp.Sum(x => x.sd.SPiece),
                    gp.Key.UBPrice,
                    gp.Key.STotalPrice,
                    gp.Key.PaymentType

                };
            dgvRapor.DataSource = gunluk.ToList();


        }
    }
}
