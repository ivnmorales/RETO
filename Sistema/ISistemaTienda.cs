namespace TiendaD1_antes.Sistema
{
    internal interface ISistemaTienda
    {
        // Caja
        void RegistrarVenta(int idProducto, int cantidad);

        // Bodega
        void ActualizarInventario(int idProducto, int cantidad);

        // Soporte
        void AtenderReclamo(int idReclamo);
    }
}