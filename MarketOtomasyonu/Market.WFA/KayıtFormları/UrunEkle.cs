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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        public CokluUrunEkle coklurunform2;
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {

                var sonuc = new ProductRepo().Insert(new Product
                {
                    Barkod = txtProductBarkod.Text,
                    PName = txtProductName.Text,
                    PPiece = 1,
                    Stock = 0,
                    UBPrice = nuProductPrice.Value,
                    UPicture = resimArray,
                    CategoryId = (cmbCategory.SelectedItem as CategoryViewModel).CategoryId,
                    PExplanation = $"1x1'li {txtProductName.Text}",

                });
                MessageBox.Show("Urun Eklendi.");
           
            }
            catch (Exception ex)
            {

                throw;
            }
            coklurunform2.cmbProduct.DataSource = ProductHelper.GetAllProduct();
            this.Close();
        }
        MemoryStream memoryStream = new MemoryStream();
        int bufferSize = 64;
        byte[] resimArray = new byte[64];
        private Image resim;
        private void btnPictureAdd_Click(object sender, EventArgs e)
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
                pProductImage.Image = new Bitmap(memoryStream);
                resim = pProductImage.Image;
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = CategoryHelper.GetAllCategories();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
