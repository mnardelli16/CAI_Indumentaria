using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Resources;
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
                            ModificarIndumentaria(T);
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
                            IngresarOrden(T);
                            break;
                        }
                    case 6:
                        {
                            DevolverOrden(T);
                            break;
                        }
                    case 7:
                        {
                            ListarOrdenes(T);
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
                    flag3 = Validaciones.ValidarTalle(_talle);
                } while (!flag3);

                string _strPrecio;
                double _precio = 0;
                bool _flag4;
                do
                {
                    _strPrecio = ConsolaHelper.PedirPrecio();
                    _flag4 = Validaciones.ValidarPrecio(_strPrecio, ref _precio);
                } while (!_flag4);

                TipoIndumentaria Tipo = null; // es una clase abstracta, no se puede instanciar

                switch (_tipoindumentaria)
                {
                    case 1:
                        {
                            IndumentariaCasual Casual = new IndumentariaCasual(_tipoindumentaria);
                            Tipo = Casual;
                            break;
                        }
                    case 2:
                        {
                            IndumentariaDeportiva Deportiva = new IndumentariaDeportiva(_tipoindumentaria);
                            Tipo = Deportiva;
                            break;
                        }
                    case 3:
                        {
                            IndumentariaFormal Formal = new IndumentariaFormal(_tipoindumentaria);
                            Tipo = Formal;
                            break;
                        }
                }

                Indumentaria Aux = null; // es una clase abstracta, no se puede instanciar

                if (_modelo == 1)
                {
                    Aux = new Camisa(T.GetProximoCodigoIndum(), _talle, _precio, Tipo);
                }
                else if(_modelo == 2)
                {
                    Aux = new Pantalon(T.GetProximoCodigoIndum(), _talle, _precio, Tipo);
                }
                T.AgregarIndumentaria(Aux);
                ConsolaHelper.MostrarMensaje("Indumentaria agregada con exito");
                ConsolaHelper.MostrarMensaje(Aux.ToString());

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


                    Indumentaria A = T.BuscarIndumentaria(_codigo); // me puede devoler el objeto o un null si no lo encontro
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

        static void ModificarIndumentaria(TiendaRopa T)
        {
            try 
            {
                if (T.CantidadIndumentaria() == 0)
                {
                    throw new ListaVaciaIndumentariaException();
                }
                else
                {
                    //PIDO CODIGO A MODIFICAR
                    string _strCodigo;
                    int _codigo = 0;
                    bool flag = false;
                    do
                    {
                        _strCodigo = ConsolaHelper.PedirCodigoAModificar();
                        flag = Validaciones.ValidarCodigoIndumentaria(_strCodigo, ref _codigo);
                    } while (!flag);

                    Indumentaria A = T.BuscarIndumentaria(_codigo);

                    if(A is null)
                    {
                        throw new Exception("No existe dicho codigo de indumentaria");
                    }
                    else
                    {
                        ConsolaHelper.MostrarMensaje(A.ToString());// muestro la indumentaria que quiere modificar
                        //PIDO QUE DATOS QUIERE MODIFICAR
                        string _talle;
                        bool flag1 = false;
                        do
                        {
                            _talle = ConsolaHelper.PedirTalleAModificar();
                            flag1 = Validaciones.ValidarTalle(_talle);
                        } while (!flag1);

                        string _strPrecio;
                        double _precio = 0;
                        bool _flag4;
                        do
                        {
                            _strPrecio = ConsolaHelper.PedirPrecioAModificar();
                            _flag4 = Validaciones.ValidarPrecioAModificar(_strPrecio, ref _precio);
                        } while (!_flag4);

                        T.ModificarIndumentaria(A,_talle,_precio);
                        ConsolaHelper.MostrarMensaje("Prenda modificada con Exito!");
                    }
                }
            }
            catch (ListaVaciaIndumentariaException e)
            {
                ConsolaHelper.MostrarMensaje(e.Message);
            }
            catch(Exception r)
            {
                ConsolaHelper.MostrarMensaje(r.Message);
            }

        }

        static void IngresarOrden(TiendaRopa T)
        {
            try
            {
                //LISTO LAS INDUMENTARIAS DISPONIBLES

                if(T.CantidadIndumentaria() == 0)
                {
                    throw new ListaVaciaIndumentariaException();
                }
                else
                {
                    ListarIndumentaria(T);
                    string _salida;
                    List<VentaItem> ListaItem = new List<VentaItem>();
                    Cliente Cliente = null;
                    do
                    {
                        //PIDO LA PRENDA A INGRESAR A LA ORDEN
                        string _strCodigo;
                        int _codigo = 0;
                        bool flag = false;
                        do
                        {
                            _strCodigo = ConsolaHelper.PedirCodigoAIngresarpedido();
                            flag = Validaciones.ValidarCodigoIndumentaria(_strCodigo, ref _codigo);
                        } while (!flag);

                        Indumentaria I = T.BuscarIndumentaria(_codigo);

                        if(I is null)
                        {
                            throw new Exception("No existe dicha indumentaria");
                        }
                        else
                        {

                            //PIDO LA CANTIDAD
                            string cantidad;
                            int _cant = 0;
                            bool flag1 = false;
                            do
                            {
                                cantidad = ConsolaHelper.PedirCantidad();
                                flag1 = Validaciones.ValidarCodigoIndumentaria(cantidad, ref _cant);
                            } while (!flag1);

                            if (_cant > I.Stock)
                            {
                                throw new Exception("No puede ingresar mas del stock que existe.");
                            }

                            VentaItem Item = new VentaItem(I, _cant);

                            T.QuitarStock(I, _cant); // quito el stock al objeto

                            ListaItem.Add(Item);

                            //PEDIR SI QUIERE INGRESAR MAS

                            bool _essalida = false;
                            do
                            {
                                ConsolaHelper.MostrarMensaje("Desea seguir ingresando productos? S / N");
                                _salida = Console.ReadLine();
                                _essalida = Validaciones.ValidarSalida(_salida);
                            } while (!_essalida);


                        }


                    } while (_salida == "S");

                    //PEDIR QUE INGRESE AL CLIENTE

                    //lista de clientes
                    foreach (Cliente C in T.MostrarClientes())
                    {
                        ConsolaHelper.MostrarMensaje(C.ToString());
                    }
                    string strcliente;
                    int _cliente = 0;
                    bool flag5 = false;
                    do
                    {
                        ConsolaHelper.MostrarMensaje("Ingrese al cliente: ");
                        strcliente = Console.ReadLine();
                        flag5 = Validaciones.ValidarCliente(strcliente, ref _cliente);
                    } while (!flag5);

                    Cliente = T.BuscarCliente(_cliente);

                    if (Cliente is null)
                    {
                        throw new Exception("No existe dicho cliente");
                    }

                    Venta Venta = new Venta(ListaItem, Cliente, Convert.ToInt32(EstadoVenta.Procesada), T.GetProximoCodigoVenta());
                    T.IngresarOrden(Venta);

                    ConsolaHelper.MostrarMensaje("Venta ingresada con exito!");

                }
                
            }
            catch(ListaVaciaIndumentariaException a)
            {
                ConsolaHelper.MostrarMensaje(a.Message);
            }
            catch (Exception e)
            {
                ConsolaHelper.MostrarMensaje(e.Message);
            }
        }

        static void ListarOrdenes(TiendaRopa T)
        {
            try
            {
                if(T.ListarOrdenes().Count == 0)
                {
                    throw new Exception("Lista Vacia de ordenes");
                }
                else 
                {
                    foreach (Venta V in T.ListarOrdenes())
                    {
                        ConsolaHelper.MostrarMensaje(V.ToString());
                    }
                }

            } catch(Exception e)
            {
                ConsolaHelper.MostrarMensaje(e.Message);
            }

        }

        static void DevolverOrden(TiendaRopa T)
        {
            // Mostrarle la lista de ordenes
            try
            {
                if (T.ListarOrdenes().Count == 0)
                {
                    throw new Exception("Lista Vacia de ordenes");
                }
                else
                {
                    ConsolaHelper.MostrarMensaje("LISTA DE ORDENES");
                    foreach (Venta V in T.ListarOrdenes())
                    {
                        ConsolaHelper.MostrarMensaje(V.ToString());
                    }
                }

                //ingresar cual quiere devolver

                string _strorden;
                int _orden = 0;
                bool flag = false;
                do
                {
                    _strorden = ConsolaHelper.PedirOrden();
                    flag = Validaciones.ValidarCliente(_strorden, ref _orden);
                } while (!flag);

                Venta Ve = T.BuscarVenta(_orden);
                Venta mod = null;
                foreach(Venta V  in T.ListarOrdenes())
                {
                    if (V.Equals(Ve))
                    {
                        mod = Ve; 
                    }
                }

                if(mod is null)
                {
                    throw new Exception("Venta inexistente");
                }
                else
                {
                    T.DevolerOrden(mod);
                    ConsolaHelper.MostrarMensaje("Venta devuelta con exito");
                }

            }
            catch (Exception e)
            {
                ConsolaHelper.MostrarMensaje(e.Message);
            }

        }
    }
}
