namespace CRUD.Models;

public class Models{

        public Models(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
        public Guid Id {get; init; } //evitar id iguais,muito aleatorio
        public string Name {get;private set;} 

}