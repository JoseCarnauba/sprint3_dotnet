using APIRadio.Model;
using Microsoft.EntityFrameworkCore; 

namespace APIRadio.Contexto
{
    public class RadioContext : DbContext
    {
        private object options;

        public RadioContext(DbContextOptions<RadioContext> options) : base(options) { }

        public RadioContext(object options)
        {
            this.options = options;
        }

        public DbSet<Usuario> Usuarios { get; set; }

        // Se necessário, você pode adicionar outras configurações de modelo aqui
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
   
        }
    }
}


