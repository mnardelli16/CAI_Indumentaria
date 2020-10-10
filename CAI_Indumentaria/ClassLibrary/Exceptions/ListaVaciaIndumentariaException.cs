using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Exceptions
{
    public class ListaVaciaIndumentariaException: Exception
    {
        public ListaVaciaIndumentariaException():base ("La lista se encuentra vacia")
        {

        }
    }
}
