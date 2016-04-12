using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            //    if (ApplicationDeployment.CurrentDeployment.CurrentVersion != ApplicationDeployment.CurrentDeployment.UpdatedVersion)
            //    {
            //        MessageBox.Show("Download last version from server");
            //        Application.ExitThread();
            //        Application.Restart();
            //    }
            //}

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
