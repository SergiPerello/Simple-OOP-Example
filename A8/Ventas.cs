using System;
using System.Collections.Generic;
using System.Text;

namespace A8
{
    class Ventas
    {
        IDictionary<string, int> d = new Dictionary<string, int>();
        void agregarVenta(string empleado, int ventas)
        {
            if (d.ContainsKey(empleado))
            {
                d[empleado] += ventas;
            }
            else
            {
                d.Add(empleado, ventas);
            }
        }
        double totalVentas()
        {
            double suma = 0;
            foreach (double item in d.Values)
            {
                suma += item;
            }
            return suma;
        }
        double mediaVentas()
        {
            return totalVentas()/d.Count;
        }
        string mejorVendedor()
        {
            string mejor = "";
            int venta = 0;
            foreach (string v in d.Keys)
            {
                if (d[v] > venta)
                {
                    mejor = v; venta = d[v];
                }
            }
            return mejor;
        }
        void despedir(string nombre)
        {
            if (d.ContainsKey(nombre))
            {
                d.Remove(nombre);
            }
        }
    }
}
