namespace Wpm.Management.Domain;

public class Pet : IEquatable<Pet>
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int? Age { get; set; }

    public bool Equals(Pet? other)
    {
        if (ReferenceEquals(other, null)) return false;
        if (ReferenceEquals(this, other)) return true;

        return Id == other.Id &&
               Name == other.Name &&
               Age == other.Age;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Name, Age);
    }

    public static bool operator ==(Pet? left, Pet? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Pet? left, Pet? right)
    {
        return !Equals(left, right);
    }
}
