using Market.BLL.Helper;
using Market.BLL.Repository;
using Market.Models.ViewModels;
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
    }
}
