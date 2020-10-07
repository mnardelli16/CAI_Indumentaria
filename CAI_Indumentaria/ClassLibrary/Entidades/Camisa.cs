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

        public Camisa(int codigo, int stock, string talle, double precio, TipoIndumentaria tipo, string tipomanga, bool tieneestampado) : base(codigo, stock, talle, precio, tipo)
        {
            this._tipoManga = tipomanga;
            this._tieneEstampado = tieneestampado;
        }

        public override string GetDetalle()
        {
            return string.Format("Codigo: {0} - Tipo de Indumentaria: {1} - Estampado: {2} - Tipo de manga: {3}",this._codigo,this.Tipo.Origen,this._tieneEstampado,this._tipoManga);
        }
    }
}
