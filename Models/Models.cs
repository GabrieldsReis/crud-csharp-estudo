namespace CRUD.Models;

public class Models{

        public Models(string name)
    {
        Name = name;
        Id = Guid.NewGuid(); //me retorna um id e o nom eh fornecido na rota
    }
        public Guid Id {get; init; } //evitar id iguais, aleatorio
        public string Name { get ; private set;} 

}