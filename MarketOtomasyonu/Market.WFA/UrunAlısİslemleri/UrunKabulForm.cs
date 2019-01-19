using Market.BLL.Helper;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA.IşlemFormları
{
    public partial class UrunKabulForm : Form
    {
        public UrunKabulForm()
        {
            InitializeComponent();
        }
        private MultiProductViewModel bulunan;
        private void UrunKabulForm_Load(object sender, EventArgs e)
        {
            string barkod = txtBarkodNoDef.Text;
            bulunan = MultiProductHelper.barkodAra(barkod);
            FormDoldur(bulunan);
        }

        private void FormDoldur(MultiProductViewModel bulunan)
        {
            txtCategoryName.Text = bulunan.Product.Category.CName;
            txtProductName.Text = bulunan.Product.PName;
            nuPiece.Value = bulunan.MPPiece;
            nuPrice.Value = bulunan.MPPrice;
            richExplanation.Text = bulunan.MPExplanation;

        }

        private void btnMultiAdd_Click(object sender, EventArgs e)
        {
            var EnteredPiece = nuTakenPieces.Value;

            try
            {
                MultiProductAcceptViewModel Model = new MultiProductAcceptViewModel
                {
                    Createdate = DateTime.Now,
                    MPPiece = bulunan.MPPiece,
                    MPPrice = bulunan.MPPrice,
                    UrunId = bulunan.UrunId,
                    NumberoFPieces = nuTakenPieces.Value,
                    MultiProdcutId = bulunan.MultiProductId,
                };
                var sonuc = new MultiProductRepo().AcceptProduct(Model);
                MessageBox.Show($"{bulunan.Product.PName} ürününden {sonuc} adet alındı ve stoga eklendi.");
            }
            catch (DbEntityValidationException ex)
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
