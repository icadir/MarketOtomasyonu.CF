using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.WFA.SatısIslemleri;

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
    }
}
