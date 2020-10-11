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

        public Pantalon(int codigo, string talle, double precio, TipoIndumentaria tipo) : base(codigo,talle, precio, tipo)
        {
            this._material = "JEAN";
            this._tieneBolsillos = true;
        }

        public override string GetDetalle()
        {
            return string.Format("Codigo: {0} - Modelo: PANTALON - Tipo de Indumentaria: {1} - Material: {2} - Tiene Bolsillos: {3} \nPrecio: {4} - Talle: {5} - Stock: {6}", this._codigo, this.Tipo.Origen, this._material, this._tieneBolsillos,this._precio,this._talle, this._stock);
        }
    }
}
