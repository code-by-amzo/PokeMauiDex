namespace PokeMauiDex.App.Models;

public record PokedexListApiModel
{
	public int Count { get; set; }
	public string? Next { get; set; }
	public string? Previous { get; set; }
	public List<PokedexListApiPokedexes> Results { get; set; } = [];
}

public record PokedexListApiPokedexes(string Name, string Url);