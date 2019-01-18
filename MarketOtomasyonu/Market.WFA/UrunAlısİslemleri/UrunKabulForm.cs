using Market.BLL.Helper;
using Market.BLL.Repository;
using Market.Models.Entities;
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
            nuPrice.Value= bulunan.MPPrice;
            richExplanation.Text = bulunan.MPExplanation;

        }
    }
}
