using TiendaD1_antes.Sistema;

namespace TiendaD1_antes.Actores
{
    internal class AgenteSoporte
    {
        private readonly ISistemaTienda _sistema;

        public AgenteSoporte(ISistemaTienda sistema)
        {
            _sistema = sistema;
        }

        public void GestionarReclamo(int idReclamo)
        {
            _sistema.AtenderReclamo(idReclamo);
        }
    }
}