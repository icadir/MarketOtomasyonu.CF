using Market.BLL.Helper;
using Market.BLL.Repository;
using Market.Models.Entities;
using Market.Models.ViewModels;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Market.WFA.KayıtFormları
{
    public partial class CokluUrunEkle : Form
    {
        public CokluUrunEkle()
        {
            InitializeComponent();
        }

        private void CokluUrunEkle_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = CategoryHelper.GetAllCategories();

        }
        private CategoryViewModel SelectedCategory;
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem == null) return;
            SelectedCategory = cmbCategory.SelectedItem as CategoryViewModel;
            cmbProduct.DataSource = ProductHelper.ProductBroughtBySelectedCategory(SelectedCategory);
        }

        private void btnMultiAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedItem == null) return;
            try
            {
                new MultiProductRepo().Insert(new MultiProduct
                {
                    MPBarkod = txtBarkod.Text,
                    MPExplanation = richExplanation.Text,
                    MPPiece = nuPiece.Value,
                    MPPrice = nuPrice.Value,
                    UrunId = (cmbProduct.SelectedItem as ProductViewModel).ProdcutId,
                    MPPicture = resimArray,
                });
                MessageBox.Show("Yeni Ürün Eklendi.");
                this.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        MemoryStream memoryStream = new MemoryStream();
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        private Image resim;

        private void btnPictureSelect_Click(object sender, EventArgs e)
        {
            openPictureDialog.Title = "Bir fotoğraf dosyasını seçiniz";
            openPictureDialog.Filter = "JPG | *.jpg";
            openPictureDialog.Multiselect = false;
            openPictureDialog.FileName = string.Empty;
            openPictureDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (openPictureDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream dosya = File.Open(openPictureDialog.FileName, FileMode.Open);
                while (dosya.Read(resimArray, 0, bufferSize) != 0)
                {
                    memoryStream.Write(resimArray, 0, resimArray.Length);
                }
                dosya.Close();
                dosya.Dispose();
                MultiProductPicture.Image = new Bitmap(memoryStream);
                resim = MultiProductPicture.Image;
            }
        }

        private void btnMCategoryAdd_Click(object sender, EventArgs e)
        {
            KategoriEkle kategoriForm = new KategoriEkle();
            kategoriForm.cokluurunform = this;
            kategoriForm.Show();
        }

        private void btnMProductAdd_Click(object sender, EventArgs e)
        {
            UrunEkle urunForm = new UrunEkle();
            urunForm.coklurunform2 = this;
            urunForm.Show();
        }
    }
}
