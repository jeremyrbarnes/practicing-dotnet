namespace Wpm.Management.Domain.Tests;

public class PetUnitTests
{
    [Fact]
    public void Pet_should_be_equal()
    {
        Pet pet1 = new Pet
        {
            Id = Guid.NewGuid(),
        };

        Pet pet2 = new Pet
        {
            Id = pet1.Id,
        };

        Assert.True(pet1.Equals(pet2));
    }

    [Fact]
    public void Pet_should_not_be_equal()
    {
        Pet pet1 = new Pet
        {
            Id = Guid.NewGuid(),
        };

        Pet pet2 = new Pet
        {
            Id = Guid.NewGuid(),
        };

        Assert.False(pet1.Equals(pet2));
        Assert.True(pet1 != pet2);
    }
}
