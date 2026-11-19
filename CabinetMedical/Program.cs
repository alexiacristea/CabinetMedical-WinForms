using System;
using System.Threading;
using System.Windows.Forms;
using CabinetMedical.AccesBD;
using CabinetMedical.Formulare;

namespace CabinetMedical
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Orice eroare netratata ajunge aici in loc sa inchida aplicatia.
            Application.ThreadException += AfiseazaEroare;

            ConexiuneBD.Initializeaza();
            Application.Run(new FormularPrincipal());
        }

        private static void AfiseazaEroare(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show(
                "A aparut o eroare neasteptata:\n\n" + e.Exception.Message,
                "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
