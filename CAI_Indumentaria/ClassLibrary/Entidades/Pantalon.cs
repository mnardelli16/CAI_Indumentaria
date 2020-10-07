using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Pantalon:Indumentaria
    {
        private string _material;
        private bool _tieneBolsillos;

        public string Material
        {
            get { return this._material; }
            set { this._material = value; }
        }
        public bool TieneBolsillos
        {
            get { return this._tieneBolsillos; }
            set { this._tieneBolsillos = value; }
        }

        public Pantalon(int codigo, int stock, string talle, double precio, TipoIndumentaria tipo,string material, bool tienebolsillos) : base(codigo, stock, talle, precio, tipo)
        {
            this._material = material;
            this._tieneBolsillos = tienebolsillos;
        }

        public override string GetDetalle()
        {
            return string.Format("Codigo: {0} - Tipo de Indumentaria: {1} - Material: {2} - Tiene Bolsillos: {3}", this._codigo, this.Tipo.Origen, this._material, this._tieneBolsillos);
        }
    }
}
