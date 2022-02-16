using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Auth.Views;

namespace WinForms_Auth
{
    static class Program
    {
        public static NLog.Logger Log = NLog.LogManager.GetCurrentClassLogger();
        public static Store.AuthStore Auth = Store.AuthStore.getInstance();
        public static Data.AppDbContext _db = new Data.AppDbContext();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormBooksShop());
        }
    }
}
