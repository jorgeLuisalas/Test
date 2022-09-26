using SSL.Common.Entities;
using SSL.Common.Interfaces;
using SSL.Data;

namespace SSL.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly SSLContext context;

        public UsuarioService(SSLContext context)
        {
            this.context = context;
        }
        public Usuario Get(int id)
        {
            return context.Usuarios.SingleOrDefault(x=> x.Id == id);
        }
    }
}