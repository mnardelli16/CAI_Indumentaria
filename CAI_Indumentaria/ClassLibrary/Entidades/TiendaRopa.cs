using ClassLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
        }

        public int UltimoCodigoIndume
        {
            get { return GetProximoCodigoIndum(); }
        }
        public int GetProximoCodigoIndum()
        {
            int prox = _ultimocodigoIndumentaria + 1;
            this._ultimocodigoIndumentaria = prox;
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
            if (I is null)
            {
                throw new Exception("No existe dicho codigo en al lista");
            }
            else
            {
                _inventario.Remove(I);
            }

        }
    }
}
