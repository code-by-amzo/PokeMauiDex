using PokeApi.Utils;

namespace PokeApi.Games.Pokedexes;

public record Pokedex
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public bool IsMainSeries { get; set; }
	public List<Description> Descriptions { get; set; } = [];
	public List<Name> Names { get; set; } = [];
	public List<PokemonEntry> PokemonEntries { get; set; } = [];
	public NamedApiResource Region { get; set; } = null!;
	public List<NamedApiResource> VersionGroups { get; set; } = [];
}