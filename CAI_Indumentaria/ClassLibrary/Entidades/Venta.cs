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

        public Venta(List<VentaItem> item, Cliente cliente, int estado, int codigo)
        {
            this._items = item;
            this._cliente = cliente;
            this._estado = estado;
            this._codigo = codigo;


        }

        public double GetTotalPedido()
        {
            double suma = 0;
            foreach(VentaItem I in _items)
            {
                suma += I.GetTotal();
            }

            return suma;
        }

        public override string ToString()
        {
            //return string.Format("Codgo: {4} - Cantidad de productos: {0} - TOTAL: {1} - Cliente: {2} - Estado: {3}",this._items.Count, this.GetTotalPedido(), this._cliente, ObtenerEstado(this._estado));
            return string.Format("Codgo: {0} - Apellido: {1} - Nombre: {2} - Cantidad de prendas: {3} - TOTAL $: {4}", this._codigo, this._cliente.Apellido, this._cliente.Nombre, this._items.Count ,this.GetTotalPedido());

        }

        public string ObtenerEstado(int codigo)
        {
            if(codigo == Convert.ToInt32(EstadoVenta.Iniciada))
            {
                return "Iniciada";
            }
            if (codigo == Convert.ToInt32(EstadoVenta.Procesada))
            {
                return "Procesada";
            }
            return "Devuelta";
        }

    }
}
