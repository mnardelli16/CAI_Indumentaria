using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class TipoIndumentaria
    {
        private string _origen;
        private double _porcentajeAlgodon;

        public string Origen
        {
            get { return this._origen; }
            set { this._origen = value; }
        }
        public double PorcentajeAlgodon
        {
            get { return this._porcentajeAlgodon; }
            set { this._porcentajeAlgodon = value; }
        }

        public TipoIndumentaria(int origen)
        {
            this._origen = ResolverOrigen(origen);
            this._porcentajeAlgodon = ResolverAlgodon(origen);
        }


        public enum TipoIndumen
        {
            IndumentariaCasual = 1,
            IndumentariaDeportiva = 2,
            IndumentariaFormal = 3
        }

        public string ResolverOrigen(int a)
        {
            string ad = "";
            if(a == Convert.ToInt32(TipoIndumen.IndumentariaCasual))
            {
                ad = "IndumentariaCasual";
            }
            else if (a == Convert.ToInt32(TipoIndumen.IndumentariaDeportiva))
            {
                ad = "IndumentariaDeportiva";
            }
            else if (a == Convert.ToInt32(TipoIndumen.IndumentariaFormal))
            {
                ad = "IndumentariaFormal";
            }
            return ad;
        }

        public double ResolverAlgodon(int a)
        {
            double ad = 0;
            if (a == Convert.ToInt32(TipoIndumen.IndumentariaCasual))
            {
                ad = 0.80f;
            }
            else if (a == Convert.ToInt32(TipoIndumen.IndumentariaDeportiva))
            {
                ad = 0.90f;
            }
            else if (a == Convert.ToInt32(TipoIndumen.IndumentariaFormal))
            {
                ad = 0.70f;
            }
            return ad;
        }

    }
}
