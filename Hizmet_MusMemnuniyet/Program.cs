using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

//using Hizmet_MusMemnuniyet.Subeler;


[assembly: SuppressIldasm]
namespace Hizmet_MusMemnuniyet
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
            Application.Run(new frmAnamenu());
        }
    }
}
