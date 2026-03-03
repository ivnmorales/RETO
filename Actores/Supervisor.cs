using TiendaD1_antes.Sistema;

namespace TiendaD1_antes.Actores
{
    internal class Supervisor
    {
        private readonly ISistemaTienda _sistema;

        public Supervisor(ISistemaTienda sistema)
        {
            _sistema = sistema;
        }

        public void AutorizarDevolucion(int idVenta)
        {
            _sistema.ProcesarDevolucion(idVenta);
        }

        public void VerReporteDiario()
        {
            _sistema.GenerarReporteDiario();
        }
    }
}