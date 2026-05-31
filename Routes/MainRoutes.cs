using CRUD.Models;
namespace CRUD.Routes;
using CRUD.Data;
using CRUD.ModelRequest;

public static class MainRoute
{

    public static void MainRoutes(this WebApplication app)
    {
        //this serve para chamar todas as rotas com app.MainRoutes()

    var route = app.MapGroup("person");
    route.MapPost("",
    async(ModelRequest req,AppDbContext context)=>
    {
        var person= new Usuario(req.name);
        await context.AddAsync(person);
        await context.SaveChangesAsync();
        return Results.Ok(person);
    });
    }



}