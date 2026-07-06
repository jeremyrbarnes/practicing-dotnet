using System.Reflection.Metadata.Ecma335;

namespace LeagueGames.Backend.Api.Domain.Entities.Core;

public class Player : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName { get => FirstName + " " + LastName; }
}