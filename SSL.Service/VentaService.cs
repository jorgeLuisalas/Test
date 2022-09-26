using SSL.Common.Entities;
using SSL.Common.Interfaces;
using SSL.Data;

namespace SSL.Service
{
    public class VentaService : IVentaService
    {
        private readonly SSLContext context;

        public VentaService(SSLContext context)
        {
            this.context = context;
        }

        public List<Venta> GetByUsuario(int usuarioId)
        {
            context.Ventas.Where(x=>x.);
        }
    }
}