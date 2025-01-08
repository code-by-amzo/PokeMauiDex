using System.Text.Json;
using PokeMauiDex.App.Models;

namespace PokeMauiDex.App.Services;

public class PokedexService : IPokedexService
{
	private HttpClient _client;
	private Uri _pokedexUri;
	
	public PokedexService(HttpClient client)
	{
		_client = client;
		_pokedexUri = new Uri(_client.BaseAddress, "pokedex");
	}

	public async Task<PokedexListApiModel> GetAllPokedex()
	{
		var response = await _client.GetAsync(_pokedexUri);
		
		response.EnsureSuccessStatusCode();
		
		string responseBody = await response.Content.ReadAsStringAsync();
		
		PokedexListApiModel pokedexes = JsonSerializer.Deserialize<PokedexListApiModel>(responseBody, new JsonSerializerOptions()
		{
			PropertyNameCaseInsensitive = true
		}) ?? new PokedexListApiModel();
		
		return pokedexes;
	}
	
	public async Task<PokedexApiModel> GetPokedex(int id)
	{
		var response = await _client.GetAsync("pokedex/" + id);
		
		response.EnsureSuccessStatusCode();

		string responseBody = await response.Content.ReadAsStringAsync();

		PokedexApiModel? pokedex = JsonSerializer.Deserialize<PokedexApiModel>(responseBody);

		if (pokedex is null)
		{
			return new PokedexApiModel();
		}
		
		return pokedex;
	}

	public Task<PokedexApiModel> GetPokedex(string name)
	{
		throw new NotImplementedException();
	}
}