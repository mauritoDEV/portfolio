using BARBERIA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaColecciones
{


    static class Program
    {
        public static ColeccionDePersonas colPersonas;
        public static ColeccionProductos colproductos;
        public static ColeccionTurnos colTurnos;
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            colPersonas = new ColeccionDePersonas();
            colproductos = new ColeccionProductos();
            colTurnos = new ColeccionTurnos();
            Application.Run(new Barberia());
        }
    }
}

