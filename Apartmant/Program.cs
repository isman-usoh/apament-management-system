using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UI;
using System.Threading;
using System.Globalization;

namespace Apartment
{
    static class Program
    {
        public static CultureInfo cultureInfo = System.Globalization.CultureInfo.GetCultureInfo(Apartmant.Properties.Settings.Default.DateFormat);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Application.CurrentCulture = cultureInfo;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainUI());
        }
    }
}
