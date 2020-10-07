using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Consola
{
    public static class Validaciones
    {
        public static bool ValidarOpcionDelMenu(string a)
        {
            bool flag = false;

            if (!Int32.TryParse(a, out int salida))
            {
                ConsolaHelper.MostrarMensaje("No es una opcion valida");
            }
            else if (salida <= 0 || salida > 8)
            {
                ConsolaHelper.MostrarMensaje("No es una opcion valida");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

    }
}
