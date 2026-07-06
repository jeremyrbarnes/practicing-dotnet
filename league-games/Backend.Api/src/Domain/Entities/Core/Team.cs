
namespace LeagueGames.Backend.Api.Domain.Entities.Core;

using LeagueGames.Backend.Api.Domain.Helpers;

public class Team : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public Location? Location { get; set; }
}