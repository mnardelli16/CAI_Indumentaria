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

        public static bool ValidarTipoIndumentaria(string a, ref int salida)
        {
            bool flag = false;

            if (!Int32.TryParse(a, out salida))
            {
                ConsolaHelper.MostrarMensaje("No es una opcion valida");
            }
            else if(salida < 0 || salida > 3)
            {
                ConsolaHelper.MostrarMensaje("No es una opcion valida");
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        public static bool ValidarModelo(string a, ref int salida)
        {
            bool flag = false;

            if (!Int32.TryParse(a, out salida))
            {
                ConsolaHelper.MostrarMensaje("No es una opcion valida");
            }
            else if (salida < 0 || salida > 2)
            {
                ConsolaHelper.MostrarMensaje("No es una opcion valida");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public static bool ValidarTalle(string a)
        {
            bool flag = false;
            if (string.IsNullOrWhiteSpace(a))
            {
                ConsolaHelper.MostrarMensaje("No debe dejar espacios en blanco");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public static bool ValidarPrecio(string a, ref double salida)
        {
            bool flag = false;

            if (!double.TryParse(a, out salida))
            {
                ConsolaHelper.MostrarMensaje("Debe ingresar un numero");
            }
            else if (salida <= 0)
            {
                ConsolaHelper.MostrarMensaje("El precio debe ser mayor a 0");
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        public static bool ValidarCodigoIndumentaria(string a, ref int salida)
        {
            bool flag = false;

            if (!Int32.TryParse(a, out salida))
            {
                ConsolaHelper.MostrarMensaje("No es una opcion valida");
            }
            else if (salida < 0)
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
