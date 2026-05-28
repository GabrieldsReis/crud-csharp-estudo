namespace Main.Routes;


public static class MainRoute{

    public static void MainRoutes(this WebApplication app){ 
        //this serve para chamar todas as rotas com app.MainRoutes()

    app.MapGet("crud",() => "Ola pessoa !"); //endpoint

    }



}