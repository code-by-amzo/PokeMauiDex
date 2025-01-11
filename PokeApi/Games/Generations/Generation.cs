using PokeApi.Utils;

namespace PokeApi.Games.Generations;

public record Generation
{
	public int Id { get; set; } = 0;
	public string Name { get; set; } = string.Empty;
	public List<NamedApiResource> Abilities { get; set; } = [];
	public List<Name> Names { get; set; } = [];
	public NamedApiResource MainRegion { get; set; } = null!;
	public List<NamedApiResource> Moves { get; set; } = [];
	public List<NamedApiResource> PokemonSpecies { get; set; } = [];
	public List<NamedApiResource> Types { get; set; } = [];
	public List<NamedApiResource> VersionGroups { get; set; } = [];
}
