using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Camisa:Indumentaria
    {
        private bool _tieneEstampado;
        private string _tipoManga;

        public bool TieneEstampado
        {
            get { return this._tieneEstampado; }
            set { this._tieneEstampado = value; }
        }
        public string TipoManga
        {
            get { return this._tipoManga; }
            set { this._tipoManga = value; }
        }

        public Camisa(int codigo,string talle, double precio, TipoIndumentaria tipo) : base(codigo,talle, precio, tipo)
        {
            this._tipoManga = "CORTA";
            this._tieneEstampado = false;
        }

        public override string GetDetalle()
        {
            return string.Format("Codigo: {0} - Modelo: CAMISA - Tipo de Indumentaria: {1} - Estampado: {2} - Tipo de manga: {3} \nPrecio: {4} - Talle: {5} - Stock: {6}", this._codigo,this.Tipo.Origen,this._tieneEstampado,this._tipoManga,this._precio, this._talle, this._stock);
        }
    }
}
