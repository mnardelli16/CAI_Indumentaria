using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entidades
{
    public class Cliente
    {
        private int _codigo;
        private string _apellido;
        private string _nombre;

        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
    }
}
