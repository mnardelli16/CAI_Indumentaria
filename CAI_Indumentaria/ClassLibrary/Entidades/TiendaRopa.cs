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
        private int _ultimocodigo = 0;


        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();
        }


        public int GetProximoCodigo()
        {
            int prox = this._ultimocodigo += 1;
            return prox;
        }

        public void AgregarIndumentaria(Indumentaria I)
        {

        }
    }
}
