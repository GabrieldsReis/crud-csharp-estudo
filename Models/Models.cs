namespace CRUD.Models;

public class Usuario
{

    public Usuario(string name)
    {
        Name = name;
        Id = Guid.NewGuid(); //me retorna um id e o nom eh fornecido na rota
    }
    public Guid Id { get; init; } //evitar id iguais, aleatorio
    public string Name { get; private set; }

    public void ChangeName(string name)
    {
        Name=name;
    }


}