namespace PokeMauiDex.App.Models;

public class Pokemon
{
	public int Id { get; set; }
	public string Name { get; set; }
	public List<string> Types { get; set; }
}