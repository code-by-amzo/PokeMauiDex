namespace PokeMauiDex.App.Models;

public class Pokedex
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public bool IsMainSeries { get; set; }
	public string RegionName { get; set; }
	public List<Pokemon> Pokemons { get; set; }
	
}