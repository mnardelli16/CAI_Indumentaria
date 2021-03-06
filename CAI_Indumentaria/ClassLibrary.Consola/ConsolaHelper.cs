﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Consola
{
    public static class ConsolaHelper
    {
        public static void MostrarMensaje(string s)
        {
            Console.WriteLine(s);
        }
        public static void MostrarMensaje(string s, int a, double d)
        {
            Console.WriteLine(s, a, d);
        }
        public static string PedirEleccionMenu()
        {
            Console.Write("Por favor seleccione una opcion del menu: ");
            return Console.ReadLine();
        }
        public static string SeguirMenu()
        {
            Console.Write("Desea continuar en el sistema S/N: ");
            return Console.ReadLine();
        }
        public static string PedirTipoIndumentaria()
        {
            Console.WriteLine("Seleccione el tipo de indumentaria:\n 1 - IndumentariaCasual \n 2 - IndumentariaDeportiva \n 3 - IndumentariaFormal ");
            return Console.ReadLine();
        }

        public static string PedirModelo()
        {
            Console.Write("Seleccione 1 para camisa y 2 para pantalon: ");
            return Console.ReadLine();
        }

        public static string PedirTalle()
        {
            Console.Write("Seleccione el talle: ");
            return Console.ReadLine();
        }
        public static string PedirPrecio()
        {
            Console.Write("Ingrese el precio de la prenda: ");
            return Console.ReadLine();
        }

        public static string PedirCodigoAQuitar()
        {
            Console.Write("Ingrese el codigo de indumentaria a eliminar: ");
            return Console.ReadLine();
        }
        public static string PedirCodigoAModificar()
        {
            Console.Write("Ingrese el codigo de indumentaria a modificar: ");
            return Console.ReadLine();
        }

        public static string PedirTalleAModificar()
        {
            Console.Write("Ingrese el talle a modificar o 9 para saltear este paso: ");
            return Console.ReadLine();
        }

        public static string PedirPrecioAModificar()
        {
            Console.Write("Ingrese el precio a modificar o 'S' para saltear este paso: ");
            return Console.ReadLine();
        }

        public static string PedirCodigoAIngresarpedido()
        {
            Console.Write("Ingrese el codigo de indumentaria a vender: ");
            return Console.ReadLine();
        }
        public static string PedirCantidad()
        {
            Console.Write("Ingrese la cantidad: ");
            return Console.ReadLine();
        }
        public static string PedirOrden()
        {
            Console.Write("Ingrese el numero de orden a devolver: ");
            return Console.ReadLine();
        }
    }
}
