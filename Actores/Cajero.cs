using TiendaD1_antes.Sistema;

namespace TiendaD1_antes.Actores
{
    internal class Cajero
    {
        private readonly ISistemaTienda _sistema;

        public Cajero(ISistemaTienda sistema)
        {
            _sistema = sistema;
        }

        public void RegistrarVenta(int idProducto, int cantidad)
        {
            _sistema.RegistrarVenta(idProducto, cantidad);
            _sistema.CobrarPago(idProducto, cantidad);
            _sistema.GenerarFactura(idProducto, cantidad);
        }
    }
}