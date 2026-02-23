using CorporateProCard.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporateProCard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Funcionario>()
                .HasOne(f => f.Cartao)
                .WithOne(c => c.Funcionario)
                .HasForeignKey<CartaoBeneficio>(c => c.FuncionarioId);

            builder.Entity<Funcionario>()
                .Property(f => f.Status)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Entity<Funcionario>()
                .Property(f => f.NivelAcesso)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Entity<CartaoBeneficio>()
                .Property(c => c.Status)
                .HasConversion<string>()
                .HasMaxLength(20);

        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<CartaoBeneficio> CartoesBeneficio { get; set; }
    }
}
