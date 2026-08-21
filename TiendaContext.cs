namespace TiendaAPI

{
    using Microsoft.EntityFrameworkCore;
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> optiions)
            : base(optiions) { }
        
        public DbSet<Producto> Productos { get; set; }
    }
}
