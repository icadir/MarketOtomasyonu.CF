using Market.BLL.Helper;
using Market.BLL.Repository;
using Market.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA.KayıtFormları
{
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }

        public CokluUrunEkle cokluurunform;
        private void CategoryEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                new CategoryRepo().Insert(new Category
                {
                    CName = txtCategoryName.Text,
                    KDV = nuKDV.Value,

                });
                MessageBox.Show("Kategori Kaydedildi.");
             
            }
            catch (Exception ex)
            {

                throw;
            }
            cokluurunform.cmbCategory.DataSource = CategoryHelper.GetAllCategories();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
