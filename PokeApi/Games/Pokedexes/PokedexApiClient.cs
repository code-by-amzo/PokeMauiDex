using PokeApi.Utils;

namespace PokeApi.Games.Pokedexes;

public class PokedexApiClient : BaseApiClient, IPokedexApiClient
{
	public PokedexApiClient(IHttpClientFactory httpClientFactory) 
		: base(httpClientFactory, "pokedex")
	{ }
	
	public async Task<NamedApiResourceList> GetList()
	{
		return await GetList<NamedApiResourceList>();
	}

	public async Task<Pokedex> Get(int id)
	{
		return await Get<Pokedex>(id.ToString());
	}

	public async Task<Pokedex> Get(string name)
	{
		return await Get<Pokedex>(name);
	}
}