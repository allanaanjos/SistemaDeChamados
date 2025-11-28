namespace SistemaDeChamados.Infra;
using Microsoft.EntityFrameworkCore;
using SistemaDeChamados.Domain;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { } 

    public DbSet<Categoria> Categorias { get; set;} 
    public DbSet<Operador> Operadors { get; set;}
    public DbSet<Ticket> Tickets { get; set;}

    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Categoria>().HasKey(c => c.CategoriaId);
        mb.Entity<Categoria>().Property(c => c.CategoriaId).ValueGeneratedOnAdd();
        mb.Entity<Categoria>().Property(c => c.Nome).HasMaxLength(100).IsRequired();
    
        mb.Entity<Operador>().HasKey(p => p.OperadorId);
        mb.Entity<Operador>().Property(p => p.OperadorId).ValueGeneratedOnAdd();
        mb.Entity<Operador>().Property(p => p.Nome).HasMaxLength(100).IsRequired();
        
        mb.Entity<Ticket>().HasKey(t => t.TicketId);
        mb.Entity<Ticket>().Property(t => t.TicketId).ValueGeneratedOnAdd();
        mb.Entity<Ticket>().Property(t => t.Solicitante).HasMaxLength(100).IsRequired();
        mb.Entity<Ticket>().Property(t => t.Assunto).HasMaxLength(300).IsRequired();
        mb.Entity<Ticket>().Property(t => t.Categoria).IsRequired();
        mb.Entity<Ticket>().Property(t => t.Operador).IsRequired();
        mb.Entity<Ticket>().Property(t => t.Criado).ValueGeneratedOnAdd()
       .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);


    }
     
}
