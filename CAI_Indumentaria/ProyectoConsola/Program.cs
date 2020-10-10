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
                            QuitarIndumentaria(T);
                            break;
                        }
                    case 4:
                        {
                            ListarIndumentaria(T);
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
            try
            {
                //PIDO DATOS AL USUARIO
                string _STRtipoindumentaria;
                int _tipoindumentaria = 0;
                bool flag1 = false;
                do
                {
                    _STRtipoindumentaria = ConsolaHelper.PedirTipoIndumentaria();
                    flag1 = Validaciones.ValidarTipoIndumentaria(_STRtipoindumentaria, ref _tipoindumentaria);
                } while (!flag1);

                string _STRmodelo;
                int _modelo = 0;
                bool flag2 = false;
                do
                {
                    _STRmodelo = ConsolaHelper.PedirModelo();
                    flag2 = Validaciones.ValidarModelo(_STRmodelo, ref _modelo);
                } while (!flag2);

                string _talle;
                bool flag3 = false;
                do
                {
                    _talle = ConsolaHelper.PedirTalle();
                    flag3 = Validaciones.ValidarTalle(_STRmodelo);
                } while (!flag3);

                string _strPrecio;
                double _precio = 0;
                bool _flag4;
                do
                {
                    _strPrecio = ConsolaHelper.PedirPrecio();
                    _flag4 = Validaciones.ValidarPrecio(_strPrecio, ref _precio);
                } while (!_flag4);

                TipoIndumentaria Tipo = new TipoIndumentaria(_tipoindumentaria);
                
                if(_modelo == 1)
                {
                    Camisa C = new Camisa(T.GetProximoCodigoIndum(),_talle, _precio, Tipo);
                    T.AgregarIndumentaria(C);
                    ConsolaHelper.MostrarMensaje("Indumentaria agregada con exito");
                    ConsolaHelper.MostrarMensaje(C.ToString());
                }
                else if(_modelo == 2)
                {
                    Pantalon P = new Pantalon(T.GetProximoCodigoIndum(), _talle, _precio, Tipo);
                    T.AgregarIndumentaria(P);
                    ConsolaHelper.MostrarMensaje("Indumentaria agregada con exito");
                    ConsolaHelper.MostrarMensaje(P.ToString());
                }

            }
            catch (Exception e)
            {
                ConsolaHelper.MostrarMensaje(e.Message);
            }
        }

        public static void ListarIndumentaria(TiendaRopa T)
        {
            try
            {
                if (T.CantidadIndumentaria() == 0)
                {
                    throw new ListaVaciaIndumentariaException();
                }
                else
                {
                    foreach(Indumentaria I in T.Listar())
                    {
                        ConsolaHelper.MostrarMensaje(I.ToString());
                    }
                }

            }
            catch(ListaVaciaIndumentariaException e)
            {
                ConsolaHelper.MostrarMensaje(e.Message);
            }
        }

        static void QuitarIndumentaria(TiendaRopa T)
        {
            try
            {
                if (T.CantidadIndumentaria() == 0)
                {
                    throw new ListaVaciaIndumentariaException();
                }
                else
                {
                    //PIDO CODIGO A QUITAR
                    string _strCodigo;
                    int _codigo = 0;
                    bool flag = false;
                    do
                    {
                        _strCodigo = ConsolaHelper.PedirCodigoAQuitar();
                        flag = Validaciones.ValidarCodigoIndumentaria(_strCodigo, ref _codigo);
                    } while (!flag);


                    Indumentaria A = T.BuscarIndumentaria(_codigo);
                    T.QuitarIndumentaria(A);
                    ConsolaHelper.MostrarMensaje("Indumentaria eliminada con exito");
                }
            }
            catch (ListaVaciaIndumentariaException e)
            {
                ConsolaHelper.MostrarMensaje(e.Message);
            }
            catch(Exception x)
            {
                ConsolaHelper.MostrarMensaje(x.Message);
            }


        }

    }
}
