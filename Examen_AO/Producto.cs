using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Examen_AO
{
    public class Producto
    {
        public static List<Producto> productos = new List<Producto>();

        private int codPro;
        private string nombPro;
        private double precioPro;
        private int stockPro;

        public int CodPro { get => codPro; set => codPro = value; }
        public string NombPro { get => nombPro; set => nombPro = value; }
        public double PrecioPro { get => precioPro; set => precioPro = value; }
        public int StockPro { get => stockPro; set => stockPro = value; }

        public Producto(int codPro, string nombPro, double precioPro, int stockPro)
        {
            this.CodPro = codPro;
            this.NombPro = nombPro;
            this.PrecioPro = precioPro;
            this.StockPro = stockPro;
        }

        public static void CrearProductosDemo()
        {
            for (int i = 1; i < 10; i++)
            {
                productos.Add(new Producto(i, $"Producto {i}", Double.Parse((i * 10).ToString()), i * 100));
            }
            MessageBox.Show("Productos creados");
        }

        public static Producto BuscarProducto(int codPro)
        {
            foreach (Producto producto in productos)
            {
                if (producto.CodPro == codPro)
                {
                    return producto;
                }
            }
            return null;
        }
    }
}
