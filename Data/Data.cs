
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
namespace CRUD.Data;

public class  AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=data.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}