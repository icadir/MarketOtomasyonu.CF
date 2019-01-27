using Market.BLL.Data;
using Market.WFA.SatısIslemleri;
using System;
using System.Windows.Forms;
using Market.WFA.UrunAlısİslemleri;

namespace Market.WFA
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            SatısForm s = new SatısForm();
            s.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            new  Data().GenerateData();
        }

        private void btnAdds_Click(object sender, EventArgs e)
        {
            BarkodOkuForm brkform= new BarkodOkuForm();
            brkform.Show();
        }

       
    }
}
