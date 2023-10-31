using System;

namespace Ejercicio1Clases
{
    internal class Articulo
    {
        private static int nArticulos;

        private int codigoArticulo;
        private String nombreArticulo;
        private String categoriaArticulo;
        private decimal precioArticulo;
        private int existenciasArticulo;

        public Articulo()
        {

        }

        public Articulo(string nombreArticulo, string categoriaArticulo, decimal precioArticulo, int existenciasArticulo)
        {
            this.codigoArticulo = ++nArticulos;
            this.nombreArticulo = nombreArticulo;
            this.categoriaArticulo = categoriaArticulo;
            this.precioArticulo = precioArticulo;
            this.existenciasArticulo = existenciasArticulo;
        }

        public static int NArticulos { get => nArticulos; set => nArticulos = value; }
        public int CodigoArticulo { get => codigoArticulo; set => codigoArticulo = value; }
        public string NombreArticulo { get => nombreArticulo; set => nombreArticulo = value; }

        public String ActualizarExistencias(int cantidadPedido)
        {
            String exit;
            if ((this.existenciasArticulo - cantidadPedido) >= 0)
            {
                this.existenciasArticulo -= cantidadPedido;
                decimal importePedido = (cantidadPedido * this.precioArticulo);

                exit = $"Pedido realizado correctamente \n Total: {importePedido}\n\n" +
                    $"Cantidades restantes: {existenciasArticulo}";
            }
            else
            {
                exit = $"No tenemos suficientes exixtencias\n\n" +
                    $"Cantidades restantes: {existenciasArticulo}";
            }
            return exit;
        }

        public override string ToString()
        {
            return $"Codigo : {codigoArticulo} {nombreArticulo} Categoria: {categoriaArticulo} " +
                $"Precio: {precioArticulo} Existencias: {existenciasArticulo}";
        }
    }
}
