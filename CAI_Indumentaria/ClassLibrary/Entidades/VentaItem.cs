﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class VentaItem
    {
        private Indumentaria _prenda;
        private int _cantidad;

        public Indumentaria Prenda
        {
            get { return this._prenda; }
        }
        public int Cantidad
        {
            get { return this._cantidad; }
            set { this._cantidad = value; }
        }

    }
}
