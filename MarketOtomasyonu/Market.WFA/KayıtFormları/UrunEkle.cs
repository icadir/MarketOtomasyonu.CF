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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            new ProductRepo().Insert(new Product
            {
                Barkod = txtProductBarkod.Text,
                PName = txtProductName.Text,
                PPiece = 1,
                Stock = 0,
                UBPrice = nuProductPrice.Value,
                 


            });
        }
    }
}
