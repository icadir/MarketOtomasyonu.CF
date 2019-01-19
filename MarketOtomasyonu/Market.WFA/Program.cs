using Market.WFA.IşlemFormları;
using Market.WFA.KayıtFormları;
using Market.WFA.UrunAlısİslemleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.WFA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BarkodOkuForm());
        }
    }
}
