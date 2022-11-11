using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;

namespace MyFirstApp.Models
{
  public class Context : DbContext
  {
    //Criação de contextos, cria as tabelas no banco de dados conforme elas são criadas via classes.
    public DbSet<Categoria> categorias { get; set; }
    public DbSet<Produto> produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(connectionString: @"Server=./;Database=Db_Nerdflix;User Id=Andre;Password=nemecz;Integrated Security=False");
    }
  }
}
