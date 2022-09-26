using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SSL.Common.Entities;
using SSL.Data.Configuration;

namespace SSL.Data
{
    public class SSLContext : DbContext
    {
        public SSLContext(DbContextOptions<SSLContext> options) : base(options)
        {

        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UsuarioConfiguration).Assembly);
        }

        public class FocusForTeamsContextFactory : IDesignTimeDbContextFactory<SSLContext>
        {
            public SSLContext CreateDbContext(string[] args)
            {
                var con = args.FirstOrDefault();
                if (con == null) throw new ArgumentNullException("Connection null");

                var optionsBuilder = new DbContextOptionsBuilder<SSLContext>();
                optionsBuilder.UseSqlServer(con, sql => sql.MigrationsAssembly("SSL.Data"));

                return new SSLContext(optionsBuilder.Options);
            }
        }
    }
}