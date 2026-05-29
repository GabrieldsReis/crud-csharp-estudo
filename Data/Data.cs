
using Microsoft.EntityFrameworkCore;
using CRUD.Models;
namespace CRUD.Data;

public class Data : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }


}