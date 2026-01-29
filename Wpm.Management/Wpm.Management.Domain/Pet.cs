namespace Wpm.Management.Domain;

public class Pet : Entity
{
    public string? Name { get; set; }
    public int? Age { get; set; }
    
    public Pet()
    {
        Id = Guid.NewGuid();
    }

    public Pet(Guid id)
    {
        Id = id;
    }
}
