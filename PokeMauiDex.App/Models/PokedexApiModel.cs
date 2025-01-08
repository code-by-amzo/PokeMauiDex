namespace PokeMauiDex.App.Models;

public record PokedexApiModel
{
	public int Id { get; set; }
	public bool IsMainSeries { get; set; }
	public string Name { get; set; }
	public List<PokedexApiName> Names { get; set; }
	public List<PokedexApiDescription> Descriptions { get; set; }
	public List<PokedexApiPokemonEntry> PokemonEntries { get; set; }
	public RegionApiModel Region { get; set; }
	public List<VersionGroupApi> VersionGroups { get; set; }

	public Pokedex MapToPokedex()
	{
		return new Pokedex()
		{
			Id = Id,
			IsMainSeries = IsMainSeries,
			Name = Name,
			Description = Descriptions.Last().Description,
			RegionName = Region.Name,
			Pokemons = []
		};
	}
}

public record PokedexApiName(string Name, LanguageApiModel Language);
public record PokedexApiDescription(string Description, LanguageApiModel Language);
public record PokedexApiPokemonEntry(int EntryNumber, PokemonSpaciesApiModel PokemonSpacies);
public record PokemonSpaciesApiModel(string Name, string Url);
public record RegionApiModel(string Name, string Url);
public record VersionGroupApi(string Name, string Url);