using TiendaD1_antes.Sistema;

namespace TiendaD1_antes.Actores
{
    internal class AuxiliarBodega
    {
        private readonly ISistemaTienda _sistema;

        public AuxiliarBodega(ISistemaTienda sistema)
        {
            _sistema = sistema;
        }

        public void AjustarInventario(int idProducto, int cantidad)
        {
            _sistema.ActualizarInventario(idProducto, cantidad);
        }
    }
}