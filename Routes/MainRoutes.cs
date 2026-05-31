using CRUD.Models;
namespace CRUD.Routes;
using CRUD.Data;
using CRUD.ModelRequest;
using Microsoft.EntityFrameworkCore;
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
        route.MapGet("",async (AppDbContext context) =>
        {
            var people = await context.Usuarios.ToListAsync();
            return Results.Ok(people);
        });

            route.MapPut("{id:guid}",async(Guid id,ModelRequest req,AppDbContext context) =>
            {
                var person = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
                if(person == null)
                {
                    return Results.NotFound();
                }
                person.ChangeName(req.name);
                await context.SaveChangesAsync();
                return Results.Ok(person);
            });
            route.MapDelete("{id:guid}",async(Guid id,AppDbContext context) =>
            {
                var person = await context.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
                if(person == null)
                {
                    return Results.NotFound();
                }
                person.ChangeName("Desativado");
                await context.SaveChangesAsync();
                return Results.Ok(person);


            });
    }



}