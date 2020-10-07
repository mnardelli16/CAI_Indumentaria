using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Consola
{
    public static class ConsolaHelper
    {
        public static void MostrarMensaje(string s)
        {
            Console.WriteLine(s);
        }
        public static void MostrarMensaje(string s, int a, double d)
        {
            Console.WriteLine(s, a, d);
        }
        public static string PedirEleccionMenu()
        {
            Console.Write("Por favor seleccione una opcion del menu: ");
            return Console.ReadLine();
        }
        public static string SeguirMenu()
        {
            Console.Write("Desea continuar en el sistema S/N: ");
            return Console.ReadLine();
        }
    }
}
