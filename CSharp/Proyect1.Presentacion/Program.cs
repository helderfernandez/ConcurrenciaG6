using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;
using Preyecto1.RN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect1.Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmVector());

            Summary Sumary = BenchmarkRunner.Run<RNVector>();
            Console.WriteLine(Sumary);
        }
    }
}
