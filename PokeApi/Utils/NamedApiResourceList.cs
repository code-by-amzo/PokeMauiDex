namespace PokeApi.Utils;

public record NamedApiResourceList
{
	public int Count { get; set; } = 0;
	public string Next { get; set; } = string.Empty;
	public string Previous { get; set; } = string.Empty;
	public List<NamedApiResource> Results { get; set; } = [];
}