using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using U1;

namespace Unidad1
{
    public class program
    {
        internal static class Program
        {
            [STAThread]
            static void Main()
            {
                // Configura la aplicación para usar controles visuales y estilos modernos
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                // Indica qué formulario se abre al ejecutar
                Application.Run(new FormMenu());
            }
        }
    }
}
