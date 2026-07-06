namespace LeagueGames.Backend.Api.Domain.Helpers;

public class Location
{
    public string Name { get; set; } = string.Empty;
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
}