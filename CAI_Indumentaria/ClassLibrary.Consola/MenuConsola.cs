using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Consola
{
    public static class MenuConsola
    {
        public static void PantallaInicio()
        {
            string _msj =
                "--------------------------------------------------------------------------------------\n" +
                "------------------------BIENVENIDO A LA TIENDA DE INDUMENTARIA------------------------\n" +
                "--------------------------------------------------------------------------------------\n" +
                "----------------      MENU:                                            ---------------\n" +
                "----------------      1 - Agregar Indumentaria                         ---------------\n" +
                "----------------      2 - Modificar Indumentaria                       ---------------\n" +
                "----------------      3 - Quitar Indumentaria                          ---------------\n" +
                "----------------      4 - Reporte de Indumentaria                      ---------------\n" +
                "----------------                                                       ---------------\n" +
                "----------------      5 - Ingresar orden de venta                      ---------------\n" +
                "----------------      6 - Devolver orden de venta                      ---------------\n" +
                "----------------      7 - Reporte de ordenes de venta                  ---------------\n" +
                "----------------      8 - Salir del sistema                            ---------------\n" +
                "--------------------------------------------------------------------------------------\n" +
                "--------------------------------------------------------------------------------------\n";

            ConsolaHelper.MostrarMensaje(_msj);
        }

        public static int PedirMenu()
        {
            string _eleccion;
            bool _flag = false;

            do
            {
                _eleccion = ConsolaHelper.PedirEleccionMenu();
                _flag = Validaciones.ValidarOpcionDelMenu(_eleccion);
            } while (!_flag);

            return Convert.ToInt32(_eleccion);

        }
    }
}
