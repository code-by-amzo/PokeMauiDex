using PokeApi.Utils;

namespace PokeApi.Games.Versions;

public record Version
{
	public int Id { get; set; } = 0;
	public string Name { get; set; } = string.Empty;
	public List<Name> Names { get; set; } = [];
	public NamedApiResource VersionGroup { get; set; } = null!;
}