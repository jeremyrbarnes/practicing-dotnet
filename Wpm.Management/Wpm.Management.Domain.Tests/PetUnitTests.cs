namespace Wpm.Management.Domain.Tests;

public class PetUnitTests
{
    [Fact]
    public void Pet_should_be_equal()
    {
        Pet pet1 = new Pet
        {
            Id = Guid.NewGuid(),
            Name = "Fido",
            Age = 3
        };

        Pet pet2 = new Pet
        {
            Id = pet1.Id,
            Name = "Fido",
            Age = 3
        };

        Assert.Equal(pet1.Id, pet2.Id);
        Assert.Equal(pet1.Name, pet2.Name);
        Assert.Equal(pet1.Age, pet2.Age);
    }
}
