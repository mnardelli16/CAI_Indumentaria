using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Venta
    {

        private List<VentaItem> _items;
        private Cliente _cliente;
        private int _estado;
        private int _codigo;

        public Cliente Cliente
        {
            get { return this._cliente; }
        }
        public int Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }


    }
}
