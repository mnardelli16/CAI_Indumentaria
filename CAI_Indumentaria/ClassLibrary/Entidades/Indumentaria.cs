using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public abstract class Indumentaria
    {
        protected TipoIndumentaria _tipo;
        protected int _codigo;
        protected int _stock;
        protected string _talle;
        protected double _precio;

        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public int Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }
        public string Talle
        {
            get { return this._talle; }
            set { this._talle = value; }
        }
        public double Precio
        {
            get { return this._precio; }
            set { this._precio = value; }
        }
        public TipoIndumentaria Tipo
        {
            get { return this._tipo; }
        }

        public Indumentaria()
        {

        }

        public Indumentaria(int codigo, int stock, string talle, double precio, TipoIndumentaria tipo)
        {
            this._codigo = codigo;
            this._stock = 3;
            this._talle = talle;
            this._precio = precio;
            this._tipo = tipo;
        }

        public override string ToString()
        {
            return GetDetalle(); 
        }

        public virtual string GetDetalle()
        {
            return string.Format("Tipo Indumentaria: ", this._tipo.Origen);

        }
    }
}
