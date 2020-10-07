using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Consola;
using ClassLibrary.Entidades;
using ClassLibrary.Exceptions;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            TiendaRopa T = new TiendaRopa();

            MenuConsola.PantallaInicio();

            int _opcion;
            int salida = 0;

            do
            {
                _opcion = MenuConsola.PedirMenu();

                switch (_opcion)
                {
                    case 1:
                        {
                            AgregarIndumentaria(T);
                            break;
                        }
                    case 2:
                        {
                             
                            break;
                        }
                    case 3:
                        {
                             
                            break;
                        }
                    case 4:
                        {
                             
                            break;
                        }
                    case 5:
                        {
                             
                            break;
                        }
                    case 6:
                        {
                             
                            break;
                        }
                    case 7:
                        {
                            
                            break;
                        }
                    case 8:
                        {
                            salida = 8;
                            break;
                        }
                }

            } while (salida != 8);

            ConsolaHelper.MostrarMensaje("HASTA LUEGO");

            //System.Console.Clear();

            Console.ReadKey();



        }

        static void AgregarIndumentaria(TiendaRopa T)
        {

        }
    }
}
