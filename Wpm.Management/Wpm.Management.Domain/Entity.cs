namespace Wpm.Management.Domain
{
    public class Entity : IEquatable<Entity>
    {
        public Guid Id { get; init; }

        public bool Equals(Entity? other)
        {
            if (ReferenceEquals(other, null)) return false;
            if (ReferenceEquals(this, other)) return true;

            return Id == other.Id;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator ==(Entity? left, Entity? right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Entity? left, Entity? right)
        {
            return !Equals(left, right);
        }
    }
}