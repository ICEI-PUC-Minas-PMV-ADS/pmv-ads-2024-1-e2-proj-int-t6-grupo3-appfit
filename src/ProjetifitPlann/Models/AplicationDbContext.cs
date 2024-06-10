using Microsoft.EntityFrameworkCore;

namespace ProjetifitPlann.Models
{
  
public class AplicationDbContext : DbContext

    {

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)

        {

        }

        public DbSet<Usuario> Usuarios { get; set; } = default!;

        public DbSet<Exercicio> Exercicios { get; set; } = default!;
    }

}
