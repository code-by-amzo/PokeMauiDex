using PokeApi.Utils;

namespace PokeApi.Games.VersionGroups;

public record VersionGroup
{
	public int Id { get; set; } = 0;
	public string Name { get; set; } = string.Empty;
	public int Order { get; set; } = 0;
	public NamedApiResource Generation { get; set; } = null!;
	public List<NamedApiResource> MoveLearnMethods { get; set; } = [];
	public List<NamedApiResource> Pokedexes { get; set; } = [];
	public List<NamedApiResource> Regions { get; set; } = [];
	public List<NamedApiResource> Versions { get; set; } = [];
}