using ClassLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class TiendaRopa
    {
        private List<Indumentaria> _inventario;
        private List<Venta> _ventas;
        private int _ultimocodigoIndumentaria;
        private int _ultimocodigoVenta;
        private List<Cliente> _lstClientes;

        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
            _lstClientes = new List<Cliente>();
            GenerarClientes();
        }

        public int UltimoCodigoIndume
        {
            get { return GetProximoCodigoIndum(); }
        }
        public int UltimoCodigoVenta
        {
            get { return GetProximoCodigoVenta(); }
        }
        public int GetProximoCodigoIndum()
        {
            int prox = _ultimocodigoIndumentaria + 1;
            this._ultimocodigoIndumentaria = prox;
            return prox;
        }
        public int GetProximoCodigoVenta()
        {
            int prox = _ultimocodigoVenta + 1;
            this._ultimocodigoVenta = prox;
            return prox;
        }


        public void AgregarIndumentaria(Indumentaria I)
        {
            _inventario.Add(I);
        }

        public List<Indumentaria> Listar()
        {
            List<Indumentaria> aux = new List<Indumentaria>();
            foreach(Indumentaria I in _inventario)
            {
                aux.Add(I);
            }
            return aux;
        }

        public int CantidadIndumentaria()
        {
            return _inventario.Count;
        }

        public Indumentaria BuscarIndumentaria(int codigo)
        {
            return _inventario.Find(x => x.Codigo == codigo);
        }

        public void QuitarIndumentaria(Indumentaria I)
        {
            Indumentaria Mod = null;
            foreach(Indumentaria R in _inventario)
            {
                if (R.Equals(I))
                {
                    Mod = I;
                }
            }

            if(Mod == null)
            {
                throw new Exception("No existe dicho codigo en la lista");
            }
            else
            {
                _inventario.Remove(I);
            }
        }

        public void ModificarIndumentaria(Indumentaria I, string talle, double precio)
        {
            if(talle != 9.ToString())
            {
                I.Talle = talle;
            }
            I.Precio = precio;
        }

        public void IngresarOrden(Venta V)
        {
            _ventas.Add(V);
            

        }

        public void GenerarClientes()
        {
            _lstClientes.Add(new Cliente(990, "Fernandez", "Carlos"));
            _lstClientes.Add(new Cliente(991, "Nardelli", "Hector"));
            _lstClientes.Add(new Cliente(992, "Hernandez", "Jose"));
            _lstClientes.Add(new Cliente(993, "Urman", "Federico"));
        }

        public List<Cliente> MostrarClientes()
        {
            return _lstClientes;
        }

        public Cliente BuscarCliente(int codigo)
        {
            return _lstClientes.Find(x => x.Codigo == codigo);
        }

        public List<Venta> ListarOrdenes()
        {
            return _ventas;
        }


        public Venta BuscarVenta(int codigo)
        {
            return _ventas.Find(z => z.Codigo == codigo);
        }

        public void DevolerOrden(Venta V)
        {
            V.Estado = Convert.ToInt32(EstadoVenta.Devuelto);
        }
    }
}
